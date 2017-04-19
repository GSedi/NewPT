using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid
{
    class Asteroids
    {
        Point asters;
        SolidBrush red = new SolidBrush(Color.Red);
        Graphics g;
        public int dx = 10;
        public int dy = 10;
        public int x;
        public int y;

        static long c = 0;

        public Asteroids() { }

        public Asteroids(Graphics g, Point asters)

        {
            this.g = g;
            this.asters = asters;
            x = asters.X;
            y = asters.Y;
            
        }

        public void AstersDraw()
        {
            Point[] aster1 =
            {
                new Point(asters.X+30,asters.Y),
                new Point(asters.X+60,asters.Y+45),
                new Point(asters.X,asters.Y+45)
            };
            Point[] aster2 =
            {
                new Point(asters.X,asters.Y+15),
                new Point(asters.X+60,asters.Y+15),
                new Point(asters.X+30,asters.Y+60)
            };


            g.FillPolygon(red, aster1);
            g.FillPolygon(red, aster2);

        }

        public void AstersMove(int wd, int ht)
        {
            /* c++;

             if(asters.X < 0) asters.X = wd;

             if (wd < asters.X) asters.X = 0;

             if (asters.Y < 0) asters.Y = ht;

             if (ht < asters.Y) asters.X = 0;
             *
             if (c % 2 == 0)
             {
                 asters.X += new Random().Next(0, 15);
                 asters.Y -= new Random().Next(0, 15);
             }else if(c%3 == 0)
             {
                 asters.X -= new Random().Next(0, 10);
                 asters.Y -= new Random().Next(0, 10);
             }
             /*else if(c%2 == 1)
             {
                 asters.X -= new Random().Next(0, 15);
                 asters.Y += new Random().Next(0, 15);
             }
             else if(c%4 == 0)
             {
                 asters.X += new Random().Next(0, 15);
                 asters.Y += new Random().Next(0, 15);
             }
             */


            if (asters.X < 10) dx*=-1;

            if (wd < asters.X+80) dx *= -1;

            if (asters.Y < 10) dy *= -1;

            if (ht < asters.Y+100) dy *= -1;


            asters.X += dx;
            asters.Y += dy;
        }

         public void Checker(List<Asteroids> asters2, List<Bullet> bul)
         {
             for(int i = 0; i <= 60; i++)
             {
                 for (int j = 0; j <= 60; j++)
                 {
                    /*foreach(Asteroids a in asters2)
                    {
                        foreach(Bullet b in bul)
                        {
                            if (Checker3(a, b, i, j))
                            {
                                dx *= -1;
                                dy *= -1;
                                
                                
                            }


                        }
                    }
                    */
                    foreach (Asteroids a in asters2)
                     {
                        
                         if (a != this)
                         {
                             if (Checker2(a, i, j))
                             {
                                 dx *= -1;
                                 dy *= -1;

                                 a.dx *= -1;
                                 a.dy *= -1;
                             }
                         }
                     }
                 }
             }

         }

         public bool Checker2(Asteroids a, int i, int j)
         {
            if ((asters.X + i == a.asters.X && asters.Y + j == a.asters.Y) ||
                (a.asters.X + i == asters.X && a.asters.Y + j == asters.Y))
            {
                return true;
            }
            else
            {
                return false;
            }

           
         }

        /*public bool Checker3(Asteroids a, Bullet b, int i, int j)
        {
            

            if ((b.+ i == a.asters.X && asters.Y + j == a.asters.Y) ||
                (a.asters.X + i == asters.X && a.asters.Y + j == asters.Y))
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        /* public void Checker(List<Asteroids> asters2)
         {

                     foreach (Asteroids a in asters2)
                     {
                         if (a != this)
                         {
                             if (Checker2(a))
                             {
                                 dx *= -1;
                                 dy *= -1;

                                 a.dx *= -1;
                                 a.dy *= -1;
                             }
                         }
                     }


         }

         public bool Checker2(Asteroids a)
         {
             if ((asters.X+60 == a.asters.X && asters.Y + 60 == a.asters.Y) ||
                 (a.asters.X + 60 == asters.X && a.asters.Y + 60 == asters.Y))
             {
                 return true;
             }
             return false;
         }

     */
    }
}


/*Point[] aster1 =
            {
                new Point(asters.X,asters.Y-30),
                new Point(asters.X+30,asters.Y+15),
                new Point(asters.X-30,asters.Y+15)
            };
Point[] aster2 =
{
                new Point(asters.X-30,asters.Y-15),
                new Point(asters.X+30,asters.Y-15),
                new Point(asters.X,asters.Y+30)
            };
            */