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
    public partial class basemant_ending : Form
    {
        public basemant_ending()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            death_screen you_died = new death_screen();
            you_died.Show();
            this.Hide();
        }
    }
}
