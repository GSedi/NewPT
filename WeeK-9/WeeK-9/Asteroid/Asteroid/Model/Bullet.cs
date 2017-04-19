using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid
{
    class Bullet 
    {
        Graphics g;
        SolidBrush green = new SolidBrush(Color.Green);
        Point bul;
         int c;

        public Bullet(Graphics g, Point bul, int c) 
        {
            this.g = g;
            this.bul = bul;
            this.c = c;
        }

        public void BulDraw()
        {
            g.FillEllipse(green, bul.X - 5, bul.Y - 13, 10, 26);
            g.FillEllipse(green, bul.X - 13, bul.Y - 5, 26, 10);
        }

        public void BulMove()
        {
         
            switch (c)
            {
                case 1:
                    bul.Y -= 50;
                    bul.X = bul.X;
                    break;
                case 2:
                    bul.X += 50;

                    break;
                case 3:
                    bul.Y += 50;
                    break;
                case 4:
                    bul.X -= 50;
                    break;
            }
        }

        


    }
}
