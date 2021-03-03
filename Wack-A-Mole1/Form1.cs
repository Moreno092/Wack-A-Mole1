using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wack_A_Mole1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int locationNum = 0;
        int score = 0;
        int misses = 0;
        bool isHit = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void MoveMole()
        {
            isHit = false;
            Mole.Enabled = true;
            Mole.Image = Properties.Resources.alive; 
          
            
            locationNum = rnd.Next(1, 7);


                switch (locationNum)
                {
                    case 1:
                        Mole.Left = 603;
                        Mole.Top = 185;
                        break;

                    case 2:
                        Mole.Left = 355;
                        Mole.Top = 156;
                        break;

                    case 3:
                        Mole.Left = 93;
                        Mole.Top = 179;
                        break;

                    case 4:
                        Mole.Left = 129;
                        Mole.Top = 242;
                        break;

                    case 5:
                        Mole.Left = 355;
                        Mole.Top = 278;
                        break;

                    case 6:
                        Mole.Left = 577;
                        Mole.Top = 240;
                        break;

                    default:
                        break;


                }
            
        }
        private void getMole(object sender, EventArgs e)
        {
            isHit = true;
           
            Mole.Image = Properties.Resources.dead;
            
           
        }
        private int _TimeLeft = 30;
        

        private void moveMole(object sender, EventArgs e)
        {


            lblHit.Text = "Träff: " + score;
            lblMiss.Text = "Missar: " + misses;

            this.Text = _TimeLeft.ToString();

           
                timer1.Start();
                _TimeLeft--;
           

            if (isHit == false)
            {
                misses++;
                
            }
            else if (isHit == true)
            {
                score++;
            }
            
            if (misses == 5)
            {
                timer1.Stop();
                Mole.Enabled = false;
                MessageBox.Show("Tyvärr du förlora! Kanske dags att börja öva mer");
            }
            else if (_TimeLeft == 0)
            {
                timer1.Stop();
                Mole.Enabled = false;
                MessageBox.Show("Tiden är slut! Du fick: " + score + " Poäng");
            }
            
            MoveMole();
        }

   

    }
    
}
