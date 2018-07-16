using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclipse
{
    public partial class MoveItem : Form
    {
        string itemToMove;
        string previousStorageContainer = "";
        bool closedThroughButton = false;

        public MoveItem(string itemName)
        {
            InitializeComponent();
            itemToMove = itemName;
        }

        public MoveItem(string itemName, string storageContainer)
        {
            InitializeComponent();
            itemToMove = itemName;
            previousStorageContainer = storageContainer;
        }

        private void MoveItem_Load(object sender, EventArgs e)
        {
            movingItem.Text = itemToMove;
            button1.Enabled = false;
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            foreach (string file in Directory.EnumerateFiles(folder))
            {
                int weight = new Items().find(file.Split('\\').Last().Split('.').First().Split('#').First()).amount.First();
                if (file.Split('\\').Last().Split('.').Last() == "ecst")
                { //If the file extension is .ecst
                    float combinedWeight = 0;
                    foreach (string item in File.ReadAllLines(file))
                    {
                        combinedWeight += new Items().find(item).weight;
                    }
                    combinedWeight += new Items().find(itemToMove).weight;
                    if (combinedWeight <= (float)weight)
                        Storage.Items.Add(file.Split('\\').Last().Split('.').First());
                }
            }
            Storage.Items.Add("Inventory");
        }

        private void Storage_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Storage.SelectedItem.ToString() != "Inventory")
            {
                string storage = Storage.SelectedItem.ToString();
                List<string> existingItems = new List<string>();
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
                foreach (string item in File.ReadAllLines(Path.Combine(folder, storage + ".ecst")))
                {
                    existingItems.Add(item);
                }
                existingItems.Add(itemToMove);
                using (StreamWriter fs = new StreamWriter(File.Create(Path.Combine(folder, storage + ".ecst"))))
                {
                    foreach (string item in existingItems)
                    {
                        fs.WriteLine(item);
                    }
                }
            }
            else
            {
                Properties.Settings.Default.itemInQueue = itemToMove;
            }
            closedThroughButton = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (previousStorageContainer == "")
            {
                Properties.Settings.Default.itemInQueue = itemToMove;
            }
            else
            {
                List<string> existingItems = new List<string>();
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
                foreach (string item in File.ReadAllLines(Path.Combine(folder, previousStorageContainer + ".ecst")))
                {
                    existingItems.Add(item);
                }
                existingItems.Add(itemToMove);
                using (StreamWriter fs = new StreamWriter(File.Create(Path.Combine(folder, previousStorageContainer + ".ecst"))))
                {
                    foreach (string item in existingItems)
                    {
                        fs.WriteLine(item);
                    }
                }
            }
            closedThroughButton = true;
            Close();
        }

        private void MoveItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closedThroughButton)
            {
                e.Cancel = true;
                MessageBox.Show("To prevent item loss, please exit this form by using the \"Cancel\" button. This will send the item to your Inventory.", "Eclipse - Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
