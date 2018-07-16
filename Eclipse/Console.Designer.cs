namespace Eclipse
{
    partial class Console
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
            this.components = new System.ComponentModel.Container();
            this.name = new System.Windows.Forms.Label();
            this.clan = new System.Windows.Forms.Label();
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.health = new System.Windows.Forms.Label();
            this.xp = new System.Windows.Forms.Label();
            this.xpbar = new System.Windows.Forms.ProgressBar();
            this.strength = new System.Windows.Forms.Label();
            this.dexterity = new System.Windows.Forms.Label();
            this.constitution = new System.Windows.Forms.Label();
            this.charisma = new System.Windows.Forms.Label();
            this.luck = new System.Windows.Forms.Label();
            this.intelligence = new System.Windows.Forms.Label();
            this.oneTick = new System.Windows.Forms.Timer(this.components);
            this.endurance = new System.Windows.Forms.Label();
            this.agility = new System.Windows.Forms.Label();
            this.hunger = new System.Windows.Forms.Label();
            this.hungerbar = new System.Windows.Forms.ProgressBar();
            this.healthsmall = new System.Windows.Forms.ProgressBar();
            this.healthoverflow = new System.Windows.Forms.ProgressBar();
            this.infectionbar = new System.Windows.Forms.ProgressBar();
            this.infection = new System.Windows.Forms.Label();
            this.healthDegen = new System.Windows.Forms.Timer(this.components);
            this.infectionDecay = new System.Windows.Forms.Timer(this.components);
            this.inventory = new System.Windows.Forms.ListBox();
            this.itemName = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.itemDescription = new System.Windows.Forms.TextBox();
            this.use = new System.Windows.Forms.Button();
            this.throwItem = new System.Windows.Forms.Button();
            this.weapon = new System.Windows.Forms.Label();
            this.mainConsole = new System.Windows.Forms.RichTextBox();
            this.hunt = new System.Windows.Forms.Button();
            this.huntLoop = new System.Windows.Forms.Timer(this.components);
            this.craft = new System.Windows.Forms.ListBox();
            this.craftLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.requires = new System.Windows.Forms.Label();
            this.itemRequires = new System.Windows.Forms.ListBox();
            this.craftItem = new System.Windows.Forms.Button();
            this.scavange = new System.Windows.Forms.Button();
            this.scavangeLoop = new System.Windows.Forms.Timer(this.components);
            this.rest = new System.Windows.Forms.Button();
            this.restLoop = new System.Windows.Forms.Timer(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.notStableTick = new System.Windows.Forms.Timer(this.components);
            this.guildHub = new System.Windows.Forms.Button();
            this.achievements = new System.Windows.Forms.Button();
            this.storage = new System.Windows.Forms.Button();
            this.moveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Lato", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(3, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(149, 57);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // clan
            // 
            this.clan.AutoSize = true;
            this.clan.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clan.Location = new System.Drawing.Point(8, 66);
            this.clan.Name = "clan";
            this.clan.Size = new System.Drawing.Size(60, 29);
            this.clan.TabIndex = 2;
            this.clan.Text = "Clan";
            // 
            // healthbar
            // 
            this.healthbar.Location = new System.Drawing.Point(13, 127);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(224, 21);
            this.healthbar.TabIndex = 3;
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health.Location = new System.Drawing.Point(8, 95);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(57, 29);
            this.health.TabIndex = 4;
            this.health.Text = "HP: ";
            // 
            // xp
            // 
            this.xp.AutoSize = true;
            this.xp.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xp.Location = new System.Drawing.Point(8, 151);
            this.xp.Name = "xp";
            this.xp.Size = new System.Drawing.Size(80, 29);
            this.xp.TabIndex = 5;
            this.xp.Text = "Level: ";
            // 
            // xpbar
            // 
            this.xpbar.Location = new System.Drawing.Point(13, 183);
            this.xpbar.Name = "xpbar";
            this.xpbar.Size = new System.Drawing.Size(224, 21);
            this.xpbar.TabIndex = 6;
            // 
            // strength
            // 
            this.strength.AutoSize = true;
            this.strength.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strength.Location = new System.Drawing.Point(8, 325);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(116, 29);
            this.strength.TabIndex = 7;
            this.strength.Text = "Strength: ";
            this.strength.Click += new System.EventHandler(this.strength_Click);
            // 
            // dexterity
            // 
            this.dexterity.AutoSize = true;
            this.dexterity.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexterity.Location = new System.Drawing.Point(8, 354);
            this.dexterity.Name = "dexterity";
            this.dexterity.Size = new System.Drawing.Size(125, 29);
            this.dexterity.TabIndex = 8;
            this.dexterity.Text = "Dexterity: ";
            this.dexterity.Click += new System.EventHandler(this.dexterity_Click);
            // 
            // constitution
            // 
            this.constitution.AutoSize = true;
            this.constitution.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constitution.Location = new System.Drawing.Point(8, 383);
            this.constitution.Name = "constitution";
            this.constitution.Size = new System.Drawing.Size(154, 29);
            this.constitution.TabIndex = 9;
            this.constitution.Text = "Constitution: ";
            this.constitution.Click += new System.EventHandler(this.constitution_Click);
            // 
            // charisma
            // 
            this.charisma.AutoSize = true;
            this.charisma.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charisma.Location = new System.Drawing.Point(8, 412);
            this.charisma.Name = "charisma";
            this.charisma.Size = new System.Drawing.Size(123, 29);
            this.charisma.TabIndex = 10;
            this.charisma.Text = "Charisma: ";
            this.charisma.Click += new System.EventHandler(this.charisma_Click);
            // 
            // luck
            // 
            this.luck.AutoSize = true;
            this.luck.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luck.Location = new System.Drawing.Point(8, 441);
            this.luck.Name = "luck";
            this.luck.Size = new System.Drawing.Size(73, 29);
            this.luck.TabIndex = 11;
            this.luck.Text = "Luck: ";
            this.luck.Click += new System.EventHandler(this.luck_Click);
            // 
            // intelligence
            // 
            this.intelligence.AutoSize = true;
            this.intelligence.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intelligence.Location = new System.Drawing.Point(8, 470);
            this.intelligence.Name = "intelligence";
            this.intelligence.Size = new System.Drawing.Size(146, 29);
            this.intelligence.TabIndex = 12;
            this.intelligence.Text = "Intelligence: ";
            this.intelligence.Click += new System.EventHandler(this.intelligence_Click);
            // 
            // oneTick
            // 
            this.oneTick.Enabled = true;
            this.oneTick.Interval = 1;
            this.oneTick.Tick += new System.EventHandler(this.oneTick_Tick);
            // 
            // endurance
            // 
            this.endurance.AutoSize = true;
            this.endurance.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endurance.Location = new System.Drawing.Point(8, 499);
            this.endurance.Name = "endurance";
            this.endurance.Size = new System.Drawing.Size(136, 29);
            this.endurance.TabIndex = 13;
            this.endurance.Text = "Endurance: ";
            this.endurance.Click += new System.EventHandler(this.endurance_Click);
            // 
            // agility
            // 
            this.agility.AutoSize = true;
            this.agility.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agility.Location = new System.Drawing.Point(8, 528);
            this.agility.Name = "agility";
            this.agility.Size = new System.Drawing.Size(91, 29);
            this.agility.TabIndex = 14;
            this.agility.Text = "Agility: ";
            this.agility.Click += new System.EventHandler(this.agility_Click);
            // 
            // hunger
            // 
            this.hunger.AutoSize = true;
            this.hunger.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hunger.Location = new System.Drawing.Point(8, 207);
            this.hunger.Name = "hunger";
            this.hunger.Size = new System.Drawing.Size(103, 29);
            this.hunger.TabIndex = 15;
            this.hunger.Text = "Hunger: ";
            // 
            // hungerbar
            // 
            this.hungerbar.Location = new System.Drawing.Point(13, 243);
            this.hungerbar.Name = "hungerbar";
            this.hungerbar.Size = new System.Drawing.Size(224, 21);
            this.hungerbar.TabIndex = 16;
            // 
            // healthsmall
            // 
            this.healthsmall.Location = new System.Drawing.Point(13, 127);
            this.healthsmall.Name = "healthsmall";
            this.healthsmall.Size = new System.Drawing.Size(224, 10);
            this.healthsmall.TabIndex = 17;
            this.healthsmall.Visible = false;
            // 
            // healthoverflow
            // 
            this.healthoverflow.Location = new System.Drawing.Point(13, 138);
            this.healthoverflow.Name = "healthoverflow";
            this.healthoverflow.Size = new System.Drawing.Size(224, 10);
            this.healthoverflow.TabIndex = 18;
            this.healthoverflow.Visible = false;
            // 
            // infectionbar
            // 
            this.infectionbar.Location = new System.Drawing.Point(13, 301);
            this.infectionbar.Name = "infectionbar";
            this.infectionbar.Size = new System.Drawing.Size(224, 21);
            this.infectionbar.TabIndex = 20;
            // 
            // infection
            // 
            this.infection.AutoSize = true;
            this.infection.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infection.Location = new System.Drawing.Point(8, 267);
            this.infection.Name = "infection";
            this.infection.Size = new System.Drawing.Size(106, 29);
            this.infection.TabIndex = 19;
            this.infection.Text = "Infection";
            // 
            // healthDegen
            // 
            this.healthDegen.Enabled = true;
            this.healthDegen.Interval = 10000;
            this.healthDegen.Tick += new System.EventHandler(this.healthDegen_Tick);
            // 
            // infectionDecay
            // 
            this.infectionDecay.Enabled = true;
            this.infectionDecay.Interval = 5000;
            this.infectionDecay.Tick += new System.EventHandler(this.infectionDecay_Tick);
            // 
            // inventory
            // 
            this.inventory.FormattingEnabled = true;
            this.inventory.Location = new System.Drawing.Point(761, 37);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(188, 368);
            this.inventory.TabIndex = 21;
            this.inventory.SelectedIndexChanged += new System.EventHandler(this.inventory_SelectedIndexChanges);
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.BackColor = System.Drawing.Color.Transparent;
            this.itemName.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(754, 438);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(195, 29);
            this.itemName.TabIndex = 22;
            this.itemName.Text = "No item selected.";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(754, 409);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(101, 29);
            this.weight.TabIndex = 23;
            this.weight.Text = "Weight: ";
            // 
            // itemDescription
            // 
            this.itemDescription.BackColor = System.Drawing.SystemColors.Control;
            this.itemDescription.Location = new System.Drawing.Point(759, 470);
            this.itemDescription.Multiline = true;
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.ReadOnly = true;
            this.itemDescription.Size = new System.Drawing.Size(190, 41);
            this.itemDescription.TabIndex = 24;
            // 
            // use
            // 
            this.use.Enabled = false;
            this.use.Location = new System.Drawing.Point(759, 517);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(83, 39);
            this.use.TabIndex = 25;
            this.use.Text = "Use";
            this.use.UseVisualStyleBackColor = true;
            this.use.Click += new System.EventHandler(this.use_Click);
            // 
            // throwItem
            // 
            this.throwItem.Enabled = false;
            this.throwItem.Location = new System.Drawing.Point(896, 517);
            this.throwItem.Name = "throwItem";
            this.throwItem.Size = new System.Drawing.Size(53, 39);
            this.throwItem.TabIndex = 26;
            this.throwItem.Text = "Discard";
            this.throwItem.UseVisualStyleBackColor = true;
            this.throwItem.Click += new System.EventHandler(this.throwItem_Click);
            // 
            // weapon
            // 
            this.weapon.AutoSize = true;
            this.weapon.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon.Location = new System.Drawing.Point(238, 6);
            this.weapon.Name = "weapon";
            this.weapon.Size = new System.Drawing.Size(112, 29);
            this.weapon.TabIndex = 27;
            this.weapon.Text = "Weapon: ";
            // 
            // mainConsole
            // 
            this.mainConsole.Location = new System.Drawing.Point(243, 38);
            this.mainConsole.Name = "mainConsole";
            this.mainConsole.ReadOnly = true;
            this.mainConsole.Size = new System.Drawing.Size(510, 367);
            this.mainConsole.TabIndex = 28;
            this.mainConsole.Text = "";
            // 
            // hunt
            // 
            this.hunt.Location = new System.Drawing.Point(243, 409);
            this.hunt.Name = "hunt";
            this.hunt.Size = new System.Drawing.Size(88, 25);
            this.hunt.TabIndex = 29;
            this.hunt.Text = "🗡 Hunt";
            this.hunt.UseVisualStyleBackColor = true;
            this.hunt.Click += new System.EventHandler(this.hunt_Click);
            // 
            // huntLoop
            // 
            this.huntLoop.Interval = 1000;
            this.huntLoop.Tick += new System.EventHandler(this.huntLoop_Tick);
            // 
            // craft
            // 
            this.craft.FormattingEnabled = true;
            this.craft.Location = new System.Drawing.Point(980, 38);
            this.craft.Name = "craft";
            this.craft.Size = new System.Drawing.Size(188, 368);
            this.craft.TabIndex = 30;
            this.craft.SelectedIndexChanged += new System.EventHandler(this.craft_SelectedIndexChanged);
            // 
            // craftLabel
            // 
            this.craftLabel.AutoSize = true;
            this.craftLabel.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craftLabel.Location = new System.Drawing.Point(975, 6);
            this.craftLabel.Name = "craftLabel";
            this.craftLabel.Size = new System.Drawing.Size(99, 29);
            this.craftLabel.TabIndex = 31;
            this.craftLabel.Text = "Crafting";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(756, 6);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(115, 29);
            this.inventoryLabel.TabIndex = 32;
            this.inventoryLabel.Text = "Inventory";
            // 
            // requires
            // 
            this.requires.AutoSize = true;
            this.requires.BackColor = System.Drawing.Color.Transparent;
            this.requires.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requires.Location = new System.Drawing.Point(975, 410);
            this.requires.Name = "requires";
            this.requires.Size = new System.Drawing.Size(161, 29);
            this.requires.TabIndex = 34;
            this.requires.Text = "Item requires:\r\n";
            // 
            // itemRequires
            // 
            this.itemRequires.FormattingEnabled = true;
            this.itemRequires.Location = new System.Drawing.Point(980, 442);
            this.itemRequires.Name = "itemRequires";
            this.itemRequires.Size = new System.Drawing.Size(188, 69);
            this.itemRequires.TabIndex = 35;
            this.itemRequires.SelectedIndexChanged += new System.EventHandler(this.itemRequires_SelectedIndexChanged);
            // 
            // craftItem
            // 
            this.craftItem.Location = new System.Drawing.Point(980, 517);
            this.craftItem.Name = "craftItem";
            this.craftItem.Size = new System.Drawing.Size(188, 39);
            this.craftItem.TabIndex = 36;
            this.craftItem.Text = "Craft Item";
            this.craftItem.UseVisualStyleBackColor = true;
            this.craftItem.Click += new System.EventHandler(this.craftItem_Click);
            // 
            // scavange
            // 
            this.scavange.Enabled = false;
            this.scavange.Location = new System.Drawing.Point(337, 409);
            this.scavange.Name = "scavange";
            this.scavange.Size = new System.Drawing.Size(88, 25);
            this.scavange.TabIndex = 37;
            this.scavange.Text = "💰 Scavange";
            this.scavange.UseVisualStyleBackColor = true;
            this.scavange.Click += new System.EventHandler(this.scavange_Click);
            // 
            // scavangeLoop
            // 
            this.scavangeLoop.Interval = 10000;
            this.scavangeLoop.Tick += new System.EventHandler(this.scavangeLoop_Tick);
            // 
            // rest
            // 
            this.rest.Location = new System.Drawing.Point(431, 409);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(88, 25);
            this.rest.TabIndex = 38;
            this.rest.Text = "🛌 Rest";
            this.rest.UseVisualStyleBackColor = true;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // restLoop
            // 
            this.restLoop.Interval = 10000;
            this.restLoop.Tick += new System.EventHandler(this.restLoop_Tick);
            // 
            // openFile
            // 
            this.openFile.FileName = "Eclipse Save File";
            this.openFile.Filter = "Eclipse Save Files|*.ecl";
            this.openFile.Title = "Eclipse - Open From File";
            // 
            // saveFile
            // 
            this.saveFile.FileName = "Eclipse Save File";
            this.saveFile.Filter = "Eclipse Save Files|*.ecl";
            this.saveFile.Title = "Eclipse - Save Game";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(243, 523);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 25);
            this.saveButton.TabIndex = 39;
            this.saveButton.Text = "🖺 Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(337, 523);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(88, 25);
            this.loadButton.TabIndex = 40;
            this.loadButton.Text = "📁 Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(665, 523);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 25);
            this.exitButton.TabIndex = 41;
            this.exitButton.Text = "🗙Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(571, 523);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(88, 25);
            this.mainMenu.TabIndex = 42;
            this.mainMenu.Text = "🚪 Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(477, 523);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(88, 25);
            this.settings.TabIndex = 43;
            this.settings.Text = "⚙ Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // notStableTick
            // 
            this.notStableTick.Interval = 1000;
            this.notStableTick.Tick += new System.EventHandler(this.notStableTick_Tick);
            // 
            // guildHub
            // 
            this.guildHub.Location = new System.Drawing.Point(243, 467);
            this.guildHub.Name = "guildHub";
            this.guildHub.Size = new System.Drawing.Size(88, 25);
            this.guildHub.TabIndex = 44;
            this.guildHub.Text = "🏠 Guild Info";
            this.guildHub.UseVisualStyleBackColor = true;
            this.guildHub.Click += new System.EventHandler(this.guildHub_Click);
            // 
            // achievements
            // 
            this.achievements.Location = new System.Drawing.Point(665, 467);
            this.achievements.Name = "achievements";
            this.achievements.Size = new System.Drawing.Size(88, 25);
            this.achievements.TabIndex = 45;
            this.achievements.Text = "Achievements";
            this.achievements.UseVisualStyleBackColor = true;
            this.achievements.Click += new System.EventHandler(this.achivements_Click);
            // 
            // storage
            // 
            this.storage.Location = new System.Drawing.Point(337, 467);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(88, 25);
            this.storage.TabIndex = 46;
            this.storage.Text = "📮 Storage";
            this.storage.UseVisualStyleBackColor = true;
            this.storage.Click += new System.EventHandler(this.storage_Click);
            // 
            // moveItem
            // 
            this.moveItem.Enabled = false;
            this.moveItem.Location = new System.Drawing.Point(848, 517);
            this.moveItem.Name = "moveItem";
            this.moveItem.Size = new System.Drawing.Size(42, 39);
            this.moveItem.TabIndex = 47;
            this.moveItem.Text = "Move";
            this.moveItem.UseVisualStyleBackColor = true;
            this.moveItem.Click += new System.EventHandler(this.moveItem_Click);
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 560);
            this.Controls.Add(this.moveItem);
            this.Controls.Add(this.storage);
            this.Controls.Add(this.achievements);
            this.Controls.Add(this.guildHub);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.scavange);
            this.Controls.Add(this.craftItem);
            this.Controls.Add(this.itemRequires);
            this.Controls.Add(this.requires);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.craftLabel);
            this.Controls.Add(this.craft);
            this.Controls.Add(this.hunt);
            this.Controls.Add(this.mainConsole);
            this.Controls.Add(this.weapon);
            this.Controls.Add(this.throwItem);
            this.Controls.Add(this.use);
            this.Controls.Add(this.itemDescription);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.infectionbar);
            this.Controls.Add(this.infection);
            this.Controls.Add(this.healthoverflow);
            this.Controls.Add(this.healthsmall);
            this.Controls.Add(this.hungerbar);
            this.Controls.Add(this.hunger);
            this.Controls.Add(this.agility);
            this.Controls.Add(this.endurance);
            this.Controls.Add(this.intelligence);
            this.Controls.Add(this.luck);
            this.Controls.Add(this.charisma);
            this.Controls.Add(this.constitution);
            this.Controls.Add(this.dexterity);
            this.Controls.Add(this.strength);
            this.Controls.Add(this.xpbar);
            this.Controls.Add(this.xp);
            this.Controls.Add(this.health);
            this.Controls.Add(this.healthbar);
            this.Controls.Add(this.clan);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Console";
            this.Text = "Eclipse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Console_FormClosed);
            this.Load += new System.EventHandler(this.Console_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label clan;
        private System.Windows.Forms.ProgressBar healthbar;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label xp;
        private System.Windows.Forms.ProgressBar xpbar;
        private System.Windows.Forms.Label strength;
        private System.Windows.Forms.Label dexterity;
        private System.Windows.Forms.Label constitution;
        private System.Windows.Forms.Label charisma;
        private System.Windows.Forms.Label luck;
        private System.Windows.Forms.Label intelligence;
        private System.Windows.Forms.Timer oneTick;
        private System.Windows.Forms.Label endurance;
        private System.Windows.Forms.Label agility;
        private System.Windows.Forms.Label hunger;
        private System.Windows.Forms.ProgressBar hungerbar;
        private System.Windows.Forms.ProgressBar healthsmall;
        private System.Windows.Forms.ProgressBar healthoverflow;
        private System.Windows.Forms.ProgressBar infectionbar;
        private System.Windows.Forms.Label infection;
        private System.Windows.Forms.Timer healthDegen;
        private System.Windows.Forms.Timer infectionDecay;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox itemDescription;
        private System.Windows.Forms.Button use;
        private System.Windows.Forms.Button throwItem;
        private System.Windows.Forms.Label weapon;
        private System.Windows.Forms.Button hunt;
        public System.Windows.Forms.RichTextBox mainConsole;
        private System.Windows.Forms.Timer huntLoop;
        public System.Windows.Forms.ListBox inventory;
        public System.Windows.Forms.ListBox craft;
        private System.Windows.Forms.Label craftLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label requires;
        public System.Windows.Forms.ListBox itemRequires;
        private System.Windows.Forms.Button craftItem;
        private System.Windows.Forms.Button scavange;
        private System.Windows.Forms.Timer scavangeLoop;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.Timer restLoop;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Timer notStableTick;
        private System.Windows.Forms.Button guildHub;
        private System.Windows.Forms.Button achievements;
        private System.Windows.Forms.Button storage;
        private System.Windows.Forms.Button moveItem;
    }
}