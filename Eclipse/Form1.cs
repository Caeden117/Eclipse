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

namespace Eclipse
{
    public partial class Title : Form
    {
        
        public Title()
        {
            InitializeComponent();
        }

        private void betaTimer_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isBeta == true)
            {
                label3.Visible = !label3.Visible;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Name != "" || Properties.Settings.Default.Clan != "")
            {
                DialogResult saveGame = MessageBox.Show("Eclipse has detected a game in progress. Would you like to save that game as a file before starting a new game?", "Eclipse - Game Detected", MessageBoxButtons.YesNoCancel);
                if (saveGame == DialogResult.No)
                {
                    Properties.Settings.Default.Reset();
                    Hide();
                    var charCreation = new CharacterCreation();
                    charCreation.Show();
                }
                else if (saveGame == DialogResult.Yes)
                {
                    //Load save box.
                    Console console = new Console();
                    if (console.saveGame())
                    {
                        Properties.Settings.Default.Reset();
                        var charCreation = new CharacterCreation();
                        charCreation.Show();
                    }
                }
            }
            else
            {
                Properties.Settings.Default.Reset();
                var charCreation = new CharacterCreation();
                Hide();
                charCreation.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console console = new Console();
            if (console.loadGame())
            {
                console.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Name != "" || Properties.Settings.Default.Clan != "")
            {
                Console console = new Console();
                console.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Eclipse has detected no active game running. Please start a new game, or load from a file.", "Eclipse - Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
