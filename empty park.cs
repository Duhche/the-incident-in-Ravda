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
    public partial class empty_park : Form
    {
        public empty_park()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drug_addict_enc addict_Enc = new drug_addict_enc();
            addict_Enc.Show();
            this.Hide();
        }
    }
}
