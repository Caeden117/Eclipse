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
                if(MessageBox.Show("Eclipse has detected a game in progress. Would you like to save that game as a file before starting a new game?", "Eclipse - Game Detected", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Properties.Settings.Default.Reset();
                    Close();
                    var charCreation = new CharacterCreation();
                    charCreation.Show();
                }
                else
                {
                    //Load save box. Will do later.
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
    }
}
