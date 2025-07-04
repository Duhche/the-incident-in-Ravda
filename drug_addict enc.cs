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
    public partial class drug_addict_enc : Form
    {
        public drug_addict_enc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ending5 end5 = new ending5();
            end5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drug_addict_c1 c1 = new drug_addict_c1();
            c1.Show();
            this.Hide();
        }
    }
}
