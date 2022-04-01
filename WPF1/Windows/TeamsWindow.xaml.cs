using Data.Models;
using Data.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPF1.Controls;

namespace WPF1.Windows
{
    /// <summary>
    /// Interaction logic for TeamsWindow.xaml
    /// </summary>
    public partial class TeamsWindow : Window
    {
        public DataService dataService = new DataService();
        public TeamInformation favoriteTeamInformation = new TeamInformation();
        public TeamInformation opponentTeamInformation = new TeamInformation();
        public List<Team> teams = new List<Team>();
        public Language language;
        public string result;

        public TeamsWindow()
        {
            //SetLanguage(language);
            InitializeComponent();
        }


        //public void SetLanguage(Language language)
        //{
        //    ResourceDictionary dict = new ResourceDictionary();
        //    if (language == Data.Models.Language.Croatian)
        //    {
        //        dict.Source = new Uri(@"C:\Users\MarioB\Desktop\MarioBanOOP.NET\WPF1\Properties\Resources.resx",
        //                              UriKind.Absolute);
        //    }
        //    else
        //    {
        //        dict.Source = new Uri(@"C:\Users\MarioB\Desktop\MarioBanOOP.NET\WPF1\Properties\Resources.en.resx",
        //                               UriKind.Absolute);
        //    }

        //    this.Resources.MergedDictionaries.Add(dict);
        //}

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadTeamsInForm();
        }

        public void Window_Closed(object sender, EventArgs e)
        {
            if (ddlCountries.SelectedItem != null)
            {
                string country = ddlCountries.SelectedItem.ToString();
            }
        }

        public async void LoadTeamsInForm()
        {
            ddlCountries.Items.Clear();
            string country = dataService.GetFavoriteTeam();

            await Task.Run(async () =>
            {
                teams = await dataService.GetTeams();
            });

            foreach (Team t in teams)
            {
                ddlCountries.Items.Add(t);
                if (t.ToString() == country)
                {
                    ddlCountries.SelectedItem = t;
                }
            }
        }

        private async Task GetTeamOpponents()
        {
            ddlVersusCountries.Items.Clear();
            List<Team> opponentTeams = new List<Team>();
            var selectedTeam = (ddlCountries.SelectedItem as Team)?.Country;
            await Task.Run(async () =>
            {

                opponentTeams = await dataService.GetOpponents(selectedTeam);
            });
            ddlVersusCountries.Text = selectedTeam; 

            foreach (Team team in opponentTeams)
            {
                ddlVersusCountries.Items.Add(team);
            }
        }

        private async void ChosenFavoriteTeam(object sender, SelectionChangedEventArgs e)
        {
            await GetTeamOpponents();
        }

