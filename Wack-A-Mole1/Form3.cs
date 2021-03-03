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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            Form1 spela = new Form1();
            spela.Show();
            
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            btbInstructions instructions = new btbInstructions();
            instructions.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
