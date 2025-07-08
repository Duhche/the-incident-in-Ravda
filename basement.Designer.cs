namespace the_incident_in_Ravda
{
    partial class basement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basement));
            this.label1 = new System.Windows.Forms.Label();
            this.choice1 = new System.Windows.Forms.Button();
            this.choice2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Chiller", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(211, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "You wake up in a strange place you are not sure where are you what will you do?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // choice1
            // 
            this.choice1.BackColor = System.Drawing.Color.Black;
            this.choice1.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1.ForeColor = System.Drawing.Color.Red;
            this.choice1.Location = new System.Drawing.Point(243, 458);
            this.choice1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(115, 81);
            this.choice1.TabIndex = 1;
            this.choice1.Text = "wait for someone";
            this.choice1.UseVisualStyleBackColor = false;
            this.choice1.Click += new System.EventHandler(this.button1_Click);
            // 
            // choice2
            // 
            this.choice2.BackColor = System.Drawing.Color.Black;
            this.choice2.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2.ForeColor = System.Drawing.Color.Red;
            this.choice2.Location = new System.Drawing.Point(656, 459);
            this.choice2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(115, 80);
            this.choice2.TabIndex = 2;
            this.choice2.Text = "go out";
            this.choice2.UseVisualStyleBackColor = false;
            this.choice2.Click += new System.EventHandler(this.button2_Click);
            // 
            // basement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::the_incident_in_Ravda.Properties.Resources.basement;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 756);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "basement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Ravda Incident";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choice1;
        private System.Windows.Forms.Button choice2;
    }
}