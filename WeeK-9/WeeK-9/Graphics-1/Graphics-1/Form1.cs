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

namespace Graphics_1
{
   
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath path;
        DrawClass draw;
        public Form1()
        
        {
            InitializeComponent();
            g = this.CreateGraphics();
            // path = new GraphicsPath();
            draw = new DrawClass(120, 120);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkBlue, 900000);
           Pen pen2 = new Pen(Color.Black);
            
            SolidBrush brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, 0, 0, 790, 360);
            SolidBrush brush2 = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(brush2, 20, 20, 745, 315);
          
            SolidBrush br = new SolidBrush(Color.White);
            g.FillEllipse(br, 55, 35, 20, 20);
            g.FillEllipse(br, 670, 135, 20, 20);
            g.FillEllipse(br, 255,235, 20, 20);
            g.FillEllipse(br, 655, 250, 20, 20);
            g.FillEllipse(br, 237, 61, 20, 20);
            g.FillEllipse(br, 111, 284, 20, 20);
            g.FillEllipse(br, 600, 163, 20, 20);
            g.FillEllipse(br, 513, 73, 20, 20);


            Pen pen3 = new Pen(Color.Yellow);
            Point[] points =
            {
                new Point(420, 130),
                new Point(480, 170),
                new Point(480, 210),
                new Point(420, 250),
                new Point(360, 210),
                new Point(360, 170),
                new Point(420, 130)
            };
            
            SolidBrush br2 = new SolidBrush(Color.Yellow);
            g.FillPolygon(br2, points);

            Point[] p2 = 
            {
                new Point(420, 150),
                new Point(460, 170),
                new Point(440, 170),
                new Point(440, 220),
                new Point(400, 220),
                new Point(400, 170),
                new Point(380, 170),
                new Point(420, 150)
            };

            SolidBrush br3 = new SolidBrush(Color.Green);
            g.FillPolygon(br3, p2);


            Point[] p3 =
            {
                new Point(430, 100),
                new Point(434, 111),
                new Point(445, 115),
                new Point(435, 119),
                new Point(430, 130),
                new Point(425, 119),
                new Point(415, 115),
                new Point(426, 111),
                new Point(430, 100)
            };

            g.FillPolygon(br3, p3);

            SolidBrush br4 = new SolidBrush(Color.Red);
            g.FillPath(br4, draw.path);
            /*Point[] p4 =
            {
               new Point(120, 120),
                new Point(123, 125),
                new Point(130, 125),
                new Point(126, 131),
                new Point(130, 137),
                new Point(123, 137),
                new Point(120, 142),
                new Point(117, 137),
                new Point(110, 137),
                new Point(114, 131),
                new Point(110, 125),
                new Point(117, 125),
                new Point(120, 120)
            };

            SolidBrush br4 = new SolidBrush(Color.Red);
            //g.FillPolygon(br4, p4);

            path.AddPolygon(p4);
            g.FillPath(br4, path);
            */
            
        }
    }
}
                /*new Point(120, 120),
                new Point(123, 125),
                new Point(130, 125),
                new Point(126, 131),
                new Point(130, 137),
                new Point(123, 137),
                new Point(120, 142),
                new Point(117, 137),
                new Point(110, 137),
                new Point(114, 131),
                new Point(110, 125),
                new Point(117, 125),
                new Point(120, 120)
                */