﻿using Data.Models;
using Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Forms
{
    public partial class GamesInformationForm : Form
    {
        DataService dataService = new DataService();

        public GamesInformationForm()
        {
            InitializeComponent();
            GetInfo();

        }

        public async void GetInfo()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(
                new DataColumn[4]
                {
                    new DataColumn(GetLanguageTranslation.GetTranslation("location"),typeof(string)),
                    new DataColumn(GetLanguageTranslation.GetTranslation("visitorsNumber"),typeof(string)),
                    new DataColumn(GetLanguageTranslation.GetTranslation("homeTeam"),typeof(string)),
                    new DataColumn(GetLanguageTranslation.GetTranslation("awayTeam"),typeof(string))
                }
                );
            dgGames.DataSource = dataTable;
            List<GameStats> gameStats = new List<GameStats>();

            var loadingForm = new LoadingForm();
            loadingForm.Show();
            await Task.Run(async () =>
            {
                gameStats = await dataService.GetGamesInfo();
            });
            loadingForm.Close();

            List<GameStats> sortedStats = gameStats.OrderBy(i => i.Visitors).Reverse().ToList();
            foreach (var info in sortedStats)
            {
                dataTable.Rows.Add(info.Location, info.Visitors, info.HomeTeam, info.AwayTeam);
            }

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();

        }

        private void PrintDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (e.PrintAction == PrintAction.PrintToPrinter)
            {
                MessageBox.Show("Printanje je gotovo");
            }
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var x = e.MarginBounds.Left;
            var y = e.MarginBounds.Top;
            var bmp = new Bitmap(this.Size.Width, this.Size.Height);

            this.DrawToBitmap(bmp, new Rectangle
            {
                X = 0,
                Y = 0,
                Width = this.Size.Width,
                Height = this.Size.Height
            });
            e.Graphics.DrawImage(bmp, x, y);
        }
    }
}