        private async void OpponentTeamChosen(object sender, SelectionChangedEventArgs e)
        {
            firstGridDeffender.Children.Clear();
            firstGridGoalie.Children.Clear();
            firstGridMidfield.Children.Clear();
            firstGridForward.Children.Clear();
            secondGridDeffender.Children.Clear();
            secondGridGoalie.Children.Clear();
            secondGridMidfield.Children.Clear();
            secondGridForward.Children.Clear();

            string selectedFavoriteTeam = (ddlCountries.SelectedItem as Team)?.Country;
            string selectedOpponentTeam = (ddlVersusCountries.SelectedItem as Team)?.Country;
            List<TeamEvent> homeTeamEvents = await dataService.GetEvents(selectedFavoriteTeam, selectedOpponentTeam);
            List<TeamEvent> opponentTeamEvents = await dataService.GetEvents(selectedOpponentTeam, selectedFavoriteTeam);

            await Task.Run(async () =>
            {
                result = await dataService.GetScore(selectedFavoriteTeam, selectedOpponentTeam);
            });
            lblResult.Content = result;
            List<Player> favoriteTeamplayers = new List<Player>();
            await Task.Run(async () =>
            {
                favoriteTeamplayers = await dataService.GetStartingEleven(selectedFavoriteTeam, selectedOpponentTeam);
            });
            List<Player> opponentTeamPlayers = new List<Player>();
            await Task.Run(async () =>
            {
                opponentTeamPlayers = await dataService.GetStartingEleven(selectedOpponentTeam, selectedFavoriteTeam);
            });



            int midfield = 0;
            int defender = 0;
            int attacker = 0;
            foreach (Player player in favoriteTeamplayers)
            {

                PlayerControlUC playerControl = new PlayerControlUC(player, homeTeamEvents);
                var imagePath = $"{System.IO.Path.GetTempPath()}{player.Name}.txt";
                if (File.Exists(imagePath))
                {
                    playerControl.SetPicture(File.ReadAllText(imagePath));
                }
                switch (player.Position)
                {
                    case "Goalie":
                        RowDefinition gridRow1 = new RowDefinition();
                        gridRow1.Height = GridLength.Auto;
                        firstGridGoalie.RowDefinitions.Add(gridRow1);
                        Grid.SetRow(playerControl, 1);
                        firstGridGoalie.Children.Add(playerControl);

                        break;
                    case "Defender":
                        RowDefinition deffenderRow = new RowDefinition();
                        deffenderRow.Height = GridLength.Auto;
                        firstGridDeffender.RowDefinitions.Add(deffenderRow);
                        Grid.SetRow(playerControl, defender);
                        firstGridDeffender.Children.Add(playerControl);
                        defender++;
                        break;
                    case "Midfield":
                        RowDefinition midfieldRow = new RowDefinition();
                        midfieldRow.Height = GridLength.Auto;
                        firstGridMidfield.RowDefinitions.Add(midfieldRow);
                        Grid.SetRow(playerControl, midfield);
                        firstGridMidfield.Children.Add(playerControl);
                        midfield++;
                        break;
                    case "Forward":

                        RowDefinition forwardRow = new RowDefinition();
                        forwardRow.Height = GridLength.Auto;
                        firstGridForward.RowDefinitions.Add(forwardRow);
                        Grid.SetRow(playerControl, attacker);
                        firstGridForward.Children.Add(playerControl);
                        attacker++;
                        break;
                }
            }
            midfield = 0;
            defender = 0;
            attacker = 0;
            foreach (Player player in opponentTeamPlayers)
            {
                PlayerControlUC playerControl = new PlayerControlUC(player, opponentTeamEvents);
                switch (player.Position)
                {
                    case "Goalie":
                        RowDefinition gridRow1 = new RowDefinition();
                        gridRow1.Height = GridLength.Auto;
                        secondGridGoalie.RowDefinitions.Add(gridRow1);
                        Grid.SetRow(playerControl, 1);
                        secondGridGoalie.Children.Add(playerControl);

                        break;
                    case "Defender":
                        RowDefinition secondDeffenderRow = new RowDefinition();
                        secondDeffenderRow.Height = GridLength.Auto;
                        secondGridDeffender.RowDefinitions.Add(secondDeffenderRow);
                        Grid.SetRow(playerControl, defender);
                        secondGridDeffender.Children.Add(playerControl);
                        defender++;
                        break;
                    case "Midfield":
                        RowDefinition secondMidfieldRow = new RowDefinition();
                        secondMidfieldRow.Height = GridLength.Auto;
                        secondGridMidfield.RowDefinitions.Add(secondMidfieldRow);
                        Grid.SetRow(playerControl, midfield);
                        secondGridMidfield.Children.Add(playerControl);
                        midfield++;
                        break;
                    case "Forward":

                        RowDefinition secondForwardRow = new RowDefinition();
                        secondForwardRow.Height = GridLength.Auto;
                        secondGridForward.RowDefinitions.Add(secondForwardRow);
                        Grid.SetRow(playerControl, attacker);
                        secondGridForward.Children.Add(playerControl);
                        attacker++;
                        break;
                }
            }
        }

        private async void btnFavoriteTeamDetails(object sender, RoutedEventArgs e)
        {
            TeamInformation teamInformation = new TeamInformation();
            string selectedCountry = (ddlCountries.SelectedItem as Team)?.Country;
            await Task.Run(async () =>
            {
                teamInformation = await dataService.GetTeamInformation(selectedCountry);
            });
            Window teamInfo = new TeamWindow(teamInformation);
            teamInfo.Show();
        }

        private async void btnOpponentTeamDetails(object sender, RoutedEventArgs e)
        {
            TeamInformation teamInformation = new TeamInformation();
            string selectedCountry = (ddlVersusCountries.SelectedItem as Team)?.Country;
            await Task.Run(async () =>
            {
                teamInformation = await dataService.GetTeamInformation(selectedCountry);
            });
            Window teamInfo = new TeamWindow(teamInformation);
            teamInfo.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CloseCancel()==false)
            {
                e.Cancel = true;
            }
        }

        public bool CloseCancel()
        {
            var result = MessageBox.Show("Close Application?", "Question",
                                 MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
                return true;
            else
                return false;
        }

    }
}
