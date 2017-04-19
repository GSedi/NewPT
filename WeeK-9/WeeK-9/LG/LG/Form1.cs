using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LG
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush;
        SolidBrush br;
        //List<Point> point;
        /*int x = 1;
        int y = 30;
        int x2 = 1;
        int y2 = 30;
        int x3 = 34;
        int y3 = 78;*/
        int dx = 1;
        int dy = 1;
        int dx2 = 1;
        int dy2 = 1;
        int dx3 = 1;
        int dy3 = 1;

        Point[] point =
            {
                new Point(1,30),
                new Point(1, 30),
                new Point(34, 78)

            };
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Red);
            br = new SolidBrush(Color.Black);

            timer1.Enabled = true;
            timer1.Interval = 10;

            

            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Mover();
            Refresh();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // g.FillRectangle(brush, 0, 0, 400, 300);
            g.FillEllipse(br, point[0].X, point[0].Y, 40, 40);
            g.FillEllipse(br, 300- point[1].X, 200- point[1].Y, 40, 40);
            g.FillEllipse(br, point[2].X + 40, point[2].Y - 20, 40, 40);

          
        }

        private void Mover()
        {
            /*for(int i=0; i< 2; i++)
            {
                if(point[i] == point[i + 1])
                {
                    dx *= -1;
                    dy *= -1;
                    dx2 *= -1;
                    dy2 *= -1;
                    dx3 *= -1;
                    dy3 *= -1;

                }
            }
            */

            

           
            if (point[0].X <= 0 || point[0].X >= 300||point[0].X == point[1].X|| point[0].X == point[2].X) dx *= -1;

            if (point[0].Y <= 0 || point[0].Y >= 200 || point[0].Y == point[1].Y || point[0].Y == point[2].Y) dy *= -1;
            point[0].X += dx;
            point[0].Y += dy;

            if (point[1].X <= 0 || point[1].X >= 300 || point[1].X == point[0].X || point[1].X == point[2].X) dx2 *= -1;

            if (point[1].Y <= 0 || point[1].Y >= 200 || point[1].Y == point[0].Y || point[1].Y == point[2].Y) dy2 *= -1;
            point[1].X += dx2;
            point[1].Y += dy2;

            if (point[2].X <= 0 || point[2].X >= 300 || point[2].X == point[0].X || point[2].X == point[1].X) dx3 *= -1;

            if (point[2].Y <= 0 || point[2].Y >= 200 || point[2].Y == point[0].Y || point[2].Y == point[1].Y) dy3 *= -1;
            point[2].X += dx3;
            point[2].Y += dy3;

            for(int i = point[0].X; i<=40; i++)
            {
                for (int j = point[0].Y; i <= 40 ; i++)
                {
                    
                }
            }
        }
    }
}
