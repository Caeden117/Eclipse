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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Constitution = new System.Windows.Forms.Label();
            this.Agility = new System.Windows.Forms.Label();
            this.Dexterity = new System.Windows.Forms.Label();
            this.Strength = new System.Windows.Forms.Label();
            this.memberHealth = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.feedMember = new System.Windows.Forms.Button();
            this.kickMember = new System.Windows.Forms.Button();
            this.Disposition = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.population.Location = new System.Drawing.Point(12, 66);
            this.population.Name = "population";
            this.population.Size = new System.Drawing.Size(137, 29);
            this.population.TabIndex = 5;
            this.population.Text = "Population: ";
            // 
            // populationBar
            // 
            this.populationBar.Location = new System.Drawing.Point(17, 98);
            this.populationBar.Name = "populationBar";
            this.populationBar.Size = new System.Drawing.Size(224, 21);
            this.populationBar.TabIndex = 7;
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(17, 125);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(132, 212);
            this.memberList.TabIndex = 8;
            this.memberList.SelectedIndexChanged += new System.EventHandler(this.memberList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Level);
            this.groupBox1.Controls.Add(this.Disposition);
            this.groupBox1.Controls.Add(this.Constitution);
            this.groupBox1.Controls.Add(this.Agility);
            this.groupBox1.Controls.Add(this.Dexterity);
            this.groupBox1.Controls.Add(this.Strength);
            this.groupBox1.Controls.Add(this.memberHealth);
            this.groupBox1.Location = new System.Drawing.Point(247, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 269);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information";
            // 
            // Constitution
            // 
            this.Constitution.AutoSize = true;
            this.Constitution.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Constitution.Location = new System.Drawing.Point(6, 182);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(154, 29);
            this.Constitution.TabIndex = 14;
            this.Constitution.Text = "Constitution: ";
            // 
            // Agility
            // 
            this.Agility.AutoSize = true;
            this.Agility.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agility.Location = new System.Drawing.Point(6, 153);
            this.Agility.Name = "Agility";
            this.Agility.Size = new System.Drawing.Size(86, 29);
            this.Agility.TabIndex = 13;
            this.Agility.Text = "Agility:";
            // 
            // Dexterity
            // 
            this.Dexterity.AutoSize = true;
            this.Dexterity.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dexterity.Location = new System.Drawing.Point(6, 124);
            this.Dexterity.Name = "Dexterity";
            this.Dexterity.Size = new System.Drawing.Size(125, 29);
            this.Dexterity.TabIndex = 12;
            this.Dexterity.Text = "Dexterity: ";
            // 
            // Strength
            // 
            this.Strength.AutoSize = true;
            this.Strength.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strength.Location = new System.Drawing.Point(6, 95);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(116, 29);
            this.Strength.TabIndex = 11;
            this.Strength.Text = "Strength: ";
            // 
            // memberHealth
            // 
            this.memberHealth.AutoSize = true;
            this.memberHealth.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberHealth.Location = new System.Drawing.Point(6, 66);
            this.memberHealth.Name = "memberHealth";
            this.memberHealth.Size = new System.Drawing.Size(95, 29);
            this.memberHealth.TabIndex = 10;
            this.memberHealth.Text = "Health: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.feedMember);
            this.groupBox2.Controls.Add(this.kickMember);
            this.groupBox2.Location = new System.Drawing.Point(247, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 53);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Member Actions";
            // 
            // feedMember
            // 
            this.feedMember.Location = new System.Drawing.Point(6, 19);
            this.feedMember.Name = "feedMember";
            this.feedMember.Size = new System.Drawing.Size(75, 23);
            this.feedMember.TabIndex = 1;
            this.feedMember.Text = "Feed";
            this.feedMember.UseVisualStyleBackColor = true;
            // 
            // kickMember
            // 
            this.kickMember.Location = new System.Drawing.Point(222, 19);
            this.kickMember.Name = "kickMember";
            this.kickMember.Size = new System.Drawing.Size(75, 23);
            this.kickMember.TabIndex = 0;
            this.kickMember.Text = "Kick";
            this.kickMember.UseVisualStyleBackColor = true;
            // 
            // Disposition
            // 
            this.Disposition.AutoSize = true;
            this.Disposition.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disposition.Location = new System.Drawing.Point(6, 228);
            this.Disposition.Name = "Disposition";
            this.Disposition.Size = new System.Drawing.Size(136, 29);
            this.Disposition.TabIndex = 15;
            this.Disposition.Text = "Disposition:";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.Location = new System.Drawing.Point(6, 16);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(75, 29);
            this.Level.TabIndex = 16;
            this.Level.Text = "Level:";
            // 
            // GuildInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 352);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.populationBar);
            this.Controls.Add(this.population);
            this.Controls.Add(this.clanName);
            this.Name = "GuildInfo";
            this.Text = "Eclipse - Gulid Info";
            this.Load += new System.EventHandler(this.GuildInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clanName;
        private System.Windows.Forms.Label population;
        private System.Windows.Forms.ProgressBar populationBar;
        private System.Windows.Forms.ListBox memberList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.Label Agility;
        private System.Windows.Forms.Label Dexterity;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.Label memberHealth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button feedMember;
        private System.Windows.Forms.Button kickMember;
        private System.Windows.Forms.Label Disposition;
        private System.Windows.Forms.Label Level;
    }
}