using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcanTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 5, yerY = 5, can = 3;

        private void Sekme()
        { 
            if(ball.Top <= label2.Bottom)
            {
                yerY = yerY * -1;
            }
            if (ball.Bottom >= kontrol.Top && ball.Left >= kontrol.Left && ball.Right <= kontrol.Right)
            {
                yerY = yerY * -1;
            }
            else if (ball.Right >= label4.Left)
            {
                yerX = yerX * -1;
            }else if (ball.Left <= label1.Right)
            {
                yerX = yerX * -1;
            }
        }

        private void YanmaOlayı(object sender, EventArgs e)
        {
            if (ball.Top >= label4.Bottom)
            {
                if (can > 0)
                {

                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yandınız kalan can :" + can.ToString());
                    Form1_Load(sender, e);
                    
                }
              
                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun Bitti","", MessageBoxButtons.OK);
                }
            }
            label2.Text = can.ToString();
        }
        private void TopBasa()
        {
            ball.Location = new Point(351, 238);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            TopBasa();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Sekme();
            YanmaOlayı(sender, e);
            ball.Location = new Point(ball.Location.X + yerX, ball.Location.Y + yerY);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left = e.X;
            
            
        }
    }
}
