using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int dx;
        int da;
        
        public Form1()
        {
            InitializeComponent();
            dx = 4;
            da = 4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int newX, newY;
            newX = picBall.Location.X + dx;
            newY = picBall.Location.Y + da;
            if (newX > this.Width - picBall.Width)
            {
                dx += -dx;
                da -= da;
                
            }
            if (newX < 0)
            {
                dx += -dx;
                da -= da;
            }
            if (picBall.Bounds.IntersectsWith(picTarget.Bounds))
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.White;
            }
            picBall.Location = new Point(newX, newY);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               
            this.timer1.Start();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {                   
            timer1.Stop();
        }
    }
}
