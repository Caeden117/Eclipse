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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.tutorial;
            checkBox2.Checked = Properties.Settings.Default.sortItems;
            checkBox3.Checked = Properties.Settings.Default.debugMode;
            checkBox4.Checked = Properties.Settings.Default.godMode;
            if (Properties.Settings.Default.Name != "Caeden117" && Properties.Settings.Default.Clan != "Eclipse")
                groupBox1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.tutorial = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sortItems = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.debugMode = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.godMode = checkBox4.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            if (item.isAlso(item.find(textBox1.Text), Items.empty))
            {
                MessageBox.Show("It cannot be done.");
            }
            else
            {
                Properties.Settings.Default.itemInQueue = textBox1.Text;
            }
            textBox1.Clear();
        }
    }
}
