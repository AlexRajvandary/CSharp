using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsLib
{
    public class FractalTree : Fractal
    {

        public double angle = Math.PI / 2; //Угол поворота на 90 градусов
        public double ang1 = Math.PI / 4;  //Угол поворота на 45 градусов
        public double ang2 = Math.PI / 6;  //Угол поворота на 30 градусов

        public void DrawTree(PointF p1, double len, double angle, double Depth) //Функция, которая отресовывает наши ветки, где x и y - координаты, переменная len - длина, а переменная angle - угол поворота
        {
            
            if (Depth > 2)
            {
                Depth *= 0.7;

                double xnew = Math.Round(p1.X + len * Math.Cos(angle));
                double ynew = Math.Round(p1.Y - len * Math.Sin(angle));

                gr.DrawLine(pen1, p1, new PointF((float)xnew, (float)ynew));

                p1 = new PointF((float)xnew, (float)ynew);

                DrawTree(p1, len * 0.75, angle + ang1, Depth);
                DrawTree(p1, len * 0.75, angle - ang2, Depth);
            }



        }

        public FractalTree(Graphics gr) : base(gr)
        {
          
        }
    }
}
