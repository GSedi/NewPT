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
        int x = 1;
        int y = 30;
        int x2 = 1;
        int y2 = 30;
        int x3 = 34;
        int y3 = 78;
        int dx = 1;
        int dy = 1;
        int dx2 = 1;
        int dy2 = 1;
        int dx3 = 1;
        int dy3 = 1;

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
            Move();
            Refresh();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // g.FillRectangle(brush, 0, 0, 400, 300);
            g.FillEllipse(br, x, y, 40, 40);
            g.FillEllipse(br, 300-x2, 200-y2, 40, 40);
            g.FillEllipse(br, x3+40, y3-20, 40, 40);

          
        }

        private void Move()
        {
            if (x <= 0 || x >= 300 || x == x2 || x ==x3) dx *= -1;

            if (y <= 0 || y >= 200 || y == y2 || y == y3) dy *= -1;
            x += dx;
            y += dy;

            if (x2 <= 0 || x2 >= 300 || x2 == x || x2 ==x3) dx2 *= -1;

            if (y2 <= 0 || y2 >= 200 || y2 == y || y2 == y3) dy2 *= -1;
            x2 += dx2;
            y2 += dy2;

            if (x3 <= 0 || x3 >= 300 || x3 == x || x3 == x2) dx3 *= -1;

            if (y3 <= 0 || y3 >= 200 || y3 == x || y3 == y2) dy3 *= -1;
            x3 += dx3;
            y3 += dy3;


        }
    }
}
