﻿
namespace Wack_A_Mole1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblHit = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.Mole = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.BackColor = System.Drawing.Color.Transparent;
            this.lblHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHit.Location = new System.Drawing.Point(12, 9);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(105, 32);
            this.lblHit.TabIndex = 0;
            this.lblHit.Text = "Träffar";
            // 
            // lblMiss
            // 
            this.lblMiss.AutoSize = true;
            this.lblMiss.BackColor = System.Drawing.Color.Transparent;
            this.lblMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiss.Location = new System.Drawing.Point(12, 64);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(104, 32);
            this.lblMiss.TabIndex = 1;
            this.lblMiss.Text = "Missar";
            // 
            // Mole
            // 
            this.Mole.BackColor = System.Drawing.Color.Transparent;
            this.Mole.Image = global::Wack_A_Mole1.Properties.Resources.alive;
            this.Mole.Location = new System.Drawing.Point(350, 152);
            this.Mole.Name = "Mole";
            this.Mole.Size = new System.Drawing.Size(89, 105);
            this.Mole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Mole.TabIndex = 2;
            this.Mole.TabStop = false;
            this.Mole.Click += new System.EventHandler(this.getMole);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.moveMole);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wack_A_Mole1.Properties.Resources.ground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mole);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblHit);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Label lblMiss;
        private System.Windows.Forms.PictureBox Mole;
        private System.Windows.Forms.Timer timer1;
    }
}

