namespace WindowsFormsApp.Forms
{
    partial class YellowCardsStatsForm
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
            this.flpYellowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpYellowCards
            // 
            this.flpYellowCards.AutoScroll = true;
            this.flpYellowCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpYellowCards.Location = new System.Drawing.Point(0, 0);
            this.flpYellowCards.Name = "flpYellowCards";
            this.flpYellowCards.Size = new System.Drawing.Size(586, 521);
            this.flpYellowCards.TabIndex = 1;
            // 
            // YellowCardsStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 521);
            this.Controls.Add(this.flpYellowCards);
            this.Name = "YellowCardsStatsForm";
            this.Text = "YellowCardsStats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpYellowCards;
    }
}