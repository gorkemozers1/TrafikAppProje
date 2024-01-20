using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Görkem Özer 22070370025
namespace trafikapp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left < 800)
                pictureBox1.Left += 10;
            else
                pictureBox1.Left = -250;

        }

        private void BAŞLA_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            timer1.Start();
            timer2.Interval = 2000;
            timer2.Start();
            pictureBox2.Image = ımageList1.Images[0];
        }
        int indis = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (indis < 3)
           
                indis++;
             
            else
                indis = 0;
            pictureBox2.Image = ımageList1.Images[indis];


            if(indis == 0)
            {
                timer1.Stop();

            }
            else
            {
                timer1.Start();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
