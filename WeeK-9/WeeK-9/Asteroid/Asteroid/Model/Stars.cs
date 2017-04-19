using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid
{
   

    class Stars 
    {

        public Random r = new Random();
        public Graphics g;
        SolidBrush white = new SolidBrush(Color.White);
        Point star;

        
        public Stars(Graphics g, Point star)
        {
            this.g = g;
            this.star = star;
        }

        public void DrawStar()
        {
            g.FillEllipse(white, star.X, star.Y, 40, 40);
        }

        internal void Add(Stars s)
        {
            throw new NotImplementedException();
        }

        public void MoveStars()
        {
            int wd = 950;
            int ht = 650;


            //if (star.X < 0) star.X = wd;

            if (wd <= star.X + 40) star.X = 0;

            //if (star.Y < 0) star.Y = ht;

            if (ht <= star.Y + 40) star.Y = 0;

            star.X += r.Next(0, 15);
            star.Y += r.Next(0, 15);
        }

        public void Checker(List<Asteroids> asters2, List<Stars> s2)
        {
            for (int i = 0; i <= 60; i++)
            {
                for (int j = 0; j <= 60; j++)
                {

                    foreach (Stars s in s2)
                    {

                        foreach (Asteroids a in asters2)
                        {

                            if (Checker2(a, i, j))
                            {

                                star.X -= r.Next(0, 15);
                                star.Y -= r.Next(0, 15);
                            }

                        }
                    }
                }
            }
                
        }

        public bool Checker2(Asteroids a, int i, int j)
        {
            if ((star.X +i == a.x && star.Y+j == a.y) ||
                (a.x +i == star.X && a.y +j  == star.Y))
            {
                return true;
            }
            return false;
        }
     
    }
}


/*public void Checker(List<Asteroids> asters2, List<Stars> s2)
{

    foreach (Stars s in s2)
    {

        foreach (Asteroids a in asters2)
        {

            if (Checker2(a))
            {

                star.X -= r.Next(0, 15);
                star.Y -= r.Next(0, 15);
            }

        }
    }

}

/*public bool Checker2(Asteroids a)
{
    if ((star.X == a.x && star.Y == a.y) ||
        (a.x == star.X && a.y == star.Y))
    {
        return true;
    }
    return false;
}
*/
