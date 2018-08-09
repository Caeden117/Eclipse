namespace Eclipse
{
    partial class GameManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastSaved = new System.Windows.Forms.Label();
            this.lastLocation = new System.Windows.Forms.Label();
            this.removeUnavailable = new System.Windows.Forms.Button();
            this.removeAll = new System.Windows.Forms.Button();
            this.removeGame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 121);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeGame);
            this.groupBox1.Controls.Add(this.lastLocation);
            this.groupBox1.Controls.Add(this.lastSaved);
            this.groupBox1.Location = new System.Drawing.Point(179, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Information";
            // 
            // lastSaved
            // 
            this.lastSaved.AutoSize = true;
            this.lastSaved.Location = new System.Drawing.Point(6, 16);
            this.lastSaved.Name = "lastSaved";
            this.lastSaved.Size = new System.Drawing.Size(64, 13);
            this.lastSaved.TabIndex = 0;
            this.lastSaved.Text = "Last Saved:";
            // 
            // lastLocation
            // 
            this.lastLocation.AutoSize = true;
            this.lastLocation.Location = new System.Drawing.Point(6, 29);
            this.lastLocation.Name = "lastLocation";
            this.lastLocation.Size = new System.Drawing.Size(121, 13);
            this.lastLocation.TabIndex = 1;
            this.lastLocation.Text = "Last Save File Location:";
            // 
            // removeUnavailable
            // 
            this.removeUnavailable.Location = new System.Drawing.Point(179, 107);
            this.removeUnavailable.Name = "removeUnavailable";
            this.removeUnavailable.Size = new System.Drawing.Size(163, 23);
            this.removeUnavailable.TabIndex = 2;
            this.removeUnavailable.Text = "Removed Unavailable Games";
            this.removeUnavailable.UseVisualStyleBackColor = true;
            this.removeUnavailable.Click += new System.EventHandler(this.removeUnavailable_Click);
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(179, 78);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(127, 23);
            this.removeAll.TabIndex = 3;
            this.removeAll.Text = "Remove All Games";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // removeGame
            // 
            this.removeGame.Enabled = false;
            this.removeGame.Location = new System.Drawing.Point(215, 11);
            this.removeGame.Name = "removeGame";
            this.removeGame.Size = new System.Drawing.Size(62, 23);
            this.removeGame.TabIndex = 4;
            this.removeGame.Text = "Remove Game";
            this.removeGame.UseVisualStyleBackColor = true;
            this.removeGame.Click += new System.EventHandler(this.removeGame_Click);
            // 
            // GameManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 142);
            this.Controls.Add(this.removeAll);
            this.Controls.Add(this.removeUnavailable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GameManager";
            this.Text = "Eclipse - Manage Games";
            this.Load += new System.EventHandler(this.GameManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lastLocation;
        private System.Windows.Forms.Label lastSaved;
        private System.Windows.Forms.Button removeUnavailable;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.Button removeGame;
    }
}