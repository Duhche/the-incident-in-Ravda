using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_incident_in_Ravda
{
    public partial class mainMenu : Form
    {
        private int titleClickCount = 0;
        public mainMenu()
        {
            InitializeComponent();
            title.Click += title_Click;
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
            titleClickCount++;

            if (titleClickCount == 5)
            {
                titleClickCount = 0; // reset if needed
                secret_ending secretEnding = new secret_ending();
                secretEnding.Show();
                this.Hide();
            }
        }
    }
}
