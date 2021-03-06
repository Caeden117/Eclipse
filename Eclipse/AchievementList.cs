﻿using System;
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
    public partial class AchievementList : Form
    {
        public AchievementList()
        {
            InitializeComponent();
        }

        private void AchievementList_Load(object sender, EventArgs e)
        {
            int value = Convert.ToInt32((decimal) achievementProgress.Maximum * Math.Floor((decimal)listBox1.Items.Count / (decimal)Achievements.listOfAchievements.Length));
            foreach (char x in Properties.Settings.Default.achievementList)
            {
                listBox1.Items.Add(Achievements.decodeAchievement(x).name);
            }
            progressText.Text = string.Format("Unlocked {0}/{1} Achievements ({2}%)", listBox1.Items.Count, Achievements.listOfAchievements.Length, value);
            achievementProgress.Maximum = Achievements.listOfAchievements.Length;
            achievementProgress.Value = listBox1.Items.Count;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                achievementName.Text = Achievements.fromName(listBox1.SelectedItem.ToString()).name;
                description.Text = Achievements.fromName(listBox1.SelectedItem.ToString()).description;
            }
            catch (Exception)
            {
                achievementName.Text = "Invalid Achievement";
                description.Text = "This shouldn't happen!";
            }
        }
    }
}
