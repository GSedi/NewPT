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

namespace Watches
{
    public partial class Form1 : Form
    {
        Graphics g;
        
        Pen pen = new Pen(Color.Red, 5);
        Pen pen2 = new Pen(Color.Blue, 5);
        SolidBrush brush = new SolidBrush(Color.BlueViolet);
        static double x=300;
        static double y=150;
        static double x2 = 300;
        static double y2 = 150;
        int i = 1;

        int deg = 270;
        int deg2 = 270;

        

        double dx;
        double dy;
        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();

            timer1.Enabled = true;
            timer1.Interval = 1000;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            dx = 150 * Math.Cos(deg * Math.PI / 180);
            dy = 150 * Math.Sin((deg * Math.PI) / 180);
            x =300 + dx;

            y =300 + dy;
            deg += 6;

            if(deg == 360)
            {
                deg = 0;

            }
            if(deg == 270)
            {
                deg2 += 6;

                if (deg2== 360)
                {
                    deg2 = 0;

                }
                double dx2 = 150 * Math.Cos(deg2 * Math.PI / 180);
                double dy2 = 150 * Math.Sin((deg2 * Math.PI) / 180);
                x2 = 300 + dx2;

                y2 = 300 + dy2;

            }

            
            

            Refresh();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //g.FillRectangle(back, 0, 0, Width, Height);

            

            g.DrawLine(pen, 300, 300, float.Parse(x.ToString()), float.Parse(y.ToString()));
            

            g.DrawEllipse(pen, 150, 150, 300, 300);
            

            g.DrawLine(pen2, 300, 300, float.Parse(x2.ToString()), float.Parse(y2.ToString()));
            g.FillEllipse(new SolidBrush(Color.Black), 275, 275, 50, 50);

            Font f = new Font(FontFamily.GenericSerif, 30);
            g.DrawString("12", f, brush, 275, 100);
            g.DrawString("1", f, brush, 370, 130);
            g.DrawString("2", f, brush, 440, 200);
            g.DrawString("3", f, brush, 450, 275);
            g.DrawString("hello!", f, brush, 10, 10);
            g.DrawString("5", f, brush, 10, 10);
            g.DrawString("6", f, brush, 290, 450);
            g.DrawString("hello!", f, brush, 10, 10);
            g.DrawString("hello!", f, brush, 10, 10);
            g.DrawString("9", f, brush, 120, 275);
            g.DrawString("hello!", f, brush, 10, 10);
            g.DrawString("hello!", f, brush, 10, 10);
            g.DrawString("hello!", f, brush, 10, 10);



        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }
    }
}
