using Data.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Forms;

namespace WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppService appSettingsService = new AppService();

            if (appSettingsService.GetAplicationSettings() == null)
            {
                //pocetno smo stavili hrvatski
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("hr-HR");
                var settingsForm = new SettingsForm();
                var result = settingsForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Application.Run(new SettingsForm());
                }

            }
            else
            {
                Application.Run(new SettingsForm());
            }

        }
    }
}
