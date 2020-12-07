using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace frac
{
    // Класс множества Кантора.
    class Cantor : Fractal
    {
        // Конструктор множества.
        public Cantor() { }

        // Метор для отрисовки множества.
        public void DrawFractal(int x, int y, int width, Graphics g)
        {

            // Устанавливаем цвет ручки.
            pen = new Pen(colors[colornumb % 9]);

            

            // Условие выхода из рекурсии.
            if (width >= 1)
            {
                // Рисуем отрезки через прямоугольники.
                g.DrawRectangle(pen, x, y, width, 12);
                g.FillRectangle(pen.Brush, x, y, width, 12);

                // Сдвигаемся вниз.
                y = y + 40;

                // Меняем цвет.
                colornumb++;

                // Вызываем функцию для двух полученных отрезков&
                DrawFractal(x + width * 2 / 3, y, width / 3,g);
                DrawFractal(x, y, width / 3,g);
            }
        }
    }
}
