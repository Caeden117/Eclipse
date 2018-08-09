using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Eclipse
{
    public partial class GameManager : Form
    {
        public GameManager()
        {
            InitializeComponent();
        }

        private void GameManager_Load(object sender, EventArgs e)
        {
            try
            {
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EclipseGame");
                if (Directory.Exists(folder))
                {
                    foreach (string gameFolder in Directory.EnumerateDirectories(folder))
                    {
                        listBox1.Items.Add(gameFolder.Split('\\').Last());
                    }
                }
                else
                {
                    MessageBox.Show("There are no save games Eclipse could detect. The Game Manager will now close.", "Eclipse - Closing Game Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("A fatal error has occured while loading Eclipse save data. The Game Manager will now close.", "Eclipse - Closing Game Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EclipseGame\\" + listBox1.SelectedItem);
            try
            {
                string[] file = File.ReadAllLines(Path.Combine(folder, "info.ecinfo"));
                lastSaved.Text = "Last Saved:" + file[0];
                lastLocation.Text = "Last Save File Location:\n" + file[1];
            }
            catch (Exception)
            {
                lastSaved.Text = "Last Saved: Never.";
                lastLocation.Text = "Last Save File Location:\nNo previous save file has been found.";
            }
            removeGame.Enabled = true;
        }

        private void removeUnavailable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Removing unavailable games will remove any and ALL games that did NOT have a safe file associated with that game. Do you want to proceed?", "Eclipse - Remove Games?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EclipseGame");
                if (Directory.Exists(folder))
                {
                    foreach (string gameFolder in Directory.EnumerateDirectories(folder))
                    {
                        if (!File.Exists(Path.Combine(gameFolder, "info.ecinfo")))
                            Directory.Delete(gameFolder);
                    }
                }
            }
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will remove ALL games in your Eclipse folder, INCLUDING last known save files, and close the Game Manager. Do you want to continue?", "Eclipse - Remove Games?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EclipseGame");
                if (Directory.Exists(folder))
                {
                    foreach (string gameFolder in Directory.EnumerateDirectories(folder))
                    {
                        if (File.Exists(Path.Combine(gameFolder, "info.ecinfo")))
                        {
                            string[] info = File.ReadAllLines(Path.Combine(folder, "info.ecinfo"));
                            if (File.Exists(info[1]))
                                File.Delete(info[1]);
                        }
                        Directory.Delete(gameFolder);
                    }
                }
            }
            Close();
        }

        private void removeGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will remove the selected game, and attempt to delete the last known save file. Do you want to continue?", "Eclipse - Remove Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EclipseGame\\" + listBox1.SelectedItem);
                if (Directory.Exists(folder))
                {
                    if (!File.Exists(Path.Combine(folder, "info.ecinfo"))) {
                        string[] info = File.ReadAllLines(Path.Combine(folder, "info.ecinfo"));
                        if (File.Exists(info[1]))
                            File.Delete(info[1]);
                    }
                }
                Directory.Delete(folder);
            }
        }
    }
}
