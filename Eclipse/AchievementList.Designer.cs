namespace Eclipse
{
    partial class AchievementList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.achievementName = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // achievementName
            // 
            this.achievementName.AutoSize = true;
            this.achievementName.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achievementName.Location = new System.Drawing.Point(138, 12);
            this.achievementName.Name = "achievementName";
            this.achievementName.Size = new System.Drawing.Size(162, 29);
            this.achievementName.TabIndex = 6;
            this.achievementName.Text = "Achievements";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(140, 41);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(264, 13);
            this.description.TabIndex = 7;
            this.description.Text = "Click an Achievement you\'ve unlocked to view details.";
            // 
            // AchievementList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 127);
            this.Controls.Add(this.description);
            this.Controls.Add(this.achievementName);
            this.Controls.Add(this.listBox1);
            this.Name = "AchievementList";
            this.Text = "Eclipse - Achievements";
            this.Load += new System.EventHandler(this.AchievementList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label achievementName;
        private System.Windows.Forms.Label description;
    }
}