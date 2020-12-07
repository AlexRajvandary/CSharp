using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsLib
{
    public class SerpinskiSquare : Fractal
    {

        public void Draw(int Depth, PointF p1, int width, int height)
        {
            if (Depth == 1)
            {
                Rectangle square = new Rectangle((int)p1.X, (int)p1.Y, width, height);
                gr.FillRectangle(new SolidBrush(Color.Blue), square);
                Rectangle smallSquare = new Rectangle((int)p1.X + width / 3, (int)p1.Y + height / 3, width / 3, height / 3);
                gr.FillRectangle(new SolidBrush(Color.White), smallSquare);
            }
            else
            {
                Draw(Depth - 1, new PointF(p1.X, p1.Y + height / 3), width / 3, height / 3);
                Draw(Depth - 1, new PointF(p1.X, p1.Y + 2 * height / 3), width / 3, height / 3);
                Draw(Depth - 1, new PointF(p1.X, p1.Y), width / 3, height / 3);

                Draw(Depth - 1, new PointF(p1.X + width / 3, p1.Y + 2 * height / 3), width / 3, height / 3);
                Draw(Depth - 1, new PointF(p1.X + width / 3, p1.Y), width / 3, height / 3);
                Draw(Depth - 1, new PointF(p1.X + 2 * width / 3, p1.Y + height / 3), width / 3, height / 3);
                Draw(Depth - 1, new PointF(p1.X + 2 * width / 3, p1.Y + 2 * height / 3), width / 3, height / 3);
                Draw(Depth - 1, new PointF(p1.X + 2 * width / 3, p1.Y), width / 3, height / 3);




            }
        }

        public SerpinskiSquare(Graphics gr) : base(gr)
        {
        }
    }
}
