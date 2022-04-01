using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using System.IO;

namespace WindowsFormsApp.Controls
{
    public partial class PlayerControlYC : UserControl
    {
        public Player Player { get; set; }

        public PlayerControlYC(Player player)
        {
            InitializeComponent();
            lblName.Text = GetLanguageTranslation.GetTranslation("lblName");
            lblNumber.Text = GetLanguageTranslation.GetTranslation("lblShirtNumber");
            lblPosition.Text = GetLanguageTranslation.GetTranslation("lblPosition");
            lblCapitan.Text = GetLanguageTranslation.GetTranslation("lblCaptain");
            lblYellowCards.Text = GetLanguageTranslation.GetTranslation("lblYellowCards");

            Player = player;
            lblNamePlaceholder.Text = Player.Name;
            lblNumberPlaceholder.Text = Player.ShirtNumber.ToString();

            lblPositionPlaceholder.Text = Player.Position;
            if (Player.Captain == true)
            {
                lblCapitanPlaceholder.Text = GetLanguageTranslation.GetTranslation("captainYes");
            }
            else
            {
                lblCapitanPlaceholder.Text = GetLanguageTranslation.GetTranslation("captainNo");
            }
        }

        public void SetGoalsOrCardsValue(string value)
        {
            lblYellowCardsPlaceholder.Text = value;
            lblYellowCardsPlaceholder.Visible = true;
        }

        private void BtnSetPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files |*.png;*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = new Bitmap(opnfd.FileName);
                File.WriteAllText($"{System.IO.Path.GetTempPath()}{Player.Name}.txt", opnfd.FileName);
            }
        }
    }
}
