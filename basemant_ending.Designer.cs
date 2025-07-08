namespace the_incident_in_Ravda
{
    partial class basemant_ending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basemant_ending));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.text1 = new System.Windows.Forms.Label();
            this.choice1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::the_incident_in_Ravda.Properties.Resources.basement_killer_with_knife;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(258, 194);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 360);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.Black;
            this.text1.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.ForeColor = System.Drawing.Color.Red;
            this.text1.Location = new System.Drawing.Point(525, 151);
            this.text1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(299, 80);
            this.text1.TabIndex = 2;
            this.text1.Text = "a stragne figure appears from the shadows with a knife ";
            this.text1.Click += new System.EventHandler(this.text1_Click);
            // 
            // choice1
            // 
            this.choice1.BackColor = System.Drawing.Color.Black;
            this.choice1.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1.ForeColor = System.Drawing.Color.Red;
            this.choice1.Location = new System.Drawing.Point(586, 307);
            this.choice1.Margin = new System.Windows.Forms.Padding(2);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(170, 70);
            this.choice1.TabIndex = 3;
            this.choice1.Text = "fight him!";
            this.choice1.UseVisualStyleBackColor = false;
            this.choice1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(586, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "try to run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // basemant_ending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::the_incident_in_Ravda.Properties.Resources.basement;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 756);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "basemant_ending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "basemant_ending";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Button choice1;
        private System.Windows.Forms.Button button1;
    }
}