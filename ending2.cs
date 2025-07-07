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
    public partial class ending2 : Form
    {
        public ending2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!achivement_c.IsUnlocked("The good stranger"))
            {
                achivement_c.Unlock("The good stranger");
            }
            mainMenu menu = new mainMenu();
            menu.Show();
            this.Hide();
        }
    }
}
