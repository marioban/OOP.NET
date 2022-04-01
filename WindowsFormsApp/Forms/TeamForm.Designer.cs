namespace WindowsFormsApp.Forms
{
    partial class TeamForm
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
            this.btnListGoals = new System.Windows.Forms.Button();
            this.btnGameInfo = new System.Windows.Forms.Button();
            this.btnYellowCards = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblFavouritePlayers = new System.Windows.Forms.Label();
            this.flpFavouritePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTeam = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCountry = new System.Windows.Forms.Label();
            this.ddlTeams = new System.Windows.Forms.ComboBox();
            this.lblChosenTeam = new System.Windows.Forms.Label();
            this.lblChooseTeam = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListGoals
            // 
            this.btnListGoals.Location = new System.Drawing.Point(175, 767);
            this.btnListGoals.Name = "btnListGoals";
            this.btnListGoals.Size = new System.Drawing.Size(192, 86);
            this.btnListGoals.TabIndex = 21;
            this.btnListGoals.Text = "Lista golova";
            this.btnListGoals.UseVisualStyleBackColor = true;
            this.btnListGoals.Click += new System.EventHandler(this.BtnListGoals_Click);
            // 
            // btnGameInfo
            // 
            this.btnGameInfo.Location = new System.Drawing.Point(902, 767);
            this.btnGameInfo.Name = "btnGameInfo";
            this.btnGameInfo.Size = new System.Drawing.Size(192, 86);
            this.btnGameInfo.TabIndex = 20;
            this.btnGameInfo.Text = "Informacije o utakmicama";
            this.btnGameInfo.UseVisualStyleBackColor = true;
            this.btnGameInfo.Click += new System.EventHandler(this.BtnGameInfo_Click);
            // 
            // btnYellowCards
            // 
            this.btnYellowCards.Location = new System.Drawing.Point(543, 767);
            this.btnYellowCards.Name = "btnYellowCards";
            this.btnYellowCards.Size = new System.Drawing.Size(192, 86);
            this.btnYellowCards.TabIndex = 19;
            this.btnYellowCards.Text = "Lista žutih kartona";
            this.btnYellowCards.UseVisualStyleBackColor = true;
            this.btnYellowCards.Click += new System.EventHandler(this.BtnYellowCards_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(875, 8);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(136, 56);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "Odaberi";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // lblFavouritePlayers
            // 
            this.lblFavouritePlayers.AutoSize = true;
            this.lblFavouritePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavouritePlayers.Location = new System.Drawing.Point(923, 107);
            this.lblFavouritePlayers.Name = "lblFavouritePlayers";
            this.lblFavouritePlayers.Size = new System.Drawing.Size(236, 38);
            this.lblFavouritePlayers.TabIndex = 17;
            this.lblFavouritePlayers.Text = "Omiljeni igrači";
            // 
            // flpFavouritePlayers
            // 
            this.flpFavouritePlayers.AllowDrop = true;
            this.flpFavouritePlayers.AutoScroll = true;
            this.flpFavouritePlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFavouritePlayers.Location = new System.Drawing.Point(759, 202);
            this.flpFavouritePlayers.Name = "flpFavouritePlayers";
            this.flpFavouritePlayers.Size = new System.Drawing.Size(667, 512);
            this.flpFavouritePlayers.TabIndex = 16;
            this.flpFavouritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpFavouritePlayers_DragDrop);
            this.flpFavouritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpFavouritePlayers_DragEnter);
            // 
            // flpTeam
            // 
            this.flpTeam.AllowDrop = true;
            this.flpTeam.AutoScroll = true;
            this.flpTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTeam.Location = new System.Drawing.Point(64, 202);
            this.flpTeam.Name = "flpTeam";
            this.flpTeam.Size = new System.Drawing.Size(671, 512);
            this.flpTeam.TabIndex = 15;
            this.flpTeam.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpTeam_DragDrop);
            this.flpTeam.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpTeam_DragEnter);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(255, 156);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(75, 20);
            this.lblCountry.TabIndex = 14;
            this.lblCountry.Text = "Drzava ";
            // 
            // ddlTeams
            // 
            this.ddlTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeams.FormattingEnabled = true;
            this.ddlTeams.Location = new System.Drawing.Point(526, 25);
            this.ddlTeams.Name = "ddlTeams";
            this.ddlTeams.Size = new System.Drawing.Size(305, 24);
            this.ddlTeams.TabIndex = 13;
            // 
            // lblChosenTeam
            // 
            this.lblChosenTeam.AutoSize = true;
            this.lblChosenTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosenTeam.Location = new System.Drawing.Point(135, 107);
            this.lblChosenTeam.Name = "lblChosenTeam";
            this.lblChosenTeam.Size = new System.Drawing.Size(409, 38);
            this.lblChosenTeam.TabIndex = 12;
            this.lblChosenTeam.Text = "Odabrana reprezentacija:";
            // 
            // lblChooseTeam
            // 
            this.lblChooseTeam.AutoSize = true;
            this.lblChooseTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseTeam.Location = new System.Drawing.Point(172, 18);
            this.lblChooseTeam.Name = "lblChooseTeam";
            this.lblChooseTeam.Size = new System.Drawing.Size(317, 29);
            this.lblChooseTeam.TabIndex = 11;
            this.lblChooseTeam.Text = "Odaberite reprezentaciju :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(366, 156);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 25);
            this.lblCode.TabIndex = 22;
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 860);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnListGoals);
            this.Controls.Add(this.btnGameInfo);
            this.Controls.Add(this.btnYellowCards);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblFavouritePlayers);
            this.Controls.Add(this.flpFavouritePlayers);
            this.Controls.Add(this.flpTeam);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.ddlTeams);
            this.Controls.Add(this.lblChosenTeam);
            this.Controls.Add(this.lblChooseTeam);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamForm_FormClosing);
            this.Load += new System.EventHandler(this.TeamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListGoals;
        private System.Windows.Forms.Button btnGameInfo;
        private System.Windows.Forms.Button btnYellowCards;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblFavouritePlayers;
        private System.Windows.Forms.FlowLayoutPanel flpFavouritePlayers;
        private System.Windows.Forms.FlowLayoutPanel flpTeam;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox ddlTeams;
        private System.Windows.Forms.Label lblChosenTeam;
        private System.Windows.Forms.Label lblChooseTeam;
        private System.Windows.Forms.Label lblCode;
    }
}