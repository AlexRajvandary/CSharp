using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsLib
{
    public class SerpinskiTriangle : Fractal
    {

        public void Draw(int Depth, PointF p1,PointF p2,PointF p3)
        {
            if(Depth == 1)
            {
                gr.DrawLine(pen1, p1, p2);
                gr.DrawLine(pen1, p1, p3);
                gr.DrawLine(pen1, p2, p3);


            }
            else
            {
                Draw(Depth - 1, p1, new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2), new PointF((p1.X + p3.X) / 2, (p1.Y + p3.Y) / 2));
                Draw(Depth - 1, p2, new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2), new PointF((p2.X + p3.X) / 2, (p2.Y + p3.Y) / 2));
                Draw(Depth - 1, p3, new PointF((p1.X + p3.X) / 2, (p1.Y + p3.Y) / 2), new PointF((p2.X + p3.X) / 2, (p2.Y + p3.Y) / 2));
            }
        }

        public SerpinskiTriangle(Graphics gr) : base(gr)
        {
        }
    }
}
