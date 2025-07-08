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
    public partial class bus_stop : Form
    {
        public bus_stop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bus_stop_pt2 pt2 = new bus_stop_pt2();
            pt2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
