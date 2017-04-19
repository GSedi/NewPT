using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class PaintBase
    {

        public enum Shape { Pencil, Line, Rectangle, Res, Fill };

        
            public Graphics g;
            public GraphicsPath path;
            public PictureBox picture;
            public Pen pen;
            public Pen pen2;
            public Bitmap btm;
            public Point prev;
            public Shape shape;
        public Color origin;
        public Color fill;
        public Queue<Point> q;
        public Point cur;

        public PaintBase(PictureBox pictureBox1)
            {
                picture = pictureBox1;
                btm = new Bitmap(picture.Width, picture.Height);
                picture.Image = btm;
                pen = new Pen(Color.Red);
                g = Graphics.FromImage(btm);
                g.Clear(Color.White);
                path = new GraphicsPath();
                shape = Shape.Pencil;
                pen2 = new Pen(Color.Blue, 50);
                picture.Paint += Picture_Paint;
            fill = new Color();
            origin = new Color();
            q = new Queue<Point>();
            }

            private void Picture_Paint(object sender, PaintEventArgs e)
            {
                if (path != null)
                    e.Graphics.DrawPath(pen, path);
            }

            public void SaveLastPath()
            {
                if (path != null)
                    g.DrawPath(pen, path);
            }

            public void Draw(Point cur)
            {
                switch (shape)
                {
                    case Shape.Pencil:
                        g.DrawLine(pen, prev, cur);
                        prev = cur;
                        break;
                    case Shape.Line:
                        path.Reset();
                        path.AddLine(prev, cur);
                        break;
                    case Shape.Rectangle:
                        path.Reset();
                        path.AddRectangle(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                       
                        break;
                case Shape.Res:
                    g.DrawLine(pen2, prev, cur);
                    prev = cur;
                    break;
                case Shape.Fill:
                    Fill();
                    break;

                }
                picture.Refresh();
            }


            public void SaveImage(string filename)
            {
                btm.Save(filename);
            }

        public void Fill()
        {
            while (q.Count > 0)
            {
                cur = q.Dequeue();
                Check(cur.X, cur.Y - 1);
                Check(cur.X + 1, cur.Y);
                Check(cur.X, cur.Y + 1);
                Check(cur.X - 1, cur.Y);
            }
            picture.Refresh();
        }


        public void Check(int x, int y)
        {
            if (x > 0 && y > 0 && x < picture.Width && y < picture.Height)
            {
                if (btm.GetPixel(x, y) == origin)
                {
                    btm.SetPixel(x, y, fill);
                    q.Enqueue(new Point(x, y));
                }
            }
        }
    }
}
