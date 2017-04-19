using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid
{
    public partial class Form1 : Form
    {

        Asteroids aster = new Asteroids();
        //Stars star;

        Spaceship ship1 = new Spaceship();
         Spaceship ship;
         Bullet bullet;
         Gun gun;
         
        List<Stars> stars;
        List<Asteroids> asters;
        List<Bullet> buls;

        

        Graphics g;
        SolidBrush black;
        SolidBrush yellow;
        SolidBrush red;
        SolidBrush white;
        SolidBrush green;
        static int c = 1;
        static int sx;
        static int sy;


        //Stars[] t = new Stars[7];
        //Asteroids[] a = new Asteroids[3];


        public Form1()
        {
            
                InitializeComponent();

                g = this.CreateGraphics();

                black = new SolidBrush(Color.Black);
                yellow = new SolidBrush(Color.Yellow);
                red = new SolidBrush(Color.Red);
                white = new SolidBrush(Color.White);
                green = new SolidBrush(Color.Green);


            timer1.Enabled = true;
            timer1.Interval = 100;

            stars = new List<Stars>();
            asters = new List<Asteroids>();
            buls = new List<Bullet>();
           
            //star = new Stars(g, new Point(50, 110));
            //star = new Stars(g, new Point(400, 60));

            Stars s1 = new Stars(g, new Point(50, 110));
            Stars s2 = new Stars(g, new Point(400, 60));
            Stars s3 = new Stars(g, new Point(650, 100));
            Stars s4 = new Stars(g, new Point(880, 275));
            Stars s5 = new Stars(g, new Point(770, 400));
            Stars s6 = new Stars(g, new Point(865, 570));
            Stars s7 = new Stars(g, new Point(380, 500));
            Stars s8 = new Stars(g, new Point(70, 510));

            stars.Add(s1);
            stars.Add(s2);
            stars.Add(s3);
            stars.Add(s4);
            stars.Add(s5);
            stars.Add(s6);
            stars.Add(s7);
            stars.Add(s8);

            Asteroids a1 = new Asteroids(g, new Point(150, 170));
            Asteroids a2 = new Asteroids(g, new Point(190, 420));
            Asteroids a3 = new Asteroids(g, new Point(770, 140));
            Asteroids a4 = new Asteroids(g, new Point(580, 480));
            //Asteroids a5 = new Asteroids(g, new Point(510, 210));
            //Asteroids a6 = new Asteroids(g, new Point(215, 310));
            //Asteroids a7 = new Asteroids(g, new Point(325, 10));

            asters.Add(a1);
            asters.Add(a2);
            asters.Add(a3);
            asters.Add(a4);
            //asters.Add(a5);
            //asters.Add(a6);
            //asters.Add(a7);

            ship = new Spaceship(g, new Point(492, 280));
            gun = new Gun(g, new Point(492, 280));
            //bullet = new Bullet(g, new Point(492, 255));

            //aster = new Asteroids(g, new Point(180, 200));

            /*for(int i =0; i < 3; i++)
            {

                Point p = new Point(new Random().Next(150, 200));
                a[i] = new Asteroids(g, p/*new Point(new Random().Next(1, Width)));
                asters.Add(a[i]);
            }
            */

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(black, 0, 0, Width, Height);

            foreach(Stars s in stars)
            {
                s.DrawStar();
            }


            if (buls != null)
            {
                foreach (Bullet b in buls)
                {
                    b.BulDraw();
                }
            }
            ship.DrawShip(c);
            
            //gun.DrawGun();


            foreach (Asteroids a in asters)
            {
                a.AstersDraw();
            }

            sx = ship.sx;
            sy = ship.sy;


        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Up:
                    c = 1;
                    ship.DrawShip(1);
                    //ship1.MoveShip(c);
                    break;
                case Keys.Right:
                    c = 2;
                    ship.DrawShip(2);
                    //ship1.MoveShip(c);
                    break;
                case Keys.Down:
                    c = 3;
                    ship.DrawShip(3);
                    //ship1.MoveShip(3);
                    break;
                case Keys.Left:
                    c = 4;
                    ship.DrawShip(4);
                    //ship1.MoveShip(4);
                    break;
                case Keys.Space:
                    //bullet = new Bullet(g, new Point(sx, sy));
                    buls.Add(new Bullet(g, new Point(sx, sy), c));
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (Asteroids a in asters)
            {
                a.AstersMove(Width, Height);
                a.Checker(asters, buls);
            }

            foreach(Stars s in stars)
            {
                s.MoveStars();
                s.Checker(asters, stars);
            }

            foreach(Bullet b in buls)
             {


                     b.BulMove();

             }
             
           

           
          

            ship.MoveShip(c);

            Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}

/*Asteroids a1 = new Asteroids(g, new Point(180, 200));
Asteroids a2 = new Asteroids(g, new Point(220, 450));
Asteroids a3 = new Asteroids(g, new Point(800, 170));
Asteroids a4 = new Asteroids(g, new Point(610, 510));
*/

