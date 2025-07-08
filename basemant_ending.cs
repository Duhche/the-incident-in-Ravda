using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static the_incident_in_Ravda.achivement_c;

namespace the_incident_in_Ravda
{
    public partial class basemant_ending : Form
    {
        public basemant_ending()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            burried_in_basement_end end1 = new burried_in_basement_end();
            end1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            basement_door door = new basement_door();
            door.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text1_Click(object sender, EventArgs e)
        {

        }
    }
}
