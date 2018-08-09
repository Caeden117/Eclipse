namespace Eclipse
{
    partial class EclipseGuide
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
            this.toggleButton = new System.Windows.Forms.Button();
            this.itemProperties = new System.Windows.Forms.GroupBox();
            this.goToCrafting = new System.Windows.Forms.Button();
            this.itemIntelligence = new System.Windows.Forms.Label();
            this.itemUsability = new System.Windows.Forms.Label();
            this.itemDescription = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.Label();
            this.craftingProperties = new System.Windows.Forms.GroupBox();
            this.goToItem = new System.Windows.Forms.Button();
            this.goToComponent = new System.Windows.Forms.Button();
            this.craftComponents = new System.Windows.Forms.ListBox();
            this.craftIntelligence = new System.Windows.Forms.Label();
            this.craftDetails = new System.Windows.Forms.Label();
            this.craftResult = new System.Windows.Forms.Label();
            this.sizes = new System.Windows.Forms.Label();
            this.itemProperties.SuspendLayout();
            this.craftingProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // toggleButton
            // 
            this.toggleButton.Location = new System.Drawing.Point(138, 12);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(75, 23);
            this.toggleButton.TabIndex = 1;
            this.toggleButton.Text = "Crafting";
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // itemProperties
            // 
            this.itemProperties.Controls.Add(this.goToCrafting);
            this.itemProperties.Controls.Add(this.itemIntelligence);
            this.itemProperties.Controls.Add(this.itemUsability);
            this.itemProperties.Controls.Add(this.itemDescription);
            this.itemProperties.Controls.Add(this.itemName);
            this.itemProperties.Location = new System.Drawing.Point(138, 41);
            this.itemProperties.Name = "itemProperties";
            this.itemProperties.Size = new System.Drawing.Size(276, 222);
            this.itemProperties.TabIndex = 2;
            this.itemProperties.TabStop = false;
            this.itemProperties.Text = "Item Properties";
            // 
            // goToCrafting
            // 
            this.goToCrafting.Location = new System.Drawing.Point(183, 180);
            this.goToCrafting.Name = "goToCrafting";
            this.goToCrafting.Size = new System.Drawing.Size(87, 23);
            this.goToCrafting.TabIndex = 32;
            this.goToCrafting.Text = "Go To Crafting";
            this.goToCrafting.UseVisualStyleBackColor = true;
            this.goToCrafting.Visible = false;
            this.goToCrafting.Click += new System.EventHandler(this.goToCrafting_Click);
            // 
            // itemIntelligence
            // 
            this.itemIntelligence.AutoSize = true;
            this.itemIntelligence.Location = new System.Drawing.Point(8, 206);
            this.itemIntelligence.Name = "itemIntelligence";
            this.itemIntelligence.Size = new System.Drawing.Size(250, 13);
            this.itemIntelligence.TabIndex = 31;
            this.itemIntelligence.Text = "Intelligence requirement to use items will show here.";
            // 
            // itemUsability
            // 
            this.itemUsability.AutoSize = true;
            this.itemUsability.Location = new System.Drawing.Point(8, 92);
            this.itemUsability.Name = "itemUsability";
            this.itemUsability.Size = new System.Drawing.Size(172, 13);
            this.itemUsability.TabIndex = 30;
            this.itemUsability.Text = "Specific item details will show here.";
            // 
            // itemDescription
            // 
            this.itemDescription.BackColor = System.Drawing.SystemColors.Control;
            this.itemDescription.Location = new System.Drawing.Point(11, 48);
            this.itemDescription.Multiline = true;
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.ReadOnly = true;
            this.itemDescription.Size = new System.Drawing.Size(259, 41);
            this.itemDescription.TabIndex = 29;
            this.itemDescription.Text = "The item\'s description will appear in here.";
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(6, 16);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(162, 29);
            this.itemName.TabIndex = 28;
            this.itemName.Text = "Select an Item";
            // 
            // craftingProperties
            // 
            this.craftingProperties.Controls.Add(this.goToItem);
            this.craftingProperties.Controls.Add(this.goToComponent);
            this.craftingProperties.Controls.Add(this.craftComponents);
            this.craftingProperties.Controls.Add(this.craftIntelligence);
            this.craftingProperties.Controls.Add(this.craftDetails);
            this.craftingProperties.Controls.Add(this.craftResult);
            this.craftingProperties.Location = new System.Drawing.Point(487, 41);
            this.craftingProperties.Name = "craftingProperties";
            this.craftingProperties.Size = new System.Drawing.Size(276, 222);
            this.craftingProperties.TabIndex = 32;
            this.craftingProperties.TabStop = false;
            this.craftingProperties.Text = "Crafting Properties";
            // 
            // goToItem
            // 
            this.goToItem.Location = new System.Drawing.Point(183, 149);
            this.goToItem.Name = "goToItem";
            this.goToItem.Size = new System.Drawing.Size(87, 23);
            this.goToItem.TabIndex = 33;
            this.goToItem.Text = "Go To Item";
            this.goToItem.UseVisualStyleBackColor = true;
            this.goToItem.Visible = false;
            this.goToItem.Click += new System.EventHandler(this.goToItem_Click);
            // 
            // goToComponent
            // 
            this.goToComponent.Location = new System.Drawing.Point(11, 149);
            this.goToComponent.Name = "goToComponent";
            this.goToComponent.Size = new System.Drawing.Size(95, 23);
            this.goToComponent.TabIndex = 33;
            this.goToComponent.Text = "Component Info";
            this.goToComponent.UseVisualStyleBackColor = true;
            this.goToComponent.Click += new System.EventHandler(this.goToComponent_Click);
            // 
            // craftComponents
            // 
            this.craftComponents.FormattingEnabled = true;
            this.craftComponents.Items.AddRange(new object[] {
            "Crafting components will show up here."});
            this.craftComponents.Location = new System.Drawing.Point(11, 48);
            this.craftComponents.Name = "craftComponents";
            this.craftComponents.Size = new System.Drawing.Size(259, 95);
            this.craftComponents.TabIndex = 32;
            this.craftComponents.SelectedIndexChanged += new System.EventHandler(this.craftComponents_SelectedIndexChanged);
            // 
            // craftIntelligence
            // 
            this.craftIntelligence.AutoSize = true;
            this.craftIntelligence.Location = new System.Drawing.Point(8, 206);
            this.craftIntelligence.Name = "craftIntelligence";
            this.craftIntelligence.Size = new System.Drawing.Size(227, 13);
            this.craftIntelligence.TabIndex = 31;
            this.craftIntelligence.Text = "Intelligence requirement to craft will show here.";
            // 
            // craftDetails
            // 
            this.craftDetails.AutoSize = true;
            this.craftDetails.Location = new System.Drawing.Point(8, 175);
            this.craftDetails.Name = "craftDetails";
            this.craftDetails.Size = new System.Drawing.Size(134, 13);
            this.craftDetails.TabIndex = 30;
            this.craftDetails.Text = "Craft details will show here.";
            // 
            // craftResult
            // 
            this.craftResult.AutoSize = true;
            this.craftResult.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craftResult.Location = new System.Drawing.Point(6, 16);
            this.craftResult.Name = "craftResult";
            this.craftResult.Size = new System.Drawing.Size(171, 29);
            this.craftResult.TabIndex = 28;
            this.craftResult.Text = "Select a Recipe";
            // 
            // sizes
            // 
            this.sizes.AutoSize = true;
            this.sizes.Location = new System.Drawing.Point(12, 12);
            this.sizes.Name = "sizes";
            this.sizes.Size = new System.Drawing.Size(38, 13);
            this.sizes.TabIndex = 33;
            this.sizes.Text = "Items: ";
            // 
            // EclipseGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 269);
            this.Controls.Add(this.sizes);
            this.Controls.Add(this.craftingProperties);
            this.Controls.Add(this.itemProperties);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EclipseGuide";
            this.Text = "Eclipse - Items/Crafting Guide";
            this.Load += new System.EventHandler(this.EclipseGuide_Load);
            this.itemProperties.ResumeLayout(false);
            this.itemProperties.PerformLayout();
            this.craftingProperties.ResumeLayout(false);
            this.craftingProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.GroupBox itemProperties;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label itemIntelligence;
        private System.Windows.Forms.Label itemUsability;
        private System.Windows.Forms.TextBox itemDescription;
        private System.Windows.Forms.GroupBox craftingProperties;
        private System.Windows.Forms.Label craftIntelligence;
        private System.Windows.Forms.Label craftDetails;
        private System.Windows.Forms.Label craftResult;
        private System.Windows.Forms.ListBox craftComponents;
        private System.Windows.Forms.Button goToComponent;
        private System.Windows.Forms.Button goToCrafting;
        private System.Windows.Forms.Label sizes;
        private System.Windows.Forms.Button goToItem;
    }
}