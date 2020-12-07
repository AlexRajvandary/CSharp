using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace FractalsLib
{
    public class CochSnowflake : Fractal
    {
       public int Depth { get; set; }

       public PointF p1;
        public PointF p2;
        public PointF p3;

        int max = 3;

        public CochSnowflake(Graphics gr, PointF p1, PointF p2, PointF p3, int max):base(gr)
        {
            
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.max = max;
        }

        public  int CochSnowflakeDraw(PointF p1, PointF p2, PointF p3, int Depth)
        {
            if (Depth == max)
            {
                gr.DrawLine(pen1, p1, p2);
                gr.DrawLine(pen1, p2, p3);
                gr.DrawLine(pen1, p3, p1);

                CochSnowflakeDraw(p1, p2, p3, Depth - 1);
                CochSnowflakeDraw(p2, p3, p1, Depth - 1);
               CochSnowflakeDraw(p3, p1, p2, Depth - 1);
            }
            else if (Depth > 0)
            {
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);

                gr.DrawLine(pen1, p4, pn);
                gr.DrawLine(pen1, p5, pn);
                gr.DrawLine(pen2, p4, p5);

                CochSnowflakeDraw(p4, pn, p5, Depth - 1);
                CochSnowflakeDraw(pn, p5, p4, Depth - 1);
                CochSnowflakeDraw(p1, p4, new PointF((2 * p1.X + p3.X) / 3,
                    (2 * p1.Y + p3.Y) / 3), Depth - 1);
                CochSnowflakeDraw(p5, p2, new PointF((2 * p2.X + p3.X) / 3,
                    (2 * p2.Y + p3.Y) / 3), Depth - 1);

            }
            return Depth;
        }
    }
}
