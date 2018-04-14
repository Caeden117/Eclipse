using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

#pragma warning disable IDE1006 // Naming Styles
namespace Eclipse
{
    public partial class LevelUp : Form
    {
        Items itemList = new Items();
        Random rng = new Random();
        LootTables lootTables = new LootTables();
        public LevelUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bob = true;
            if (strength.Checked == true)
            {
                Properties.Settings.Default.Strength++;
                Close();
            }else if (dexterity.Checked == true)
            {
                Properties.Settings.Default.Dexterity++;
                Close();
            }
            else if (constitution.Checked == true)
            {
                Properties.Settings.Default.Constitution++;
                Close();
            }
            else if (charisma.Checked == true)
            {
                Properties.Settings.Default.Charisma++;
                Close();
            }
            else if (luck.Checked == true)
            {
                Properties.Settings.Default.Luck++;
                Close();
            }
            else if (agility.Checked == true)
            {
                Properties.Settings.Default.Agility++;
                Close();
            }
            else if (endurance.Checked == true)
            {
                Properties.Settings.Default.Endurance++;
                Close();
            }
            else if (intelligence.Checked == true)
            {
                Properties.Settings.Default.Intelligence++;
                Close();
            }
            else
            {
                MessageBox.Show("Please choose one of the skills before progressing.", "Eclipse - Choose Skill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bob = !bob;
            }
            if (bob && intelligence.Checked == true)
            {

                var newLine = System.Environment.NewLine;
                string craftText = "New items available for crafting:" + newLine + newLine;
                if (itemList.recipes.Where(g => g.craftLevel <= Properties.Settings.Default.craftLevel || g.craftLevel == 0).ToArray().Length > 0)
                {
                    foreach (Craft craft in itemList.recipes.Where(g => g.intLevel == Properties.Settings.Default.Intelligence && (g.craftLevel <= Properties.Settings.Default.craftLevel || g.craftLevel == 0)))
                    {
                        craftText = craftText + (craft.result + newLine);
                    }
                    MessageBox.Show(craftText, "Eclipse - New Recipes Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void strength_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void dexterity_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void constitution_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void charisma_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void luck_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void intelligence_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void endurance_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void agility_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void LevelUp_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Level == 5)
            {
                richTextBox1.AppendText("Ability to Scavenge unlocked!");
            }
        }
    }
}
