namespace WindowsFormsApp.Controls
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCapitan = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnSetPicture = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.pbFavourite = new System.Windows.Forms.PictureBox();
            this.lblGoalsPlaceholder = new System.Windows.Forms.Label();
            this.lblCapitanPlaceholder = new System.Windows.Forms.Label();
            this.lblPositionPlaceholder = new System.Windows.Forms.Label();
            this.lblNumberPlaceholder = new System.Windows.Forms.Label();
            this.lblNamePlaceholder = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGoals = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCapitan
            // 
            this.lblCapitan.AutoSize = true;
            this.lblCapitan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitan.Location = new System.Drawing.Point(15, 260);
            this.lblCapitan.Name = "lblCapitan";
            this.lblCapitan.Size = new System.Drawing.Size(73, 17);
            this.lblCapitan.TabIndex = 28;
            this.lblCapitan.Text = "Kapetan:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(15, 186);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(69, 17);
            this.lblPosition.TabIndex = 27;
            this.lblPosition.Text = "Pozicija:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(15, 107);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(42, 17);
            this.lblNumber.TabIndex = 26;
            this.lblNumber.Text = "Broj:";
            // 
            // btnSetPicture
            // 
            this.btnSetPicture.Location = new System.Drawing.Point(415, 406);
            this.btnSetPicture.Name = "btnSetPicture";
            this.btnSetPicture.Size = new System.Drawing.Size(185, 58);
            this.btnSetPicture.TabIndex = 25;
            this.btnSetPicture.Text = "Postavi sliku";
            this.btnSetPicture.UseVisualStyleBackColor = true;
            this.btnSetPicture.Click += new System.EventHandler(this.BtnSetPicture_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(415, 182);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(185, 218);
            this.pbPicture.TabIndex = 24;
            this.pbPicture.TabStop = false;
            // 
            // pbFavourite
            // 
            this.pbFavourite.Location = new System.Drawing.Point(415, 11);
            this.pbFavourite.Name = "pbFavourite";
            this.pbFavourite.Size = new System.Drawing.Size(185, 165);
            this.pbFavourite.TabIndex = 23;
            this.pbFavourite.TabStop = false;
            // 
            // lblGoalsPlaceholder
            // 
            this.lblGoalsPlaceholder.AutoSize = true;
            this.lblGoalsPlaceholder.Location = new System.Drawing.Point(160, 339);
            this.lblGoalsPlaceholder.Name = "lblGoalsPlaceholder";
            this.lblGoalsPlaceholder.Size = new System.Drawing.Size(0, 21);
            this.lblGoalsPlaceholder.TabIndex = 22;
            // 
            // lblCapitanPlaceholder
            // 
            this.lblCapitanPlaceholder.AutoSize = true;
            this.lblCapitanPlaceholder.Location = new System.Drawing.Point(160, 260);
            this.lblCapitanPlaceholder.Name = "lblCapitanPlaceholder";
            this.lblCapitanPlaceholder.Size = new System.Drawing.Size(46, 17);
            this.lblCapitanPlaceholder.TabIndex = 21;
            this.lblCapitanPlaceholder.Text = "label7";
            // 
            // lblPositionPlaceholder
            // 
            this.lblPositionPlaceholder.AutoSize = true;
            this.lblPositionPlaceholder.Location = new System.Drawing.Point(160, 186);
            this.lblPositionPlaceholder.Name = "lblPositionPlaceholder";
            this.lblPositionPlaceholder.Size = new System.Drawing.Size(46, 17);
            this.lblPositionPlaceholder.TabIndex = 20;
            this.lblPositionPlaceholder.Text = "label5";
            // 
            // lblNumberPlaceholder
            // 
            this.lblNumberPlaceholder.AutoSize = true;
            this.lblNumberPlaceholder.Location = new System.Drawing.Point(160, 107);
            this.lblNumberPlaceholder.Name = "lblNumberPlaceholder";
            this.lblNumberPlaceholder.Size = new System.Drawing.Size(46, 17);
            this.lblNumberPlaceholder.TabIndex = 19;
            this.lblNumberPlaceholder.Text = "label3";
            // 
            // lblNamePlaceholder
            // 
            this.lblNamePlaceholder.AutoSize = true;
            this.lblNamePlaceholder.Location = new System.Drawing.Point(160, 33);
            this.lblNamePlaceholder.Name = "lblNamePlaceholder";
            this.lblNamePlaceholder.Size = new System.Drawing.Size(46, 17);
            this.lblNamePlaceholder.TabIndex = 18;
            this.lblNamePlaceholder.Text = "label2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 17);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Ime:";
            // 
            // lblGoals
            // 
            this.lblGoals.AutoSize = true;
            this.lblGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoals.Location = new System.Drawing.Point(15, 339);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(59, 17);
            this.lblGoals.TabIndex = 29;
            this.lblGoals.Text = "Golovi:";
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGoals);
            this.Controls.Add(this.lblCapitan);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnSetPicture);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.pbFavourite);
            this.Controls.Add(this.lblGoalsPlaceholder);
            this.Controls.Add(this.lblCapitanPlaceholder);
            this.Controls.Add(this.lblPositionPlaceholder);
            this.Controls.Add(this.lblNumberPlaceholder);
            this.Controls.Add(this.lblNamePlaceholder);
            this.Controls.Add(this.lblName);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(648, 493);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCapitan;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnSetPicture;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.PictureBox pbFavourite;
        private System.Windows.Forms.Label lblGoalsPlaceholder;
        private System.Windows.Forms.Label lblCapitanPlaceholder;
        private System.Windows.Forms.Label lblPositionPlaceholder;
        private System.Windows.Forms.Label lblNumberPlaceholder;
        private System.Windows.Forms.Label lblNamePlaceholder;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGoals;
    }
}
