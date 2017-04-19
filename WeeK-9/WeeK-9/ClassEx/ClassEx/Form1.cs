using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassEx
{
    public partial class Form1 : Form
    {

        Draw draw = new Draw();
        Graphics g;
        SolidBrush br1;
        SolidBrush br2;
        SolidBrush br3;
        int x = 200;
        int y = 120;
        int dx = 1;
        int dy = 1;


        private void timer1_Tick(object sender, EventArgs e)
        {
            //x++;
            //y++;

            if (x - 50 <= 1 || x + 100 >= 540) dx *= -1;
            if (y <= 0 || y + 80 >= 300) dy *= -1;

            x += dx;
            y += dy;


            Refresh();

            draw.path1.Reset();
            draw.path2.Reset();
            draw.path3.Reset();
        }

        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();
            br1 = new SolidBrush(Color.Blue);
            br2 = new SolidBrush(Color.Red);
            br3 = new SolidBrush(Color.Black);

            //draw.Kuzov(x, y);

            timer1.Enabled = true;
            timer1.Interval = 10;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            draw.Kuzov(x, y);
           // draw.Kuzov(x, y - 60);
            //draw.Kuzov(x - 20, y + 60);
            g.FillPath(br1, draw.path1);
            g.FillPath(br2, draw.path2);
            g.FillPath(br3, draw.path3);
        }

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            y++;

            Refresh();
        }
        */
    }
}
