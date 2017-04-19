using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class DrawClass
    {
        public GraphicsPath path1 = new GraphicsPath();
        public GraphicsPath path2 = new GraphicsPath();
        public GraphicsPath path3 = new GraphicsPath();
        public GraphicsPath path4 = new GraphicsPath();
        public GraphicsPath path5 = new GraphicsPath();
        public GraphicsPath path6 = new GraphicsPath();
        public GraphicsPath path7 = new GraphicsPath();
        public GraphicsPath path8 = new GraphicsPath();


        public void Ship(int x, int y)
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
            path1.Reset();
            path1.AddPolygon(ship);
        }

        public void Stars(int x, int y)
        {
            //path2.Reset();
            path2.AddEllipse(x, y, 35, 35);
        }

        public void Bullet(int x, int y)
        {
            path3.Reset();
            path4.Reset();
            path3.AddEllipse(x - 5, y - 13, 10, 26);
            path4.AddEllipse(x - 13, y - 5, 26, 10);
        }

        public void Gun(int x, int y)
        {


            Point[] gun =
            {
                new Point(x-20,y-10),
                new Point(x,y-30),
                new Point(x+20,y-10),
                new Point(x+6,y-10),
                new Point(x+6,y+30),
                new Point(x-6,y+30),
                new Point(x-6,y-10)
            };

            path5.Reset();
            path5.AddPolygon(gun);
        }

        public void Asters(int x, int y)
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

           // path6.Reset();
            //path7.Reset();
            path6.AddPolygon(aster1);
            path7.AddPolygon(aster2);
        }

        public void Space(int x, int y, int a, int b)
        {

            Rectangle r = new Rectangle(x, y, a, b);

            path8.Reset();
            path8.AddRectangle(r);

        }
    }
}