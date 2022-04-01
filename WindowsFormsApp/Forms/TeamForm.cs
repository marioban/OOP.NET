using Data.Models;
using Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Controls;

namespace WindowsFormsApp.Forms
{
    public partial class TeamForm : Form
    {
        private List<MatchResult> matchResults = new List<MatchResult>();
        private List<Player> players = new List<Player>();
        private DataService dataService = new DataService();
        private Language language;

        public TeamForm()
        {
            InitializeComponent();
            this.FormClosed += TeamForm_FormClosed;
            SetCulture();
        }

        private void SetCulture()
        {
            language = dataService.GetLanguage();
            if (language == Language.Croatian)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr-HR");
                LoadFormLanguage();
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-EN");
                LoadFormLanguage();
            }
        }

        private void LoadFormLanguage()
        {
            
            btnSelect.Text = GetLanguageTranslation.GetTranslation("save");
            btnGameInfo.Text = GetLanguageTranslation.GetTranslation("gameInformation");
            btnListGoals.Text = GetLanguageTranslation.GetTranslation("goalList");
            btnYellowCards.Text = GetLanguageTranslation.GetTranslation("yellowCardList");
            lblChooseTeam.Text = GetLanguageTranslation.GetTranslation("pickTeam");
            lblChosenTeam.Text = GetLanguageTranslation.GetTranslation("pickedTeam");
            lblFavouritePlayers.Text = GetLanguageTranslation.GetTranslation("favoritePlayers");
        }


        private void TeamForm_Load(object sender, EventArgs e)
        {
            SetCulture();
            LoadTeamsInForm();
        }

        public async void LoadTeamsInForm()
        {

            ddlTeams.Items.Clear();
            lblCountry.Text = null;
            string country = dataService.GetFavoriteTeam();

            var loadingForm = new LoadingForm();
            loadingForm.Show();
            List<Team> teams = new List<Team>();
            await Task.Run(async () =>
            {
                teams = await dataService.GetTeams();
            });

            loadingForm.Close();
            foreach (Team team in teams)
            {
                ddlTeams.Items.Add(team);
                if (team.ToString() == country)
                {
                    ddlTeams.SelectedItem = team;
                }
            }
            lblCountry.Text = country;
            await LoadPlayers();

        }

        private async void BtnSelect_Click(object sender, EventArgs e) => await LoadPlayers();

        private async Task LoadPlayers()
        {

            flpFavouritePlayers.Controls.Clear();
            List<Player> favouritePlayers = dataService.ReadFavoritePlayers();
            flpTeam.Controls.Clear();
            var selectedTeam = (ddlTeams.SelectedItem as Team)?.Country;

            if (selectedTeam != null)
            {
                var loadingForm = new LoadingForm();
                loadingForm.Show();
                await Task.Run(async () =>
                {
                    players = await dataService.GetPlayers(selectedTeam);
                });
                loadingForm.Close();
                lblCountry.Text=selectedTeam;

                foreach (Player player in players)
                {
                    var imagePath = $"{Path.GetTempPath()}{player.Name}.txt";
                    PlayerControl playerContorl = new PlayerControl(player);

                    if (File.Exists(imagePath))
                    {
                        playerContorl.SetPicture(File.ReadAllText(imagePath));
                    }
                    else
                    {
                        playerContorl.SetPicture(@"C:\Users\MarioB\Desktop\MarioBanOOP.NET\WindowsFormsApp\Pictures\headshot-default.png");
                    }

                    if (favouritePlayers != null)
                    {
                        if (favouritePlayers.Find(x => x.Name == player.Name) != null)
                        {
                            flpFavouritePlayers.Controls.Add(playerContorl);
                            playerContorl.FavoriteStar(true);
                        }
                        else
                        {
                            flpTeam.Controls.Add(playerContorl);
                        }
                    }
                    else
                    {
                        flpTeam.Controls.Add(playerContorl);
                    }
                }
            }
            InitDragAndDrop();
        }

        private void InitDragAndDrop()
        {
            flpTeam.DragEnter += FlpTeam_DragEnter;
            flpTeam.DragDrop += FlpTeam_DragDrop;
            flpFavouritePlayers.DragEnter += FlpFavouritePlayers_DragEnter;
            flpFavouritePlayers.DragDrop += FlpFavouritePlayers_DragDrop;
        }

        private void FlpFavouritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            PlayerControl playerControl = (PlayerControl)e.Data.GetData(typeof(PlayerControl));
            flpFavouritePlayers.Controls.Add(playerControl);
            playerControl.FavoriteStar(true);
        }

        private void FlpFavouritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void FlpTeam_DragDrop(object sender, DragEventArgs e)
        {
            PlayerControl playerControl = (PlayerControl)e.Data.GetData(typeof(PlayerControl));
            flpTeam.Controls.Add(playerControl);
            playerControl.FavoriteStar(false);
        }

        private void FlpTeam_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }


        public void TeamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Player> favoritePlayerList = new List<Player>();
            foreach (var item in flpFavouritePlayers.Controls)
            {
                if (item is PlayerControl)
                {
                    PlayerControl playerControl = item as PlayerControl;
                    favoritePlayerList.Add(playerControl.Player);
                }
            }
            if (ddlTeams.SelectedItem != null)
            {
                string country = ddlTeams.SelectedItem.ToString();
                dataService.WriteFavoriteTeam(country);
                dataService.WriteFavoritePlayers(favoritePlayerList);
            }
        }

        private void BtnGameInfo_Click(object sender, EventArgs e)
        {
            string selectedTeam = (ddlTeams.SelectedItem as Team)?.Country;
            if (selectedTeam == null)
            {
                MessageBox.Show(GetLanguageTranslation.GetTranslation("pickTeamWarning"));
            }
            else
            {
                dataService.SetSelectedTeam(selectedTeam);
                GamesInformationForm gamesInformation = new GamesInformationForm();
                gamesInformation.Show();
            }
        }

        private void BtnListGoals_Click(object sender, EventArgs e)
        {
            string selectedTeam = (ddlTeams.SelectedItem as Team)?.Country;
            if (selectedTeam == null)
            {
                MessageBox.Show(GetLanguageTranslation.GetTranslation("pickTeamWarning"));
            }
            else
            {
                dataService.SetSelectedTeam(selectedTeam);
                GoalsStatsForm goalsStatisticsForm = new GoalsStatsForm();
                goalsStatisticsForm.Show();
            }
        }

        private void BtnYellowCards_Click(object sender, EventArgs e)
        {
            string selectedTeam = (ddlTeams.SelectedItem as Team)?.Country;
            if (selectedTeam == null)
            {
                MessageBox.Show(GetLanguageTranslation.GetTranslation("pickTeamWarning"));
            }
            else
            {
                dataService.SetSelectedTeam(selectedTeam);
                YellowCardsStatsForm yellowCardsStats = new YellowCardsStatsForm();
                yellowCardsStats.Show();
            }
        }


        private void TeamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public bool CloseCancel()
        {
            string message = GetLanguageTranslation.GetTranslation("closeConfirmation");
            string caption = GetLanguageTranslation.GetTranslation("confirmation");
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
    }
}
