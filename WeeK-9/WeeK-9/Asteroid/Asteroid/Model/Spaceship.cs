using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid
{
    class Spaceship 
    {

        Graphics g;
        SolidBrush yellow = new SolidBrush(Color.Yellow);
        SolidBrush green = new SolidBrush(Color.Green);
        Point ship;
        public int sx;
        public int sy;
      

        public Spaceship() { }

        public Spaceship(Graphics g, Point ship)
        {
            this.g = g;
            this.ship = ship;
        }

        public void DrawShip(int c)
        {

            Point[] shipc =
           {
                new Point(ship.X,ship.Y-30),
                new Point(ship.X+30,ship.Y-15),
                new Point(ship.X+30,ship.Y+15),
                new Point(ship.X,ship.Y+30),
                new Point(ship.X-30,ship.Y+15),
                new Point(ship.X-30,ship.Y-15)
            };

            g.FillPolygon(yellow, shipc);

            switch (c) {
                case 1:
                Gun(1);
                    break;
                case 2:
                    Gun(2);
                    break;
                case 3:
                    Gun(3);
                    break;
                case 4:
                    Gun(4);
                    break;
            }

        }

        public void MoveShip(int a)
        {

            //ship.X++;
            // ship.Y++;
            int wd = 950;
            int ht = 650;

            switch (a)
            {
                case 1:
                   
                    ship.Y-=10;
                    
                    break;
                case 2:
                    ship.X+=10;
                    
                    break;

                case 3:
                    ship.Y+=10;
                    
                    break;

                case 4:
                    ship.X-=10;
                    break;
                    
            }

            if (ship.X < 0) ship.X = wd;

            if (wd < ship.X) ship.X = 0;

            if (ship.Y < 0) ship.Y = ht;

            if (ht < ship.Y) ship.X = 0;

            sx = ship.X;
            sy = ship.Y;

        }


        public void Gun(int a)
        {
            switch (a)
            {
                case 1:
                    Point[] guns =
            {
                new Point(ship.X-20,ship.Y-10),
                new Point(ship.X,ship.Y-25),
                new Point(ship.X+20,ship.Y-10),
                new Point(ship.X+6,ship.Y-10),
                new Point(ship.X+6,ship.Y+25),
                new Point(ship.X-6,ship.Y+25),
                new Point(ship.X-6,ship.Y-10)
            };

                    g.FillPolygon(green, guns);
                    break;

                case 2:
                    Point[] guns2 =
            {
                new Point(ship.X+10,ship.Y-20),
                new Point(ship.X+30,ship.Y),
                new Point(ship.X+10,ship.Y+20),
                new Point(ship.X+10,ship.Y+6),
                new Point(ship.X-25,ship.Y+6),
                new Point(ship.X-25,ship.Y-6),
                new Point(ship.X+10,ship.Y-6)
            };

                    g.FillPolygon(green, guns2);
                    break;
                case 3:
                    Point[] guns3 =
           {
                new Point(ship.X-6,ship.Y-25),
                new Point(ship.X+6,ship.Y-25),
                new Point(ship.X+6,ship.Y+10),
                new Point(ship.X+20,ship.Y+10),
                new Point(ship.X,ship.Y+25),
                new Point(ship.X-20,ship.Y+10),
                new Point(ship.X-6,ship.Y+10)
            };

                    g.FillPolygon(green, guns3);

                    break;
                case 4:
                    Point[] guns4 =
          {
                new Point(ship.X-25,ship.Y),
                new Point(ship.X-10,ship.Y-20),
                new Point(ship.X-10,ship.Y-6),
                new Point(ship.X+25,ship.Y-6),
                new Point(ship.X +25,ship.Y+6),
                new Point(ship.X-10,ship.Y+6),
                new Point(ship.X-10,ship.Y+20)
            };

                    g.FillPolygon(green, guns4);


                    break;

            }
            
        

            
        }

        

    }
}
