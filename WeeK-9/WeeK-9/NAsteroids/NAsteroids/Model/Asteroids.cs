using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NAsteroids.Model
{
    class Asteroids
    {
        public GraphicsPath path6 = new GraphicsPath();
        public GraphicsPath path7 = new GraphicsPath();

        public Asteroids()
        {
            
        }

        public void Draw(int x, int y)
        {
            Point[] aster1 =
            {
                new Point(x,y-30),
                new Point(x+30,y+15),
                new Point(x-30,y+15)
            };
            Point[] aster2 =
            {
                new Point(x-30,y-15),
                new Point(x+30,y-15),
                new Point(x,y+30)
            };

            path6.AddPolygon(aster1);
            path7.AddPolygon(aster2);
        }
    }
}
