﻿namespace the_incident_in_Ravda
{
    partial class the_1_encounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(the_1_encounter));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.choice1 = new System.Windows.Forms.Button();
            this.choice2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::the_incident_in_Ravda.Properties.Resources.stranger1_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(329, 245);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 453);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Chiller", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(275, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "you encounter a stranger who offers his help.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // choice1
            // 
            this.choice1.BackColor = System.Drawing.Color.Black;
            this.choice1.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1.ForeColor = System.Drawing.Color.Red;
            this.choice1.Location = new System.Drawing.Point(197, 178);
            this.choice1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(133, 63);
            this.choice1.TabIndex = 2;
            this.choice1.Text = "go with him";
            this.choice1.UseVisualStyleBackColor = false;
            this.choice1.Click += new System.EventHandler(this.choice1_Click);
            // 
            // choice2
            // 
            this.choice2.BackColor = System.Drawing.Color.Black;
            this.choice2.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2.ForeColor = System.Drawing.Color.Red;
            this.choice2.Location = new System.Drawing.Point(649, 181);
            this.choice2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(120, 60);
            this.choice2.TabIndex = 3;
            this.choice2.Text = "ignore him";
            this.choice2.UseVisualStyleBackColor = false;
            this.choice2.Click += new System.EventHandler(this.choice2_Click);
            // 
            // the_1_encounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::the_incident_in_Ravda.Properties.Resources.street;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 756);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "the_1_encounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Ravda Incedent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choice1;
        private System.Windows.Forms.Button choice2;
    }
}