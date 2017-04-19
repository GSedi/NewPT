using NAsteroids.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAsteroids
{
    public partial class Form1 : Form
    {
        SpaceShip ship;
        Stars star = new Stars();
        Bullet bul;
        Gun gun;
        Asteroids asters = new Asteroids();

        Graphics g;
        SolidBrush blue;
        SolidBrush yellow;
        SolidBrush red;
        SolidBrush white;
        SolidBrush green;

        Point point;

        int x;
        int y;

        int x1 = 500;
        int y1 = 300;

        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();

            blue = new SolidBrush(Color.Blue);
            yellow = new SolidBrush(Color.Yellow);
            red = new SolidBrush(Color.Red);
            white = new SolidBrush(Color.White);
            green = new SolidBrush(Color.Green);

            timer1.Enabled = true;
            timer1.Interval = 10;
            timer2.Enabled = true;
            timer2.Interval = 1;
            timer2.Enabled = false;
            timer2.Interval = 1000;
            //draw.Space(0, 0, this.Width, this.Height);


            // ship = new SpaceShip(492, 325);
            star.Draw(x1-450, y1-190);
            star.Draw(x1-100, y1-240);
            star.Draw(x1+150, y1-200);
            star.Draw(x1+380, y1-25);
            star.Draw(x1+270, y1+100);
            star.Draw(x1+364, y1+270);
            star.Draw(x1-120, y1+200);
            star.Draw(x1-430, y1+210);

             
            bul = new Bullet();
            
            gun = new Gun(432, 325);
            
            asters.Draw(180, 200);
            asters.Draw(220, 450);
            asters.Draw(800, 170);
            asters.Draw(610, 510);
            
    
            label1.Text = "Level: 1 Score: 200  Live: ***";

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(blue, 0, 0, Width, Height);

           // g.FillPath(yellow, ship.path1);

            g.FillPath(white, star.path2);
            
           
            g.FillEllipse(green, x - 5, y - 13, 10, 26);
            g.FillEllipse(green, x - 13, y - 5, 26, 10);
            
            g.FillPath(red, asters.path6);
            g.FillPath(red, asters.path7);

            g.FillPath(green, bul.path3);
            g.FillPath(green, bul.path4);

            g.FillPath(green, gun.path5);


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
                point = new Point(e.X, e.Y);
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            gun = new Gun(point.X, point.Y);

            x1++;
           y1++;


            Refresh();
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
          // point = new Point(e.X, e.Y);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = new Point(e.X, e.Y);
                x = point.X;
                y = point.Y;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            
            // bul = new Bullet();
            //bul.Draw(x, y);
            
            y--;

           
            
             Refresh();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //Refresh();
        }
    }
}
