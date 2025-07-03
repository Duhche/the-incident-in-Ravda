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
    public partial class broken_door : Form
    {
        public broken_door()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            the_1_encounter enc1 = new the_1_encounter();
            enc1.Show();
            this.Hide();
        }
    }
}
