using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NAsteroids.Model
{
    class Gun
    {
        public GraphicsPath path5 = new GraphicsPath();
        public Gun(int x, int y)
        {
            Point[] gun =
            {
                new Point(x-20,y-10),
                new Point(x,y-30),
                new Point(x+20,y-10),
                new Point(x+6,y-10),
                new Point(x+6,y),
                new Point(x-6,y),
                new Point(x-6,y-10)
            };

            path5.Reset();
            path5.AddPolygon(gun);
        }
    }
}
