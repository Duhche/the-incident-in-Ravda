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
    public partial class basement_door : Form
    {
        public basement_door()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            burried_in_basement_end end1 = new burried_in_basement_end();
            end1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            broken_door Out = new broken_door();
            Out.Show();
            this.Hide();
        }
    }
}
