using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_1
{
    class DrawClass : Form1
    {

        //Graphics g;
        GraphicsPath path = new GraphicsPath();

        public DrawClass(int x, int y)
        {
            Point[] p4 =
            {
               new Point(120, 120),
                new Point(123, 125),
                new Point(130, 125),
                new Point(126, 131),
                new Point(130, 137),
                new Point(123, 137),
                new Point(120, 142),
                new Point(117, 137),
                new Point(110, 137),
                new Point(114, 131),
                new Point(110, 125),
                new Point(117, 125),
                new Point(120, 120)
            };

        }
      
    }
}
