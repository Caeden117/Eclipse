using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclipse
{
    public partial class EclipseGuide : Form
    {
        Point point;
        string itemReference;

        public EclipseGuide()
        {
            InitializeComponent();
        }

        private void EclipseGuide_Load(object sender, EventArgs e)
        {
            goToComponent.Enabled = false;
            point = itemProperties.Location;
            foreach(Item item in new Items().items)
            {
                listBox1.Items.Add(item.name);
            }
            sizes.Text = "Items: " + listBox1.Items.Count;
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            toggleListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toggleButton.Text == "Crafting")
            {
                Item item = new Items().find(listBox1.SelectedItem.ToString());
                itemName.Text = item.name;
                itemName.ForeColor = Color.FromName(Items.rarityColors[item.rarityLevel]);
                itemDescription.Text = item.description;
                itemUsability.Text = "Weight: " + item.weight + " | ";
                if (item.isUseable) //Can it be used?
                {
                    itemUsability.Text += "Useable.";
                    foreach(int uses in item.useMode) //What can it be used for
                    {
                        string amount;
                        try
                        {
                            amount = item.amount[item.useMode.ToList().IndexOf(uses)] == -1 ? "all" : item.amount[item.useMode.ToList().IndexOf(uses)].ToString();
                        }
                        catch (Exception)
                        {
                            amount = "";
                        }
                        switch (uses) //My first time using a switch!
                        {
                            case 0: itemUsability.Text += Environment.NewLine + "Heals " + amount + " HP.";
                                break;
                            case 1: itemUsability.Text += Environment.NewLine + "Restores " + amount + " Hunger.";
                                break;
                            case 2:
                                if (int.TryParse(amount, out int result) && result < 0)
                                    itemUsability.Text += Environment.NewLine + "Adds " + (int.Parse(amount) * -1) + " Infection.";
                                else
                                    itemUsability.Text += Environment.NewLine + "Removes " + amount + " Infection.";
                                break;
                            case 3:
                                itemUsability.Text += Environment.NewLine + "Can be equipped as a Weapon.";
                                break;
                            case 4:
                                itemUsability.Text += Environment.NewLine + "Upgrades crafting level. Removed when crafted.";
                                break;
                            case 5:
                                itemUsability.Text += Environment.NewLine + "Can be used to hold a total weight of " + amount + ".";
                                break;
                        }
                    }
                }
                else
                {
                    itemUsability.Text += "Cannot be used.";
                }
                if (item.name == "Totem of Undying")
                {
                    itemUsability.Text += Environment.NewLine + "Prevents death while in player's inventory.";
                    itemUsability.Text += Environment.NewLine + "When the player dies, it restores everything";
                    itemUsability.Text += Environment.NewLine + "and gets consumed.";
                }
                itemUsability.Text += Environment.NewLine;
                if (new LootTables().mobLootTable.ToList().IndexOf(item.name) > -1) //If the item is in mob drops.
                {
                    itemUsability.Text += Environment.NewLine + "Can be found as a mob drop.";
                }
                for (var i = 0; i < new LootTables().lootingTables.GetLength(0); i++)
                {
                    if (!checkSecondDimension(i, item)) break;
                }
                try
                {
                    if (new Items().lookupCraft(item.name).result == item.name)
                    {
                        itemUsability.Text += Environment.NewLine + Environment.NewLine + "This item can be crafted.";
                        goToCrafting.Visible = true;
                    }
                    else
                    {
                        goToCrafting.Visible = false;
                    }
                }
                catch (Exception)
                {
                    goToCrafting.Visible = false;
                }
                itemIntelligence.Text = "Minimum Intelligence to use this item: " + item.intLevel;
            }
            else
            {
                Craft craft = new Items().lookupCraft(listBox1.SelectedItem.ToString());
                craftResult.Text = craft.result;
                craftComponents.Items.Clear();
                foreach(string requirement in craft.prerequisites)
                {
                    craftComponents.Items.Add(requirement);
                }
                switch (craft.craftLevel)
                {
                    case 0: craftDetails.Text = "Can be crafted from the beginning.";
                        break;
                    case 1:
                        craftDetails.Text = "Requires a Fire to craft.";
                        break;
                    case 2:
                        craftDetails.Text = "Requires a Workbench to craft.";
                        break;
                    case 3:
                        craftDetails.Text = "Requires a Forge to craft.";
                        break;
                }
                craftIntelligence.Text = "Minimum Intelligence to craft this item: " + craft.intLevel;
            }
        }

        bool checkSecondDimension(int i, Item item)
        {
            for (var j = 0; j < new LootTables().lootingTables.GetLength(1); j++)
            {
                if (new LootTables().lootingTables[i, j] == item.name)
                {
                    itemUsability.Text += Environment.NewLine + "Can be found while scavaging starting level " + Convert.ToInt32(Math.Floor(Convert.ToDecimal(i + 5) * 2)) + ".";
                    return false;
                }
            }
            return true;
        }

        public void toggleListBox()
        {
            listBox1.Items.Clear();
            if (toggleButton.Text == "Crafting")
            {
                itemProperties.Location = craftingProperties.Location;
                craftingProperties.Location = point;
                foreach (Craft craft in new Items().recipes)
                {
                    listBox1.Items.Add(craft.result);
                }
                sizes.Text = "Recipes: " + new Items().recipes.Length;
            }
            else
            {
                craftingProperties.Location = itemProperties.Location;
                itemProperties.Location = point;
                foreach (Item item in new Items().items)
                {
                    listBox1.Items.Add(item.name);
                }
                sizes.Text = "Items: " + new Items().items.Length;
            }
            toggleButton.Text = toggleButton.Text == "Crafting" ? "Items" : "Crafting";
            if (itemReference != "")
            {
                listBox1.SelectedItem = itemReference;
                itemReference = "";
            }
        }

        private void craftComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (craftComponents.SelectedIndex > -1)
            {
                goToComponent.Enabled = true;
            }
        }

        private void goToItem_Click(object sender, EventArgs e)
        {
            itemReference = listBox1.SelectedItem.ToString();
            toggleListBox();
        }

        private void goToCrafting_Click(object sender, EventArgs e)
        {
            goToItem_Click(sender, e);
        }

        private void goToComponent_Click(object sender, EventArgs e)
        {
            itemReference = craftComponents.SelectedItem.ToString();
            toggleListBox();
        }
    }
}
