using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NAsteroids.Model
{
    class Bullet
    {
        public GraphicsPath path3 = new GraphicsPath();
        public GraphicsPath path4 = new GraphicsPath();

        public Bullet()
        {

            
        }

        public void Draw(int x, int y)
        {
            path3.Reset();
            path4.Reset();

            path3.AddEllipse(x - 5, y - 13, 10, 26);
            path4.AddEllipse(x - 13, y - 5, 26, 10);
           
        }


    }
}
