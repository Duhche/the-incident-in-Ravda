using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_incident_in_Ravda
{
    public partial class the_1_encounter : Form
    {
        public the_1_encounter()
        {
            InitializeComponent();
        }

        private void choice1_Click(object sender, EventArgs e)
        {
            forest Forest = new forest();
            Forest.Show();
            this.Hide();
        }

        private void choice2_Click(object sender, EventArgs e)
        {
            map_of_ravda Map = new map_of_ravda();
            Map.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
