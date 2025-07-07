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
    public partial class ending_3 : Form
    {
        public ending_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!achivement_c.IsUnlocked("Forever lost"))
            {
                achivement_c.Unlock("Forever lost");
            }
            mainMenu menu = new mainMenu();
            menu.Show();
            this.Hide();
        }
    }
}
