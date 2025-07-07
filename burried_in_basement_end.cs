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
    public partial class burried_in_basement_end : Form
    {
        public burried_in_basement_end()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!achivement_c.IsUnlocked("Buried in the basement"))
            {
                achivement_c.Unlock("Buried in the basement");
            }
            mainMenu menu = new mainMenu();
            menu.Show();
            this.Hide();
        }
    }
}
