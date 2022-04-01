using Data.Models;
using Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Controls;

namespace WindowsFormsApp.Forms
{
    public partial class GoalsStatsForm : Form
    {
        public DataService dataService = new DataService();
        List<PlayerStats> playerStats = new List<PlayerStats>();
        public string fifaCode = DataService.fifaCode;
        public GoalsStatsForm()
        {
            InitializeComponent();
            GetPlayers();
        }

        private async void GetPlayers()
        {
            List<Player> players = new List<Player>();
            var loadingForm = new LoadingForm();
            loadingForm.Show();
            await Task.Run(async () =>
            {
                players = await dataService.GetPlayers(fifaCode);
            });
            loadingForm.Close();
            ShowPlayersStatistics(players, fifaCode);
        }

        private async void ShowPlayersStatistics(List<Player> players, string fifaCode)
        {
            flpGoals.Controls.Clear();
            await GetEvents(players, fifaCode);
            List<PlayerStats> sortedStatisticsList = playerStats.OrderBy(o => o.goals).Reverse().ToList();
            int itteration = 0;
            foreach (var item in sortedStatisticsList)
            {
                Player p = item.player;
                PlayerControl playerControl = new PlayerControl(p);
                playerControl.SetGoalsOrCardsValue($"{ sortedStatisticsList[itteration].goals}");
                flpGoals.Controls.Add(playerControl);
                itteration++;
            }
        }

        private async Task GetEvents(List<Player> players, string fifaCode)
        {
            List<MatchResult> matchResults = await dataService.GetAllMatchResults();
            var results = matchResults.Where(x => x.HomeTeamCountry == fifaCode || x.AwayTeamCountry == fifaCode);
            foreach (var p in players)
            {
                playerStats.Add(new PlayerStats { player = p });
            }
            foreach (var matchResult in results)
            {
                foreach (var teamEvent in matchResult.HomeTeamEvents)
                {
                    if ((teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty"))
                    {
                        foreach (var player in playerStats)
                        {
                            if (teamEvent.Player == player.ToString())
                            {
                                player.goals++;
                            }
                        }
                    }
                }
                foreach (var teamEvent in matchResult.AwayTeamEvents)
                {
                    if ((teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty"))
                    {
                        foreach (var player in playerStats)
                        {
                            if (teamEvent.Player == player.ToString())
                            {
                                player.goals++;
                            }
                        }
                    }
                }

            }
        }
        
    }
}
