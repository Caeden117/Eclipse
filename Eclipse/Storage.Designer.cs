namespace Eclipse
{
    partial class Storage
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
            this.existingStorage = new System.Windows.Forms.ListBox();
            this.storageItems = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.weightText = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // existingStorage
            // 
            this.existingStorage.FormattingEnabled = true;
            this.existingStorage.Location = new System.Drawing.Point(12, 12);
            this.existingStorage.Name = "existingStorage";
            this.existingStorage.Size = new System.Drawing.Size(120, 212);
            this.existingStorage.TabIndex = 0;
            this.existingStorage.SelectedIndexChanged += new System.EventHandler(this.existingStorage_SelectedIndexChanged);
            // 
            // storageItems
            // 
            this.storageItems.FormattingEnabled = true;
            this.storageItems.Location = new System.Drawing.Point(338, 14);
            this.storageItems.Name = "storageItems";
            this.storageItems.Size = new System.Drawing.Size(120, 212);
            this.storageItems.TabIndex = 1;
            this.storageItems.SelectedIndexChanged += new System.EventHandler(this.storageItems_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(138, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Properties";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Discard Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Move Item...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weightText
            // 
            this.weightText.AutoSize = true;
            this.weightText.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightText.Location = new System.Drawing.Point(138, 12);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(96, 29);
            this.weightText.TabIndex = 7;
            this.weightText.Text = "Weight:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(143, 44);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 235);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.storageItems);
            this.Controls.Add(this.existingStorage);
            this.Name = "Storage";
            this.Text = "Eclipse - Storage";
            this.Load += new System.EventHandler(this.Storage_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox existingStorage;
        private System.Windows.Forms.ListBox storageItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label weightText;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}