using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsFormsApp;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TeamWindow : Window
    {
        
        public TeamWindow(TeamInformation teamInformation)
        {
            InitializeComponent();
            lblCountryData.Content = teamInformation.Country;
            lblCodeData.Content = teamInformation.FifaCode;
            lblGamesPlayedData.Content = teamInformation.GamesPlayed.ToString();
            lblWinsData.Content = teamInformation.Wins.ToString();
            lblLossesData.Content = teamInformation.Losses.ToString();
            lblDrawsData.Content = teamInformation.Draws.ToString();
            lblGoalsForData.Content = teamInformation.GoalsFor.ToString();
            lblGoalsAgainstsData.Content = teamInformation.GoalsAgainst.ToString();
            lblGoalDifferentialData.Content = teamInformation.GoalDifferential.ToString();
        }

    }
}
