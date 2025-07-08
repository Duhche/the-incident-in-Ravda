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
    public partial class forest : Form
    {
        public forest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Strangers_House house = new Strangers_House();
            house.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ending_3 end3 = new ending_3();
            end3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
