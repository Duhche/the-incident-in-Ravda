namespace the_incident_in_Ravda
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Black;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Chiller", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Red;
            this.Start.Location = new System.Drawing.Point(227, 310);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(321, 64);
            this.Start.TabIndex = 1;
            this.Start.Text = "enter Ravda";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.start);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Black;
            this.title.Font = new System.Drawing.Font("Chiller", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(153, 67);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(466, 86);
            this.title.TabIndex = 2;
            this.title.Text = "The Ravda Incident";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Black;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Chiller", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.Color.Red;
            this.Quit.Location = new System.Drawing.Point(253, 380);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(262, 61);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.quit);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::the_incident_in_Ravda.Properties.Resources.welcome_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Start);
            this.DoubleBuffered = true;
            this.Name = "mainMenu";
            this.Text = "The Ravda Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button Quit;
    }
}

