using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        int y;
        int x;
        int z;

        Thread t;
        Thread b;
        Thread c;
     
 

        public Form1()
        {
            InitializeComponent();
            t = new Thread(Run);
            t.Start();

            b = new Thread(Run);

            b.Start();

            c = new Thread(Run);
            c.Start();
                                 
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Red, 100, y, 9, 9);

            SolidBrush brushblue = new SolidBrush(Color.Green);
            e.Graphics.FillRectangle(brushblue, x, 50, 15, 15);

            Rectangle rect = new Rectangle(140, z, 20, 20);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush, rect);
            lBrush.Dispose();                                   
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Abort();
            t.Join();

            b.Abort();
            b.Join();

            c.Abort();
            c.Join();

          
        }
        private void Run()
        {
            int dy = 2;
            int dx = y - x;
            y = 1;
            x = 1;
            z = 2;
                   
            while (true)
            {
                for (int i = 0; i < 140; i++)
                {
                    y += dy;
                    Invalidate();
                    Thread.Sleep(10);

                    x += dy;
                    Invalidate();
                    Thread.Sleep(5);

                    
                    z += dx;
                    Invalidate();
                    Thread.Sleep(15);

                   
                }
                dy = -dy;
                dy = +dy;
                dx = -dx;
               
                
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

          
        
    }
}
