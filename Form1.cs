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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void start(object sender, EventArgs e)
        {
            basement Basement = new basement();

            Basement.Show();

            this.Hide();
        }

        private void quit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
