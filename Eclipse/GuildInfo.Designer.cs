namespace Eclipse
{
    partial class GuildInfo
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
            this.clanName = new System.Windows.Forms.Label();
            this.population = new System.Windows.Forms.Label();
            this.populationBar = new System.Windows.Forms.ProgressBar();
            this.memberList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clanName
            // 
            this.clanName.AutoSize = true;
            this.clanName.Font = new System.Drawing.Font("Lato", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clanName.Location = new System.Drawing.Point(12, 9);
            this.clanName.Name = "clanName";
            this.clanName.Size = new System.Drawing.Size(149, 57);
            this.clanName.TabIndex = 2;
            this.clanName.Text = "Name";
            // 
            // population
            // 
            this.population.AutoSize = true;
            this.population.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.population.Location = new System.Drawing.Point(17, 66);
            this.population.Name = "population";
            this.population.Size = new System.Drawing.Size(137, 29);
            this.population.TabIndex = 5;
            this.population.Text = "Population: ";
            // 
            // populationBar
            // 
            this.populationBar.Location = new System.Drawing.Point(22, 98);
            this.populationBar.Name = "populationBar";
            this.populationBar.Size = new System.Drawing.Size(224, 21);
            this.populationBar.TabIndex = 7;
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(22, 125);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(132, 160);
            this.memberList.TabIndex = 8;
            // 
            // GuildInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 297);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.populationBar);
            this.Controls.Add(this.population);
            this.Controls.Add(this.clanName);
            this.Name = "GuildInfo";
            this.Text = "Eclipse - Gulid Info";
            this.Load += new System.EventHandler(this.GuildInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clanName;
        private System.Windows.Forms.Label population;
        private System.Windows.Forms.ProgressBar populationBar;
        private System.Windows.Forms.ListBox memberList;
    }
}