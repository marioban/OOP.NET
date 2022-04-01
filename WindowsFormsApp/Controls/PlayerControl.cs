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
    public partial class PlayerControl : UserControl
    {
        public Player Player { get; set; }

        public PlayerControl(Player player)
        {
            InitializeComponent();
            lblName.Text = GetLanguageTranslation.GetTranslation("lblName");
            lblNumber.Text = GetLanguageTranslation.GetTranslation("lblShirtNumber");
            lblPosition.Text = GetLanguageTranslation.GetTranslation("lblPosition");
            lblCapitan.Text = GetLanguageTranslation.GetTranslation("lblCaptain");
            lblGoals.Text = GetLanguageTranslation.GetTranslation("lblGoals");

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

        public void SetPicture(string path)
        {
            pbPicture.Image = Image.FromFile(path);
        }

        public void FavoriteStar(bool star)
        {
            pbFavourite.Image = null;
            if (star)
            {
                pbFavourite.Image = Image.FromFile(@"C:/Users/MarioB/Desktop/MarioBanOOP.NET/WindowsFormsApp/Pictures/favourite.png");
            }
            else
            {
                pbFavourite.Image = null;
            }
        }

        public void SetGoalsOrCardsValue(string value)
        {
            lblGoalsPlaceholder.Text = value;
            lblGoalsPlaceholder.Visible = true;
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

        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(sender, DragDropEffects.Move);
        }
    }
}
