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
    public partial class basement : Form
    {
        public basement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basemant_ending c1 = new basemant_ending();
            c1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            the_1_encounter enc1 = new the_1_encounter();
            enc1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
