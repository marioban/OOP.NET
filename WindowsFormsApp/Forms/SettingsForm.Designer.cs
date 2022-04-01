namespace WindowsFormsApp.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbCroatian = new System.Windows.Forms.RadioButton();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbEnglish);
            this.panel2.Controls.Add(this.rbCroatian);
            this.panel2.Controls.Add(this.lblLanguage);
            this.panel2.Location = new System.Drawing.Point(12, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 100);
            this.panel2.TabIndex = 13;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(11, 66);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(75, 21);
            this.rbEnglish.TabIndex = 6;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbCroatian
            // 
            this.rbCroatian.AutoSize = true;
            this.rbCroatian.Location = new System.Drawing.Point(10, 39);
            this.rbCroatian.Name = "rbCroatian";
            this.rbCroatian.Size = new System.Drawing.Size(80, 21);
            this.rbCroatian.TabIndex = 5;
            this.rbCroatian.TabStop = true;
            this.rbCroatian.Text = "Hrvatski";
            this.rbCroatian.UseVisualStyleBackColor = true;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(7, 10);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(91, 17);
            this.lblLanguage.TabIndex = 4;
            this.lblLanguage.Text = "Odaberi jezik";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 100);
            this.panel1.TabIndex = 12;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(10, 66);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(142, 21);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Žensko prvenstvo";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(9, 39);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(136, 21);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Muško prvenstvo";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(7, 13);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(186, 17);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Odaberite željeno prvenstvo";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 5;
            this.btnCancel.Location = new System.Drawing.Point(12, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(213, 45);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatAppearance.BorderSize = 5;
            this.btnConfirm.Location = new System.Drawing.Point(12, 261);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(213, 45);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Postavi";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbCroatian;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}