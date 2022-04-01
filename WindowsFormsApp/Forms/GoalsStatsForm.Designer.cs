namespace WindowsFormsApp.Forms
{
    partial class GoalsStatsForm
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
            this.flpGoals = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpGoals
            // 
            this.flpGoals.AutoScroll = true;
            this.flpGoals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGoals.Location = new System.Drawing.Point(0, 0);
            this.flpGoals.Name = "flpGoals";
            this.flpGoals.Size = new System.Drawing.Size(601, 543);
            this.flpGoals.TabIndex = 1;
            // 
            // GoalsStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 543);
            this.Controls.Add(this.flpGoals);
            this.Name = "GoalsStatsForm";
            this.Text = "GoalsStats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpGoals;
    }
}