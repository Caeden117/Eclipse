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
    public partial class CharacterCreation : Form
    {
        Random rng = new Random();
        bool createdGame = false;
        string[] tips = new string[] {
            "Stats are randomly chosen on game creation - Base your character off of these!",
            "You can choose one stat to upgrade every level.",
            "Once in a while, you'll stumble upon a survivor. With a high enough Charisma, maybe you could recruit them!",
            "If you're feeling Lucky, you could find more valuable loot in drops!",
            "Each stat you have can influence different aspects of Eclipse!",
            "A high Constitution means you're less likely to be infected!",
            "Not sure what your item does? Maybe you need a higher Intelligence!",
            "Strength plays a role in your Armor, along with any you are currently wearing.",
            "A higher Agility can improve your accuracy and improve your dodging!",
            "Want more damage with ranged weapons and a higher accuracy of melee weapons? Improve Dexterity!",
            "A high Endurance can lessen the effects of Infection and Hunger!",
        };

        public CharacterCreation()
        {
            InitializeComponent();
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            richTextBox1.Text += tips[rng.Next(0, tips.Length)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                createdGame = true;
                if(tutorial.Checked == true)
                {
                    Properties.Settings.Default.tutorial = true;
                }
                else
                {
                    Properties.Settings.Default.tutorial = false;
                }

                richTextBox1.AppendText(System.Environment.NewLine + "Generating character...");
                Properties.Settings.Default.Name = textBox1.Text;
                Properties.Settings.Default.Clan = textBox2.Text;
                Properties.Settings.Default.HP = 20;
                Properties.Settings.Default.HPMax = 20;
                Properties.Settings.Default.Strength = rng.Next(0, 20);
                Properties.Settings.Default.Charisma = rng.Next(0, 20);
                Properties.Settings.Default.Dexterity = rng.Next(0, 20);
                Properties.Settings.Default.Luck = rng.Next(0, 20);
                Properties.Settings.Default.Constitution = rng.Next(0, 20);
                Properties.Settings.Default.Endurance = rng.Next(0, 20);
                Properties.Settings.Default.Agility = rng.Next(0, 20);
                Properties.Settings.Default.Intelligence = rng.Next(0, 20);
                Console console = new Console();
                console.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Your name or Clan name cannot be empty. Make sure they are not empty, then try again.", "Eclipse - Character Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void CharacterCreation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (createdGame == false)
                new Title().Show();
        }
    }
}
