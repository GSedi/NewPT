using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NAsteroids.Model
{
    class Stars

    {
        public GraphicsPath path2 = new GraphicsPath();
        public Stars()
        {
            
        }

        public void Draw(int x, int y)
        {
            //path2.Reset();
            path2.AddEllipse(x, y, 35, 35);
        }
    }
}
