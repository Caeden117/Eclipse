using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclipse
{
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            foreach (string file in Directory.EnumerateFiles(folder))
            {
                if (file.Split('\\').Last().Split('.').Last() == "ecst") //If the file extension is .ecst
                    existingStorage.Items.Add(file.Split('\\').Last().Split('.').First());
            }
        }

        private void existingStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            float weight = 0;
            float weightMax = new Items().find(existingStorage.SelectedItem.ToString().Split('#').First()).amount.First();
            refreshItems();
            foreach(string item in storageItems.Items)
            {
                weight += new Items().find(item).weight;
            }
            weightText.Text = "Weight: " + weight + "/" + weightMax;
            progressBar1.Value = Convert.ToInt32(progressBar1.Maximum * (weight / weightMax));
        }

        public void recompileStorage()
        {
            groupBox1.Enabled = false;
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            using (StreamWriter fs = new StreamWriter(File.Create(Path.Combine(folder, existingStorage.SelectedItem.ToString() + ".ecst"))))
            {
                foreach (string item in storageItems.Items)
                {
                    fs.WriteLine(item);
                }
            }
            refreshItems();
        }

        public void refreshItems()
        {
            storageItems.Items.Clear();
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            foreach (string item in File.ReadAllLines(Path.Combine(folder, existingStorage.SelectedItem.ToString() + ".ecst")))
            {
                storageItems.Items.Add(item);
            }
        }

        private void storageItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (storageItems.SelectedIndex >= 0)
                groupBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to discard this item?", "Eclipse - Discard Item?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                storageItems.Items.Remove(storageItems.SelectedItem.ToString());
                recompileStorage();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to transfer this item?", "Eclipse - Transfer Item?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new MoveItem(storageItems.SelectedItem.ToString()).Show();
                storageItems.Items.Remove(storageItems.SelectedItem.ToString());
                recompileStorage();
            }
        }
    }
}
