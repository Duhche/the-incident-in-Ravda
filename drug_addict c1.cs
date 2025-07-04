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
    public partial class drug_addict_c1 : Form
    {
        public drug_addict_c1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bus_stop busStop = new bus_stop();
            busStop.Show();
            this.Hide();
        }
    }
}
