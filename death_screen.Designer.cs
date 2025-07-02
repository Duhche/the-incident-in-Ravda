namespace the_incident_in_Ravda
{
    partial class death_screen
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
            this.retry = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // retry
            // 
            this.retry.BackColor = System.Drawing.Color.Transparent;
            this.retry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retry.Font = new System.Drawing.Font("Chiller", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retry.ForeColor = System.Drawing.Color.Red;
            this.retry.Location = new System.Drawing.Point(144, 335);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(129, 75);
            this.retry.TabIndex = 1;
            this.retry.Text = "Retry";
            this.retry.UseVisualStyleBackColor = false;
            this.retry.Click += new System.EventHandler(this.retry_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Transparent;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("Chiller", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.Color.Red;
            this.quit.Location = new System.Drawing.Point(497, 335);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(129, 75);
            this.quit.TabIndex = 2;
            this.quit.Text = "quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // death_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::the_incident_in_Ravda.Properties.Resources.you_died;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.retry);
            this.Name = "death_screen";
            this.Text = "death_screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retry;
        private System.Windows.Forms.Button quit;
    }
}