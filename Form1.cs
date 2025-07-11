﻿using System;
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
            Background_soundP.Start();
        }

        private void start(object sender, EventArgs e)
        {
            intro introductionForm = new intro();
            introductionForm.Show();
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
                titleClickCount = 0; 
                secret_ending secretEnding = new secret_ending();
                secretEnding.Show();
                this.Hide();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            achivements achivementsForm = new achivements();
            achivementsForm.Show();
            this.Hide();
        }
    }
}
