using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Properties.Settings.Default.tutorialList:
    S: Start
    I: Infected
    O: Health Overflow
    M: Health Overflow Max reached
    H: Hunger reaches 0
    W: Over carrying capacity (Overweight)
    C: Crafting first item
    F: Crafting Forge
    B: Crafting Workbench
*/

#pragma warning disable IDE1006 // Naming Styles
namespace Eclipse
{
    public partial class Console : Form
    {
        Items itemList = new Items();
        Random rng = new Random();
        LootTables lootTables = new LootTables();
        Item fist;
        Mob mob;
        Button[] pausedControls = new Button[] {};
        float weight2 = 0;
        public bool isPaused = false;
        public Console()
        {
            fist = itemList.items.First();
            InitializeComponent();
        }

        private void Console_Load(object sender, EventArgs e)
        {
            pausedControls = new Button[] { hunt, scavange, rest, };
            inventory.Items.Add("Stick");
            inventory.Items.Add("Wood Plank");
            inventory.Items.Add("Leather Strap");
            inventory.Items.Add("Stick");
            inventory.Items.Add("Wood Plank");
            inventory.Items.Add("Leather Strap");
            foreach(string item in itemList.lookupCraft("Workbench").prerequisites)
            {
                inventory.Items.Add(item);
            }
            
            if (Properties.Settings.Default.tutorialList.IndexOf("S") == -1 && Properties.Settings.Default.tutorial)
            {
                Properties.Settings.Default.tutorialList = Properties.Settings.Default.tutorialList + "S";
                MessageBox.Show("Welcome to Eclipse! Throughout your game, these Tutorial messages will pop up. You can disable these in the Settings.", "Eclipse Tutorial - Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void oneTick_Tick(object sender, EventArgs e)
        {
            strength.Text = "Strength: " + Properties.Settings.Default.Strength;
            dexterity.Text = "Dexterity: " + Properties.Settings.Default.Dexterity;
            charisma.Text = "Charisma: " + Properties.Settings.Default.Charisma;
            constitution.Text = "Constitution: " + Properties.Settings.Default.Constitution;
            luck.Text = "Luck: " + Properties.Settings.Default.Luck;
            intelligence.Text = "Intelligence: " + Properties.Settings.Default.Intelligence;
            endurance.Text = "Endurance: " + Properties.Settings.Default.Endurance;
            agility.Text = "Agility: " + Properties.Settings.Default.Agility;
            health.Text = "HP: " + Properties.Settings.Default.HP + "/" + Properties.Settings.Default.HPMax;
            name.Text = Properties.Settings.Default.Name;
            clan.Text = Properties.Settings.Default.Clan;
            if (Properties.Settings.Default.HPOverflow >= Properties.Settings.Default.HPOverflowMax)
            {
                Properties.Settings.Default.HPOverflow = Properties.Settings.Default.HPOverflowMax;
                if (Properties.Settings.Default.tutorialList.IndexOf("M") == -1 && Properties.Settings.Default.tutorial)
                {
                    Properties.Settings.Default.tutorialList = Properties.Settings.Default.tutorialList + "M";
                    MessageBox.Show("Woah there!" + newSection() + "You have healed yourself to the point where you've hit your overflow max! Any extra health would be discarded forever, so use your healing items wisely!", "Eclipse Tutorial - Overflow Maximum Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (Properties.Settings.Default.HPOverflow <= Properties.Settings.Default.HPOverflowMax)
                healthoverflow.Value = Convert.ToInt32(healthoverflow.Maximum * (Properties.Settings.Default.HPOverflow / (decimal)Properties.Settings.Default.HPOverflowMax));
            Properties.Settings.Default.HPOverflowMax = Convert.ToInt32(Math.Round(Convert.ToDouble(Properties.Settings.Default.HPMax / 4)));

            if (Properties.Settings.Default.HP <= Properties.Settings.Default.HPMax && Properties.Settings.Default.HP >= 0)
                healthbar.Value = Convert.ToInt32(healthbar.Maximum * (Properties.Settings.Default.HP / (decimal)Properties.Settings.Default.HPMax));

            healthsmall.Value = 100;

            xp.Text = "Level: " + Properties.Settings.Default.Level;
            if (Properties.Settings.Default.XP <= Properties.Settings.Default.XPMax)
                xpbar.Value = Convert.ToInt32(xpbar.Maximum * (Properties.Settings.Default.XP / (decimal)Properties.Settings.Default.XPMax));
            if (Properties.Settings.Default.XP >= Properties.Settings.Default.XPMax)
            {
                Properties.Settings.Default.XP = 0;
                Properties.Settings.Default.XPMax += rng.Next(25, 150);
                Properties.Settings.Default.Level++;
                if (getModifier(Properties.Settings.Default.Constitution) < 0)
                {
                    Properties.Settings.Default.HPMax += rng.Next(3, 8);
                }
                else
                {
                    Properties.Settings.Default.HPMax += rng.Next(3, 8) + getModifier(Properties.Settings.Default.Constitution);
                }
                LevelUp levelUp = new LevelUp();
                levelUp.Show();
            }
            hunger.Text = "Hunger: " + Properties.Settings.Default.Hunger;
            hungerbar.Value = Properties.Settings.Default.Hunger;
            infection.Text = "Infection: " + Properties.Settings.Default.Infection;
            if (Properties.Settings.Default.Infection <= 100)
                infectionbar.Value = Properties.Settings.Default.Infection;
            if (Properties.Settings.Default.HPOverflowMax > 100)
                Properties.Settings.Default.HPOverflowMax = 100;
            if (Properties.Settings.Default.HPOverflow > Properties.Settings.Default.HPOverflowMax)
                Properties.Settings.Default.HP = Properties.Settings.Default.HPMax + Properties.Settings.Default.HPOverflowMax;

            if (Properties.Settings.Default.weapon == fist.name)
            {
                weapon.Text = "Weapon: " + Properties.Settings.Default.weapon;
            }
            else
            {
                weapon.Text = "Weapon: " + Properties.Settings.Default.weapon + " (" + itemList.find(Properties.Settings.Default.weapon).durability + " Durability)";
            }
            weapon.ForeColor = Color.FromName(itemList.rarityColors[itemList.find(Properties.Settings.Default.weapon).rarityLevel]);

            Properties.Settings.Default.carryingCap = 120 + (20 * getModifier(Properties.Settings.Default.Strength));
            float weight3 = 0;
            for (var i = 0; i < inventory.Items.Count; i++)
            {
                if (itemList.find(inventory.Items[i].ToString()).name != itemList.empty.name)
                {
                    weight3 += itemList.find(inventory.Items[i].ToString()).weight;
                }
            }
            weight2 = weight3;
            weight.Text = "Weight: " + weight2 + " / " + Properties.Settings.Default.carryingCap;

            if (weight2 > Properties.Settings.Default.carryingCap)
            {
                if (Properties.Settings.Default.tutorialList.IndexOf("W") == -1 && Properties.Settings.Default.tutorial)
                {
                    Properties.Settings.Default.tutorialList = Properties.Settings.Default.tutorialList + "W";
                    MessageBox.Show("You have exceeded your carrying capacity!" + newSection() + "While you are over capacity, any items you would obtain will automatically be discarded, and other effects!" + newSection() + "Increase carrying capacity by investing more into Strength.", "Eclipse Tutorial - Infection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Properties.Settings.Default.overweight = true;
            }
            else
            {
                Properties.Settings.Default.overweight = false;
            }

            if (infectionbar.Value > 0 && Properties.Settings.Default.tutorialList.IndexOf("I") == -1 && Properties.Settings.Default.tutorial)
            {
                Properties.Settings.Default.tutorialList = Properties.Settings.Default.tutorialList + "I";
                MessageBox.Show("Uh oh! It appears that you've been Infected!" + newSection() + "Infection is caused by being hit by a Zombie, or by eating rotten meat." + newSection() + "Until Infection reaches 0, you will periodically take damage! When Infection reaches 100, it's game over!" + newSection() + "Infection can decrease over time, or be cured with items.", "Eclipse Tutorial - Infection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Properties.Settings.Default.HP > Properties.Settings.Default.HPMax)
            {
                if (Properties.Settings.Default.tutorialList.IndexOf("O") == -1 && Properties.Settings.Default.tutorial)
                {
                    Properties.Settings.Default.tutorialList = Properties.Settings.Default.tutorialList + "O";
                    MessageBox.Show("You have regenerated health up to the point where it overflowed!" + newSection() + "This can only occur by using certain healing items, and can allow for up to 25% of your max HP, with a maximum of 100 extra health." + newSection() + "Any overflowed HP will decrease naturally.", "Eclipse Tutorial - Health Overflow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Properties.Settings.Default.HPOverflow = Properties.Settings.Default.HP - Properties.Settings.Default.HPMax;
                healthsmall.Visible = true;
                healthoverflow.Visible = true;
                healthbar.Visible = false;
            }
            else
            {
                healthsmall.Visible = false;
                healthoverflow.Visible = false;
                healthbar.Visible = true;
            }
            craftItem.Enabled = craft.Items.Count > 0 ? true : false;
            foreach (var recipe in itemList.recipes.Where(g => g.craftLevel <= Properties.Settings.Default.craftLevel || g.craftLevel == 0))
            {
                List<string> item2 = new List<string>(inventory.Items.Cast<String>().ToList());
                var recipeCount = 0;
                foreach (var item in recipe.prerequisites)
                {
                    if (item2.Contains(item))
                    {
                        recipeCount++;
                        item2.Remove(item);
                    }
                }
                if (recipeCount == recipe.prerequisites.Length && recipe.canCraft())
                {
                    if (!craft.Items.Contains(recipe.result))
                    {
                        craft.Items.Add(recipe.result);
                        if ((recipe.result == "Workbench" && Properties.Settings.Default.craftLevel > 0) || (recipe.result == "Forge" && Properties.Settings.Default.craftLevel > 1) || (inventory.Items.Contains(recipe.result) && itemList.find(recipe.result).durability > 0))
                        {
                            craft.Items.Remove(recipe.result);
                        }
                    }
                    else if ((recipe.result == "Workbench" && Properties.Settings.Default.craftLevel > 0) || (recipe.result == "Forge" && Properties.Settings.Default.craftLevel > 1) || (inventory.Items.Contains(recipe.result) && itemList.find(recipe.result).durability > 0))
                    {
                        craft.Items.Remove(recipe.result);
                    }
                }
                else
                {
                    if (craft.Items.Contains(recipe.result))
                    {
                        craft.Items.Remove(recipe.result);
                    }
                }
                recipeCount = 0;
            }

            if (Properties.Settings.Default.Level >= 5)
            {
                scavange.Enabled = true;
            }
            else
            {
                if (scavange.Enabled == true)
                    scavange.Enabled = false;
            }

            foreach(Button button in pausedControls)
            {
                if (button == scavange)
                {
                    if (Properties.Settings.Default.Level >= 5 && isPaused == false)
                    {
                        scavange.Enabled = true;
                    }
                    else
                    {
                        if (scavange.Enabled == true)
                            scavange.Enabled = false;
                    }
                }
                else
                {
                    button.Enabled = !isPaused;
                }
            }

            if (Size.Width == 975)
            {
                craftButton.Text = "Craft >>>";
            }
            else
            {
                craftButton.Text = "<<< Craft";
            }

        }
        
        private int makeCheck(int score)
        {
            return rng.Next(1, 20) + getModifier(score);
        }

        private int roll(int size)
        {
            return rng.Next(1, size);
        }

        private int getModifier(int score)
        {
            return (score - 10) / 2;
        }

        private string newSection()
        {
            return System.Environment.NewLine + System.Environment.NewLine;
        }

        private void strength_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.tutorial)
            {
                MessageBox.Show("Strength - Your raw power. With higher Strength, you can crush enemies with ease and carry a heavier load." +
                    newSection() +
                    "Strength affects: Melee weapon damage, carrying capacity, and Armor.", "Eclipse Tutorial - Strength", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dexterity_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.tutorial)
            {
                MessageBox.Show("Dexterity - How fast you can move. With higher Dexterity, you can shoot and swing with pride." +
                    newSection() +
                    "Dexterity affects: Ranged weapon damage, melee weapon accuracy, ", "Eclipse Tutorial - Dexterity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void agility_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.tutorial)
            {
                MessageBox.Show("Agility - How efficient you can move. With higher Agility, you can shoot from afar and easily dodge from harm's way." +
                    newSection() +
                    "Agility affects: Ranged weapon accuracy and chance to dodge attacks.", "Eclipse Tutorial - Agility", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void constitution_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.tutorial)
            {
                MessageBox.Show("Constituion - How healthy you are. With higher Constituion, you are more resistant to infection and can heal faster than others." +
                    newSection() +
                    "Constitution affects: Resistance to Infection, max health gain every level, and health gained from resting.", "Eclipse Tutorial - Constitution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void endurance_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.tutorial)
            {
                MessageBox.Show("Endurance - How tough you are. With higher Endurance, you can shrug away effects of Infection and Hunger.." +
                    newSection() +
                    "Endurance affects: Damage dealt from Infection and Hunger.", "Eclipse Tutorial - Endurance", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void intelligence_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.tutorial)
            {
                MessageBox.Show("Intelligence - How smart you are. With higher Intelligence, you can understand more concepts and items." +
                    newSection() +
                    "Intelligence affects: Ability to understand Items (And therefore equip and use them), and understand more crafting recipes.", "Eclipse Tutorial - Intelligence", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void charisma_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.tutorial)
            {
                MessageBox.Show("Charisma - How persuasive you are. A higher Charisma influences your chances of recruiting new survivors and negotiating." +
                    newSection() +
                    "Charisma affects: Likelihood of other survivors joining your group, and chances of making peace with other groups (Therefore lowing prices while Trading).", "Eclipse Tutorial - Charisma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void luck_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.tutorial)
            {
                MessageBox.Show("Luck - It's in the name. It doesn't effect as much as you'd think; Real luck has no modifiers." +
                    newSection() +
                    "Luck affects: Chances of finding more and better loot while Looting, chances of finding a survivor, and other tiny things ;)", "Eclipse Tutorial - Luck", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void healthDegen_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.HP > Properties.Settings.Default.HPMax)
            {
                Properties.Settings.Default.HP--;
            }
            if (Properties.Settings.Default.Hunger > 0)
            {
                Properties.Settings.Default.Hunger--;
            }
            else
            {
                if (Properties.Settings.Default.tutorialList.IndexOf("H") == -1 && Properties.Settings.Default.tutorial)
                {
                    Properties.Settings.Default.tutorialList = Properties.Settings.Default.tutorialList + "H";
                    MessageBox.Show("Your hunger has reached 0!" + newSection() + "Health will slowly degenerate if you don't eat food.", "Eclipse Tutorial - Hunger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Properties.Settings.Default.HP--;
                if (getModifier(Properties.Settings.Default.Endurance) < 0)
                {
                    Properties.Settings.Default.HP -= getModifier(Properties.Settings.Default.Endurance) / 2;
                }
            }
        }

        private void infectionDecay_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Infection > 0) {
                int damage = rng.Next(0, 7);
                if (getModifier(Properties.Settings.Default.Endurance) < damage && getModifier(Properties.Settings.Default.Endurance) > 0)
                {
                    damage -= getModifier(Properties.Settings.Default.Endurance);
                }
                Properties.Settings.Default.HP -= damage;
                Properties.Settings.Default.Infection -= rng.Next(0, 15);
                if (Properties.Settings.Default.Infection < 0)
                    Properties.Settings.Default.Infection = 0;
            }
        }

        private void inventory_SelectedIndexChanges(object sender, EventArgs e)
        {
            if (inventory.SelectedIndex > -1)
            {
                throwItem.Enabled = true;
                itemName.Text = itemList.find(inventory.SelectedItem.ToString()).name;
                itemName.ForeColor = Color.FromName(itemList.rarityColors[itemList.find(inventory.SelectedItem.ToString()).rarityLevel]);
                if (Properties.Settings.Default.Intelligence >= itemList.find(inventory.SelectedItem.ToString()).intLevel)
                {
                    itemDescription.Text = itemList.find(inventory.SelectedItem.ToString()).description;
                    if (itemList.find(inventory.SelectedItem.ToString()).isUseable)
                    {
                        use.Enabled = true;
                        if (itemList.find(inventory.SelectedItem.ToString()).useMode.First() == 3)
                        {
                            if (Properties.Settings.Default.weapon == itemList.find(inventory.SelectedItem.ToString()).name)
                            {
                                use.Text = "Put Away";
                            }
                            else
                            {
                                use.Text = "Equip";
                            }
                        }
                        else
                        {
                            use.Text = "Use";
                        }
                    }
                    else
                    {
                        use.Enabled = false;
                    }
                }
                else
                {
                    use.Text = "Use";
                    use.Enabled = false;
                    itemDescription.Text = "You lack the required Intelligence to be able to use this item.";
                }
            }
            else
            {
                itemName.Text = "No item selected.";
                itemDescription.Text = "";
                use.Enabled = false;
                throwItem.Enabled = false;
            }
        }

        private void use_Click(object sender, EventArgs e)
        {
            if (itemList.find(inventory.SelectedItem.ToString()).useMode[0] != 3)
            {
                itemList.find(inventory.SelectedItem.ToString()).onUse();
                inventory.Items.RemoveAt(inventory.SelectedIndex);
            }
            else
            {
                if (Properties.Settings.Default.weapon == itemList.find(inventory.SelectedItem.ToString()).name)
                {
                    Properties.Settings.Default.weapon = fist.name;
                    use.Text = "Equip";
                }
                else
                {
                    Properties.Settings.Default.weapon = itemList.find(inventory.SelectedItem.ToString()).name;
                    use.Text = "Put Away";
                }
                weapon.ForeColor = Color.FromName(itemList.rarityColors[itemList.find(Properties.Settings.Default.weapon).rarityLevel]);
            }
        }

        private void throwItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to throw this item away? This item will be thrown away permenately!", "Eclipse - Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                inventory.Items.RemoveAt(inventory.SelectedIndex);
            }
        }

        private void hunt_Click(object sender, EventArgs e)
        {
            huntLoop.Enabled = true;
            isPaused = true;
            mainConsole.AppendText(System.Environment.NewLine + "You are now hunting. Until this fight is over, certain actions are restricted!");
            mob = new Mob(Properties.Settings.Default.Level);
            mainConsole.AppendText(newSection() + "Encountered a " + mob.name + "!");
        }

        public void damageWeapon()
        {
            var newWeapon = itemList.find(Properties.Settings.Default.weapon);
            if (newWeapon.durability != -1)
            {
                newWeapon.durability = newWeapon.durability - 1;
                if (newWeapon.durability == 0)
                {
                    newWeapon.durability = newWeapon.amount.Last();
                    inventory.Items.Remove(itemList.find(Properties.Settings.Default.weapon).name);
                    Properties.Settings.Default.weapon = fist.name;
                    mainConsole.AppendText(System.Environment.NewLine + "Your weapon broke after you finished your attack...");
                }
            }
            mainConsole.AppendText(System.Environment.NewLine + newWeapon.durability);
        }

        private void huntLoop_Tick(object sender, EventArgs e)
        {
            int attack = makeCheck(Properties.Settings.Default.Dexterity);
            if (attack == 20 + getModifier(Properties.Settings.Default.Dexterity))
            {
                int damage = rng.Next(0, itemList.find(Properties.Settings.Default.weapon).amount[0]) + getModifier(Properties.Settings.Default.Strength);
                if (damage < 1)
                {
                    damage = 1;
                }
                damage *= 2;
                mainConsole.AppendText(System.Environment.NewLine + "Critical hit! You hit the mob for " + damage + " damage!");
                mob.health -= damage;
                damageWeapon();
            }
            else if (attack == 1 + getModifier(Properties.Settings.Default.Agility))
            {
                int damage = rng.Next(0, itemList.find(Properties.Settings.Default.weapon).amount[0]) + getModifier(Properties.Settings.Default.Strength);
                if (damage < 1)
                {
                    damage = 1;
                }
                mainConsole.AppendText(System.Environment.NewLine + "Failure! You hit yourself for " + damage + " damage!");
                Properties.Settings.Default.HP -= damage;
                damageWeapon();
            }
            else
            {
                if (attack >= mob.armor)
                {
                    int damage = rng.Next(0, itemList.find(Properties.Settings.Default.weapon).amount[0]) + getModifier(Properties.Settings.Default.Strength);
                    if (damage < 1)
                    {
                        damage = 1;
                    }
                    mainConsole.AppendText(System.Environment.NewLine + "You hit the mob for " + damage + " damage!");
                    mob.health -= damage;
                    damageWeapon();
                }
                else
                {
                    mainConsole.AppendText(System.Environment.NewLine + "You missed!");
                }
            }

            attack = rng.Next(1, 20) + ((mob.agility - 10) / 2);
            if (attack == 20 + ((mob.agility - 10) / 2))
            {
                int damage = rng.Next(0, 2 * mob.level) + ((mob.strength - 10) / 2);
                if (damage < 0)
                {
                    damage = 0;
                }
                damage *= 2;
                mainConsole.AppendText(System.Environment.NewLine + "Critical hit! It hits for " + damage + " damage!");
                Properties.Settings.Default.HP -= damage;
                mainConsole.AppendText(System.Environment.NewLine + "You begin to feel sickness flowing through you...");
                Properties.Settings.Default.Infection += rng.Next(0, 15) - ((Properties.Settings.Default.Constitution - 10) / 2);
            }
            else if (attack == 1 + ((mob.agility - 10) / 2))
            {
                int damage = rng.Next(0, 2 * mob.level) + ((mob.strength - 10) / 2);
                if (damage < 0)
                {
                    damage = 0;
                }
                mainConsole.AppendText(System.Environment.NewLine + "Failure! It hits itself for " + damage + " damage!");
                mob.health -= damage;
            }
            else
            {
                if (attack >= Properties.Settings.Default.Armor)
                {
                    int damage = rng.Next(0, 2 * mob.level) + ((mob.strength - 10) / 2);
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    mainConsole.AppendText(System.Environment.NewLine + "It hits for " + damage + " damage!");
                    Properties.Settings.Default.HP -= damage;
                    if (rng.Next(0, 10) == 10)
                    {
                        mainConsole.AppendText(System.Environment.NewLine + "You begin to feel sickness flowing through you...");
                        Properties.Settings.Default.Infection += rng.Next(0, 15) - ((Properties.Settings.Default.Constitution - 10) / 2);
                    }
                }
                else
                {
                    mainConsole.AppendText(System.Environment.NewLine + "It missed!");
                }
            }

            if (mob.health <= 0)
            {
                mainConsole.AppendText(System.Environment.NewLine + "You have killed the mob!" + newSection());
                //int tableLevel = Convert.ToInt32(Math.Floor(Convert.ToDecimal(Properties.Settings.Default.Level / 10)));
                int xpGain = rng.Next(10, 25);
                Properties.Settings.Default.XP += xpGain;
                mainConsole.AppendText(System.Environment.NewLine + "You have recieved: " + xpGain + " XP.");
                Item loot = itemList.find(lootTables.mobLootTable[rng.Next(0, lootTables.mobLootTable.Length)]);
                if (weight2 >= Properties.Settings.Default.carryingCap)
                {
                    mainConsole.AppendText(System.Environment.NewLine + "You would've recieved " + loot.name + ", but you can't carry any more!");
                }
                else
                {
                    inventory.Items.Add(loot.name);
                    mainConsole.AppendText(System.Environment.NewLine + "You have picked up: " + loot.name);
                }
                huntLoop.Enabled = false;
                isPaused = false;
            }
        }

        private void craftButton_Click(object sender, EventArgs e)
        {
            if (Size.Width == 975)
            {
                Size = new Size(1200, Size.Height);
            }
            else
            {
                Size = new Size(975, Size.Height);
            }
        }

        private void craft_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemRequires.Items.Clear();
            if (craft.SelectedIndex != -1)
            {
                foreach (var item in itemList.lookupCraft(craft.SelectedItem.ToString()).prerequisites)
                {
                    itemRequires.Items.Add(item);
                }
            }
        }

        private void itemRequires_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemRequires.SelectedIndex != -1)
            {
                inventory.SelectedItem =  itemRequires.SelectedItem;
            }
        }

        private void craftItem_Click(object sender, EventArgs e)
        {
            if (craft.SelectedIndex != -1)
            {
                var itemResult = itemList.lookupCraft(craft.SelectedItem.ToString()).result;
                int numAmount = 1;
                if (itemResult.Split(' ').Last().First() == 'x' && int.TryParse(itemResult.Split(' ').Last().Substring(1), out numAmount))
                {
                    numAmount = int.Parse(itemResult.Split(' ').Last().Substring(1));
                    itemResult = itemResult.Substring(0, itemResult.IndexOf(itemResult.Split(' ').Last()) - 1);
                }
                var itemsNeeded = itemList.lookupCraft(craft.SelectedItem.ToString()).prerequisites;
                if (itemResult == "Forge")
                {
                    Properties.Settings.Default.craftLevel++;
                    if (Properties.Settings.Default.tutorialList.IndexOf("F") == -1 && Properties.Settings.Default.tutorial)
                    {
                        Properties.Settings.Default.tutorialList = Properties.Settings.Default.tutorialList + "F";
                        MessageBox.Show("Congratulations on creating your Forge!" + newSection() + "Once used, new and more advanced crafting recipes will now be discovered.", "Eclipse Tutorial - Forge", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }else if (itemResult == "Workbench")
                {
                    Properties.Settings.Default.craftLevel++;
                    if (Properties.Settings.Default.tutorialList.IndexOf("B") == -1 && Properties.Settings.Default.tutorial)
                    {
                        Properties.Settings.Default.tutorialList = Properties.Settings.Default.tutorialList + "B";
                        MessageBox.Show("Congratulations on creating your very own Workbench!" + newSection() + "Once used, new crafting recipes will now be available for crafting.", "Eclipse Tutorial - Workbench", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (itemResult != "Workbench" && itemResult != "Forge")
                {
                    for (var i = 0; i < numAmount; i++)
                    {
                        inventory.Items.Add(itemResult);
                    }
                }
                Properties.Settings.Default.XP += rng.Next(15, 50);
                if (Properties.Settings.Default.tutorialList.IndexOf("C") == -1 && Properties.Settings.Default.tutorial)
                {
                    Properties.Settings.Default.tutorialList = Properties.Settings.Default.tutorialList + "C";
                    MessageBox.Show("Congratulations on crafting your first item!" + newSection() + 
                        "The more items you find from looting, hunting, etc., the more items will be available for crafting. For each item you craft, you will be rewarded a small amount of XP.", "Eclipse Tutorial - Crafting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                foreach (var item in itemsNeeded)
                {
                    if (itemList.find(item).durability > -1)
                    {
                        var weapon = itemList.find(item);
                        weapon.durability--;
                        if (itemList.find(item).durability == 0)
                        {
                            inventory.Items.Remove(item);
                            mainConsole.AppendText(System.Environment.NewLine + item + " broke when you finished crafting...");
                        }
                    }
                    else
                    {
                        inventory.Items.Remove(item);
                    }
                }
            }
        }

        private void scavange_Click(object sender, EventArgs e)
        {
            scavangeLoop.Interval = rng.Next(9000, 15000);
            scavangeLoop.Enabled = true;
            isPaused = true;
            mainConsole.AppendText(System.Environment.NewLine + "You are now scavaging. Until you are done scavaging, certain actions are restricted!");
        }

        private void scavangeLoop_Tick(object sender, EventArgs e)
        {
            mainConsole.AppendText(System.Environment.NewLine + "You have finished scavaging.");
            scavangeLoop.Enabled = false;
            isPaused = false;
            for(var i = 0; i < rng.Next(1, 3); i++)
            {
                int tableLevel = Properties.Settings.Default.Level - 5;
                if (Properties.Settings.Default.Luck >= 15)
                    tableLevel++;
                if (Properties.Settings.Default.Luck >= 20)
                    tableLevel++;
                if (tableLevel > lootTables.lootingTables.Length)
                    tableLevel = lootTables.lootingTables.Length;
                if (tableLevel >= 0)
                {
                    for (var b = 0; b < tableLevel + 1; b++)
                    {
                        Item loot = itemList.find(lootTables.lootingTables[b, rng.Next(0, 4)]);
                        if (weight2 >= Properties.Settings.Default.carryingCap)
                        {
                            mainConsole.AppendText(System.Environment.NewLine + "You would've recieved " + loot.name + ", but you can't carry any more!");
                        }
                        else
                        {
                            inventory.Items.Add(loot.name);
                            mainConsole.AppendText(System.Environment.NewLine + "You have picked up: " + loot.name);
                        }
                    }
                }
            }
        }

        private void rest_Click(object sender, EventArgs e)
        {
            restLoop.Interval = rng.Next(9000, 15000) + ((Properties.Settings.Default.HPMax - Properties.Settings.Default.HP) * 100);
            restLoop.Enabled = true;
            isPaused = true;
            mainConsole.AppendText(System.Environment.NewLine + "You are now resting. Depending on how injured you are, you will sleep for longer!");
        }

        private void restLoop_Tick(object sender, EventArgs e)
        {
            int hpGain = rng.Next(5, 15) + getModifier(Properties.Settings.Default.Constitution) + Convert.ToInt32(Math.Round(Convert.ToDecimal(restLoop.Interval / 1000)));
            Properties.Settings.Default.HP += hpGain;
            mainConsole.AppendText(System.Environment.NewLine + "Rise and shine! After resting, you have regained " + hpGain + " health.");
            if (Properties.Settings.Default.HP > Properties.Settings.Default.HPMax)
            {
                Properties.Settings.Default.HP = Properties.Settings.Default.HPMax;
            }
            restLoop.Enabled = false;
            isPaused = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveGame();
        }

        /// <summary>
        /// Saves the game as a file. Returns true if the operation completed successfully.
        /// </summary>
        public bool saveGame()
        {
            mainConsole.AppendText(newSection() + "Saving game...");
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter save = new StreamWriter(saveFile.FileName))
                {
                    foreach (System.Configuration.SettingsProperty value in Properties.Settings.Default.Properties)
                    {
                        save.WriteLine(value.Name + "|" + Properties.Settings.Default[value.Name]);
                    }
                    foreach (string inventoryItem in inventory.Items.Cast<String>())
                    {
                        save.WriteLine(inventoryItem);
                    }
                }
                mainConsole.AppendText(newSection() + "Game saved!");
                return true;
            }
            else
            {
                mainConsole.AppendText(newSection() + "Saving cancelled!");
                return false;
            }
        }

        /// <summary>
        /// Loads the game from a file. Returns true if the operation completed successfully.
        /// </summary>
        public bool loadGame()
        {
            mainConsole.AppendText(newSection() + "Loading game from a save file...");
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFile.FileName))
                {
                    var lines = File.ReadAllLines(openFile.FileName);
                    inventory.Items.Clear();
                    mainConsole.Clear();
                    int tick = 0;
                    foreach (System.Configuration.SettingsProperty value in Properties.Settings.Default.Properties)
                    {
                        tick++;
                    }
                    for (var i = 0; i < lines.Length; i++)
                    {
                        if (i < tick)
                        {
                            int bob = 0;
                            if (lines[i].Split('|').Last() == "False" || lines[i].Split('|').Last() == "True")
                            {
                                Properties.Settings.Default[lines[i].Split('|').First()] = bool.Parse(lines[i].Split('|').Last());
                            }else if (int.TryParse(lines[i].Split('|').Last(), out bob)){
                                Properties.Settings.Default[lines[i].Split('|').First()] = int.Parse(lines[i].Split('|').Last());
                            }
                            else
                            {
                                Properties.Settings.Default[lines[i].Split('|').First()] = lines[i].Split('|').Last();
                            }
                        }
                        else
                        {
                            inventory.Items.Add(lines[i]);
                        }
                    }
                    mainConsole.AppendText(newSection() + "Game loaded successfully!");
                    return true;
                }
                else
                {
                    mainConsole.AppendText(newSection() + "Loading game failed: The file does not exist.");
                    return false;
                }
            }
            else
            {
                mainConsole.AppendText(newSection() + "Loading game failed: Operation cancelled by user.");
                return false;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            loadGame();
        }

        private void Console_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult saveGameBeforeClosing = MessageBox.Show("Do you want to save the game before you exit?", "Eclipse - Save Game?", MessageBoxButtons.YesNoCancel);
            if (saveGameBeforeClosing == DialogResult.No)
            {
                Application.Exit();
            }
            else if (saveGameBeforeClosing == DialogResult.Yes)
            {
                if (saveGame())
                {
                    Application.Exit();
                }
                else
                {
                    new Console().Show();
                }
            }
            else
            {
                new Console().Show();
            }
        }
    }
}