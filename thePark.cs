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
    public partial class thePark : Form
    {
        public thePark()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ending4 end4 = new ending4();
            end4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            park_pt2 pt2 = new park_pt2();
            pt2.Show();
            this.Hide();
        }
    }
}
