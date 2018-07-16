namespace Eclipse
{
    partial class MoveItem
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
            this.Storage = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.movingItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Storage
            // 
            this.Storage.FormattingEnabled = true;
            this.Storage.Location = new System.Drawing.Point(12, 12);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(120, 134);
            this.Storage.TabIndex = 0;
            this.Storage.SelectedIndexChanged += new System.EventHandler(this.Storage_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Move Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Moving:";
            // 
            // movingItem
            // 
            this.movingItem.AutoSize = true;
            this.movingItem.Location = new System.Drawing.Point(138, 25);
            this.movingItem.Name = "movingItem";
            this.movingItem.Size = new System.Drawing.Size(27, 13);
            this.movingItem.TabIndex = 4;
            this.movingItem.Text = "Item";
            // 
            // MoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 155);
            this.Controls.Add(this.movingItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Storage);
            this.Name = "MoveItem";
            this.Text = "Eclipse - Move Item To Storage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoveItem_FormClosing);
            this.Load += new System.EventHandler(this.MoveItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Storage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label movingItem;
    }
}