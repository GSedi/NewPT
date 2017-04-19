using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid
{
    class Gun 
    {

        public Spaceship ship = new Spaceship();
        Graphics g;
        SolidBrush green = new SolidBrush(Color.Green);
        Point gun;

        public Gun(Graphics g, Point gun)
        {
            this.g = g;
            this.gun = gun;
        }

        public void DrawGun()
        {
            Point[] guns =
         {
                new Point(gun.X-20,gun.Y-10),
                new Point(gun.X,gun.Y-25),
                new Point(gun.X+20,gun.Y-10),
                new Point(gun.X+6,gun.Y-10),
                new Point(gun.X+6,gun.Y+25),
                new Point(gun.X-6,gun.Y+25),
                new Point(gun.X-6,gun.Y-10)
            };

            g.FillPolygon(green, guns);
        }


       /* public void MoveShip(int a)
        {

            //ship.X++;
            // ship.Y++;
            int wd = 950;
            int ht = 650;

            switch (a)
            {
                case 1:
                    ship.Y -= 10;
                    break;
                case 2:
                    ship.X += 10;

                    break;

                case 3:
                    ship.Y += 10;

                    break;

                case 4:
                    ship.X -= 10;
                    break;

            }

            if (ship.X < 0) ship.X = wd;

            if (wd < ship.X) ship.X = 0;

            if (ship.Y < 0) ship.Y = ht;

            if (ht < ship.Y) ship.X = 0;

        }
        */
    }
}
