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
    public partial class bus_stop_pt3 : Form
    {
        public bus_stop_pt3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ending6 end6 = new ending6();
            end6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ending_7 end7 = new ending_7();
            end7.Show();
            this.Hide();
        }
    }
}
