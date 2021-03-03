
namespace Wack_A_Mole1
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Wack_A_Mole1.Properties.Resources.alive;
            this.pictureBox1.Location = new System.Drawing.Point(190, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.BackColor = System.Drawing.Color.Lime;
            this.btnLoadGame.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.Location = new System.Drawing.Point(122, 91);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(231, 71);
            this.btnLoadGame.TabIndex = 1;
            this.btnLoadGame.Text = "Spela";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.Yellow;
            this.btnInstructions.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.Location = new System.Drawing.Point(122, 186);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(231, 71);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.Text = "Instruktioner";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(122, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(231, 71);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Avsluta";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wack A Mole";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wack_A_Mole1.Properties.Resources.ground;
            this.ClientSize = new System.Drawing.Size(464, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}