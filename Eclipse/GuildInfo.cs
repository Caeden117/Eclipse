using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Eclipse
{
    public partial class GuildInfo : Form
    {
        public int guildSize;
        public string[] disposition = new string[] { "Rebellious", "Hatred", "Distaste", "Neutral", "Friendly", "Faithful", "Loyal" };
        public Color[] dispositionColors = new Color[] { Color.DarkRed, Color.Red, Color.OrangeRed, Color.Black, Color.LightGreen, Color.Lime, Color.DarkGreen};
        public GuildInfo()
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            if (Directory.Exists(folder))
            {
                foreach (string file in Directory.EnumerateFiles(folder))
                {
                    if (file.Split('\\').Last().Split('.').Last() == "ecm") //If the file extension is .ecm
                        guildSize++;
                }
            }
            InitializeComponent();
        }

        private void GuildInfo_Load(object sender, EventArgs e)
        {
            clanName.Text = Properties.Settings.Default.Clan;
            population.Text = string.Format("Population: {0}/{1}", guildSize, Math.Floor((decimal)(Properties.Settings.Default.Level - 5) / 4));
            if (guildSize < Math.Floor((decimal)(Properties.Settings.Default.Level - 5) / 4))
                populationBar.Value = Convert.ToInt32(populationBar.Maximum * (guildSize / Math.Floor((decimal)(Properties.Settings.Default.Level - 5) / 4)));
            else
                populationBar.Value = populationBar.Maximum;
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            foreach (string file in Directory.EnumerateFiles(folder))
            {
                if (file.Split('\\').Last().Split('.').Last() == "ecm") //If the file extension is .ecm
                    memberList.Items.Add(file.Split('\\').Last().Split('.').First());
            }
        }

        private void memberList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            string[] file = File.ReadAllLines(Path.Combine(folder, memberList.SelectedItem + ".ecm"));
            memberHealth.Text = string.Format("Health: {0}/{1}", file[3], file[2]);
            Strength.Text = string.Format("Strength: {0}", file[4]);
            Dexterity.Text = string.Format("Dexterity: {0}", file[5]);
            Agility.Text = string.Format("Agility: {0}", file[6]);
            Constitution.Text = string.Format("Constitution: {0}", file[7]);
            Disposition.Text = string.Format("Dispostion: {0} ({1})", disposition[Convert.ToInt32(Math.Floor((decimal.Parse(file[9]) / 5) + 3))], file[9]);
            Disposition.ForeColor = dispositionColors[Convert.ToInt32(Math.Floor((decimal.Parse(file[9]) / 5) + 3))];
            Level.Text = string.Format("Level: {0}", file[8]);
        }
    }
}
