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
        public GuildInfo()
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            if (Directory.Exists(folder))
            {
                guildSize = Directory.EnumerateFiles(folder).Count();
            }
            InitializeComponent();
        }

        private void GuildInfo_Load(object sender, EventArgs e)
        {
            clanName.Text = Properties.Settings.Default.Clan;
            population.Text = string.Format("Population: {0}/{1}", guildSize, Math.Floor((decimal)(Properties.Settings.Default.Level - 5) / 4));
            if (guildSize > Math.Floor((decimal)(Properties.Settings.Default.Level - 5) / 4))
                populationBar.Value = Convert.ToInt32(populationBar.Maximum * (guildSize / Math.Floor((decimal)(Properties.Settings.Default.Level - 5) / 4)));
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            foreach (string file in Directory.EnumerateFiles(folder))
            {
                memberList.Items.Add(file.Split('\\').Last().Split('.').First());
            }
        }
    }
}
