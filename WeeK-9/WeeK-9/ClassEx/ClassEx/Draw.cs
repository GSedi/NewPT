using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx
{
    
    class Draw
    {

        public GraphicsPath path1 = new GraphicsPath();
        public GraphicsPath path2 = new GraphicsPath();
        public GraphicsPath path3 = new GraphicsPath();

        public void Kuzov(int x, int y)
        {
            Point[] p1 =
            {
                new Point(x, y),
                new Point(x+40, y),
                new Point(x+50, y+20),
                new Point(x-10, y+20)
                

            };

            Rectangle r = new Rectangle(x-50, y+20, 150, 30);
            path2.AddRectangle(r);

            path1.AddPolygon(p1);

            path3.AddEllipse(x-20, y+40, 20, 20);
            path3.AddEllipse(x+50, y + 40, 20, 20);


        }
    }
}
