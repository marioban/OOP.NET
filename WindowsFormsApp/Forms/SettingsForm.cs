using Data;
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

namespace WindowsFormsApp.Forms
{
    public partial class SettingsForm : Form
    {
        public AppService appSettingsService = new AppService();
        public AppSettings appSettings = new AppSettings();

        public SettingsForm()
        {
            InitializeComponent();
            TranslateForm();

        }

        private void TranslateForm()
        {
            this.Text = GetLanguageTranslation.GetTranslation("settings");
            lblLanguage.Text = GetLanguageTranslation.GetTranslation("chooseLanguage");
            lblGender.Text = GetLanguageTranslation.GetTranslation("chooseGender");
            rbMale.Text = GetLanguageTranslation.GetTranslation("maleChampionship");
            rbFemale.Text = GetLanguageTranslation.GetTranslation("femaleChampionship");
            rbCroatian.Text = GetLanguageTranslation.GetTranslation("croatianLanguage");
            rbEnglish.Text = GetLanguageTranslation.GetTranslation("englishLanguage");
            btnConfirm.Text = GetLanguageTranslation.GetTranslation("submit");
            btnCancel.Text = GetLanguageTranslation.GetTranslation("cancel");
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (!rbCroatian.Checked && !rbEnglish.Checked)
            {
                MessageBox.Show(GetLanguageTranslation.GetTranslation("languageIsMandatory"));

                return;
            }

            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show(GetLanguageTranslation.GetTranslation("genderIsMandatory"));

                return;
            }

            if (rbCroatian.Checked)
            {
                appSettings.Language = Language.Croatian;
            }
            else
            {
                appSettings.Language = Language.English;
            }
            if (rbMale.Checked)
            {
                appSettings.Gender = Gender.Male;
            }
            else
            {
                appSettings.Gender = Gender.Female;
            }
            appSettingsService.SaveSettings(appSettings);
            this.DialogResult = DialogResult.OK;
            this.Hide();
            TeamForm teamForm = new TeamForm();
            teamForm.ShowDialog();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            AppService settingService = new AppService();
            AppSettings settings = settingService.GetAplicationSettings();

            if (settings == null)
            {
                return;
            }

            if (appSettings.Language == Language.Croatian)
            {
                rbCroatian.Checked = true;
            }
            else
            {
                rbEnglish.Checked = true;
            }

            if (appSettings.Gender == Gender.Male)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
        }
    }
}
