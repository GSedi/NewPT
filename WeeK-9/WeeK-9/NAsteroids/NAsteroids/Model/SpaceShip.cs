using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NAsteroids.Model
{
    class SpaceShip
    {
        public GraphicsPath path1 = new GraphicsPath();

        public SpaceShip(int x, int y)
        {
            Point[] ship =
          {
                new Point(x,y-60),
                new Point(x+60,y-30),
                new Point(x+60,y+30),
                new Point(x,y+60),
                new Point(x-60,y+30),
                new Point(x-60,y-30)
            };

            path1.AddPolygon(ship);
        }


    }
}
