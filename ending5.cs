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
    public partial class ending5 : Form
    {
        public ending5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!achivement_c.IsUnlocked("Overdose"))
            {
                achivement_c.Unlock("Overdose");
            }
            mainMenu menu = new mainMenu();
            menu.Show();
            this.Hide();
        }
    }
}
