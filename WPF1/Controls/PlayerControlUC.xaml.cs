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
using WPF1.Windows;

namespace WPF1.Controls
{
    /// <summary>
    /// Interaction logic for PlayerControlUC.xaml
    /// </summary>
    public partial class PlayerControlUC : UserControl
    {
        public Player Player { get; set; }
        int goals = 0;
        int yellowCards = 0;

        public PlayerControlUC(Player player,List<TeamEvent>events)
        {
            InitializeComponent();
            Player = player;
            this.DataContext = Player;

            foreach (var item in events)
            {
                if (item.TypeOfEvent=="goal"||item.TypeOfEvent=="goal-penalty")
                {
                    if (player.Name.ToString()==item.Player)
                    {
                        goals++;
                    }
                }
                if (item.TypeOfEvent=="yellow-card")
                {
                    if (player.Name.ToString()==item.Player)
                    {
                        yellowCards++;
                    }
                }
            }
        }



        public void lblPlayerName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window playerInformation = new PlayerInformation(Player, goals, yellowCards);
            playerInformation.Show();
        }

        public void SetPicture(string path)
        {
            string packUri = path;
            iconImage.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;

        }
    }
}
