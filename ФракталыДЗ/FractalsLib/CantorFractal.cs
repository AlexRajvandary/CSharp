using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsLib
{
    public class CantorFractal : Fractal
    {
        public void Draw(int x, int y, int width)
        {
            
            // выбираем цвет заливки 
            SolidBrush Brush = new SolidBrush(Color.White);
         
            //Поставим условие вызова и прорисовки 

            if (width >= 3)
            {
                //Отрезки изображаем прямоугольниками для наглядности
                gr.DrawRectangle(pen1, x, y, width, 12);
                gr.FillRectangle(Brush, x, y, width, 12);

                //Сдвигаемся вниз
                y = y + 40;

                //Вызываем функцию для двух полученных отрезков
                Draw(x + width * 2 / 3, y, width / 3);
                Draw(x, y, width / 3);
            }
        }
        public CantorFractal(Graphics gr) : base(gr)
        {
        }
    }
}
