using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static the_incident_in_Ravda.achivement_c;

namespace the_incident_in_Ravda
{
    public partial class achivements : Form
    {

    
        public achivements()
        {
            InitializeComponent();
            LoadAchievements();
        }
        private void LoadAchievements()
        {
            listBox1.Items.Clear();
            var achievements = achivement_c.GetAll();
            foreach (var achievement in achievements)
            {
                listBox1.Items.Add($"{achievement.Key}: {(achievement.Value ? "Unlocked" : "Locked")}");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection change if needed
        }
    }
}
