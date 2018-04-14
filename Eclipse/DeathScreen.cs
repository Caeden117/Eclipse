using System;
using System.Windows.Forms;

namespace Eclipse
{
    public partial class DeathScreen : Form
    {
        public DeathScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeathScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Title().Show();
        }
    }
}
