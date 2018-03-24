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

        public CharacterCreation()
        {
            InitializeComponent();
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            richTextBox1.Text += Properties.Settings.Default.Tips[rng.Next(0, Properties.Settings.Default.Tips.Count)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
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
    }
}
