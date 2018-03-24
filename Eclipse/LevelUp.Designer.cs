namespace Eclipse
{
    partial class LevelUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelUp));
            this.strength = new System.Windows.Forms.RadioButton();
            this.dexterity = new System.Windows.Forms.RadioButton();
            this.constitution = new System.Windows.Forms.RadioButton();
            this.charisma = new System.Windows.Forms.RadioButton();
            this.luck = new System.Windows.Forms.RadioButton();
            this.intelligence = new System.Windows.Forms.RadioButton();
            this.endurance = new System.Windows.Forms.RadioButton();
            this.agility = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // strength
            // 
            this.strength.AutoSize = true;
            this.strength.Location = new System.Drawing.Point(12, 230);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(65, 17);
            this.strength.TabIndex = 29;
            this.strength.TabStop = true;
            this.strength.Text = "Strength";
            this.strength.UseVisualStyleBackColor = true;
            this.strength.CheckedChanged += new System.EventHandler(this.strength_CheckedChanged);
            // 
            // dexterity
            // 
            this.dexterity.AutoSize = true;
            this.dexterity.Location = new System.Drawing.Point(12, 253);
            this.dexterity.Name = "dexterity";
            this.dexterity.Size = new System.Drawing.Size(66, 17);
            this.dexterity.TabIndex = 30;
            this.dexterity.TabStop = true;
            this.dexterity.Text = "Dexterity";
            this.dexterity.UseVisualStyleBackColor = true;
            this.dexterity.CheckedChanged += new System.EventHandler(this.dexterity_CheckedChanged);
            // 
            // constitution
            // 
            this.constitution.AutoSize = true;
            this.constitution.Location = new System.Drawing.Point(12, 276);
            this.constitution.Name = "constitution";
            this.constitution.Size = new System.Drawing.Size(80, 17);
            this.constitution.TabIndex = 31;
            this.constitution.TabStop = true;
            this.constitution.Text = "Constitution";
            this.constitution.UseVisualStyleBackColor = true;
            this.constitution.CheckedChanged += new System.EventHandler(this.constitution_CheckedChanged);
            // 
            // charisma
            // 
            this.charisma.AutoSize = true;
            this.charisma.Location = new System.Drawing.Point(12, 299);
            this.charisma.Name = "charisma";
            this.charisma.Size = new System.Drawing.Size(68, 17);
            this.charisma.TabIndex = 32;
            this.charisma.TabStop = true;
            this.charisma.Text = "Charisma";
            this.charisma.UseVisualStyleBackColor = true;
            this.charisma.CheckedChanged += new System.EventHandler(this.charisma_CheckedChanged);
            // 
            // luck
            // 
            this.luck.AutoSize = true;
            this.luck.Location = new System.Drawing.Point(92, 230);
            this.luck.Name = "luck";
            this.luck.Size = new System.Drawing.Size(49, 17);
            this.luck.TabIndex = 33;
            this.luck.TabStop = true;
            this.luck.Text = "Luck";
            this.luck.UseVisualStyleBackColor = true;
            this.luck.CheckedChanged += new System.EventHandler(this.luck_CheckedChanged);
            // 
            // intelligence
            // 
            this.intelligence.AutoSize = true;
            this.intelligence.Location = new System.Drawing.Point(92, 253);
            this.intelligence.Name = "intelligence";
            this.intelligence.Size = new System.Drawing.Size(79, 17);
            this.intelligence.TabIndex = 34;
            this.intelligence.TabStop = true;
            this.intelligence.Text = "Intelligence";
            this.intelligence.UseVisualStyleBackColor = true;
            this.intelligence.CheckedChanged += new System.EventHandler(this.intelligence_CheckedChanged);
            // 
            // endurance
            // 
            this.endurance.AutoSize = true;
            this.endurance.Location = new System.Drawing.Point(93, 276);
            this.endurance.Name = "endurance";
            this.endurance.Size = new System.Drawing.Size(77, 17);
            this.endurance.TabIndex = 35;
            this.endurance.TabStop = true;
            this.endurance.Text = "Endurance";
            this.endurance.UseVisualStyleBackColor = true;
            this.endurance.CheckedChanged += new System.EventHandler(this.endurance_CheckedChanged);
            // 
            // agility
            // 
            this.agility.AutoSize = true;
            this.agility.Location = new System.Drawing.Point(94, 299);
            this.agility.Name = "agility";
            this.agility.Size = new System.Drawing.Size(52, 17);
            this.agility.TabIndex = 36;
            this.agility.TabStop = true;
            this.agility.Text = "Agility";
            this.agility.UseVisualStyleBackColor = true;
            this.agility.CheckedChanged += new System.EventHandler(this.agility_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 219);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(175, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 81);
            this.button1.TabIndex = 38;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.agility);
            this.Controls.Add(this.endurance);
            this.Controls.Add(this.intelligence);
            this.Controls.Add(this.luck);
            this.Controls.Add(this.charisma);
            this.Controls.Add(this.constitution);
            this.Controls.Add(this.dexterity);
            this.Controls.Add(this.strength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LevelUp";
            this.Text = "Eclipse - Level Up!";
            this.Load += new System.EventHandler(this.LevelUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton strength;
        private System.Windows.Forms.RadioButton dexterity;
        private System.Windows.Forms.RadioButton constitution;
        private System.Windows.Forms.RadioButton charisma;
        private System.Windows.Forms.RadioButton luck;
        private System.Windows.Forms.RadioButton intelligence;
        private System.Windows.Forms.RadioButton endurance;
        private System.Windows.Forms.RadioButton agility;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}