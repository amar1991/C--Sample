using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brushblue = new SolidBrush(Color.Green);
            e.Graphics.FillRectangle(brushblue, 20, 20, 100, 100);
            brushblue.Dispose();


            Rectangle rect = new Rectangle(140, 20, 100, 100);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow,LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush, rect);
            lBrush.Dispose();

            Pen pn = new Pen(Color.Blue);
            Point pt1 = new Point(180, 140);
            Point pt2 = new Point(250, 250);
            g.DrawLine(pn, pt1, pt2);

            Rectangle rect1 = new Rectangle(20, 150, 120, 100);
            g.DrawEllipse(pn, rect1);
        }
                       
        
    }
}
