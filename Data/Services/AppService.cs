using Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class AppService
    {
        private string AppSettingsFile;
        const string male = "Male";
        const string female = "Female";
        const string english = "English";
        const string croatian = "Croatian";

        public AppService()
        {
            AppSettingsFile = $"{System.IO.Path.GetTempPath()}OOPAppSettings.txt";
        }

        public AppSettings GetAplicationSettings()
        {
            AppSettings appSettings = new AppSettings();

            if (File.Exists(AppSettingsFile))
            {
                string[] lines = File.ReadAllLines(AppSettingsFile);
                if (lines[0] == male)
                {
                    appSettings.Gender = Gender.Male;
                }
                else
                {
                    appSettings.Gender = Gender.Female;
                }
                if (lines[1] == english)
                {
                    appSettings.Language = Language.English;
                }
                else
                {
                    appSettings.Language = Language.Croatian;
                }
                return appSettings;
            }
            else
            {
                return null;
            }
        }

        public bool SaveSettings(AppSettings appSettings)
        {
            string championship;
            string language;
            if (appSettings.Gender == Gender.Male)
            {
                championship = male;
            }
            else
            {
                championship = female;
            }
            if (appSettings.Language == Language.English)
            {
                language = english;
            }
            else
            {
                language = croatian;
            }
            string[] lines =
            {
                championship,
                language
            };

            File.WriteAllLines(AppSettingsFile, lines);
            return true;
        }
    }
}
