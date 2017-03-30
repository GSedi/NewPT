using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_1
{
   
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkBlue, 900000);
           Pen pen2 = new Pen(Color.Black);
            /* g.DrawLine(pen, 0, 0, 10000, 10000);
             g.DrawLine(pen, 0, 0, 200, 200);
             g.DrawLine(pen2, 0, 0, 1000, 0);
             g.DrawLine(pen2, 1000, 1000, 0, 1000);
             g.DrawLine(pen2, 1000, 1000, 1000, 0);
             g.DrawLine(pen2, 0, 0, 0, 1000);
             */
            //g.FillRectangle(pen2, 0, 0, 790, 360);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, 0, 0, 790, 360);
            SolidBrush brush2 = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(brush2, 20, 20, 745, 315);
          
            SolidBrush br = new SolidBrush(Color.White);
            g.FillEllipse(br, 55, 35, 20, 20);
            g.FillEllipse(br, 455, 135, 20, 20);
            g.FillEllipse(br, 355,235, 20, 20);
            g.FillEllipse(br, 655, 195, 20, 20);
            g.FillEllipse(br, 237, 61, 20, 20);
            g.FillEllipse(br, 111, 284, 20, 20);
            g.FillEllipse(br, 543, 73, 20, 20);




        }
    }
}
