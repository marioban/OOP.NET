using Data;
using Data.Models;
using Data.Services;
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
using System.Windows.Shapes;

namespace WPF1.Windows
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public AppSettings appSettings = new AppSettings();
        public AppService appService = new AppService();
        public Language language;
        public SettingsWindow()
        {
            InitializeComponent();

            appSettings = appService.GetAplicationSettings();

            if (appSettings==null)
            {

            }
            else
            {
                if (appSettings.Gender==Gender.Male)
                {
                    rbMale.IsChecked = true;
                }
                else
                {
                    rbFemale.IsChecked = true;
                }

                if (appSettings.Language == Data.Models.Language.Croatian)
                {
                    rbCroatianLanguage.IsChecked = true;
                }
                else
                {
                    rbEnglishLanguage.IsChecked = true;
                }
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            AppSettings appSettings = new AppSettings();
            AppService service = new AppService();

            if (rbMale.IsChecked == true)
            {
                appSettings.Gender = Gender.Male;
            }
            else
            {
                appSettings.Gender = Gender.Female;
            };
            if (rbCroatianLanguage.IsChecked == true)
            {
                appSettings.Language = Data.Models.Language.Croatian;
            }
            else
            {
                appSettings.Language = Data.Models.Language.English;
            }
            service.SaveSettings(appSettings);
            TeamsWindow teamsWindow = new TeamsWindow();
            this.Hide();
            teamsWindow.Show();

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Close Application?", "Question",
                                MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result==MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
