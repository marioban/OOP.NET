using Data.Models;
using Data.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WPF1.Windows;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void ApplicationStart(object sender, StartupEventArgs e)
        {
            var appSettingsService = new AppService();
            var appSettings = appSettingsService.GetAplicationSettings();

            if (appSettings == null)
            {
                SetLanguage(Language.Croatian);
                var settingsWindow = new SettingsWindow();
                Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                Current.MainWindow = settingsWindow;
                settingsWindow.Show();
            }
            else
            {
                SetLanguage(appSettings.Language);
                TeamsWindow teamsWindow = new TeamsWindow();
                Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                Current.MainWindow = teamsWindow;
                teamsWindow.Show();
            }
        }

        private void SetLanguage(Language language)
        {

            AppService appSettingsService = new AppService();

    
            
                //pocetno smo stavili hrvatski
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("hr-HR");

        }
    }
}

