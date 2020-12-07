using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace frac
{
    // Класс ковра.
    class Carpet : Fractal
    {
        // Конструктор ковра.
        public Carpet(int lvl)
        {
            level = lvl;
        }
        // Метод для отрисовки ковра.
        public void DrawFractal(int level, RectangleF carpet, Graphics g)
        {

            // Условие выхода из рекурсии.
            if (level == 0)
            {
                // Рисуем прямоугольник.
                pen = new Pen(colors[colornumb%9]);
                g.FillRectangle(pen.Brush, carpet);
               

            }
            else
            {
                // Делим прямоугольник на 9 частей.
                var width = carpet.Width / 3f;
                var height = carpet.Height / 3f;

                // (x1, y1) - координаты левой верхней вершины прямоугольника.

                var x1 = carpet.Left;
                var x2 = x1 + width;
                var x3 = x1 + 2f * width;

                var y1 = carpet.Top;
                var y2 = y1 + height;
                var y3 = y1 + 2f * height;

                //Меняем цвет.
                colornumb++;

                // Рисуем 8 прямоугольников.
                DrawFractal(level - 1, new RectangleF(x1, y1, width, height), g); // (1,1).
                DrawFractal(level - 1, new RectangleF(x2, y1, width, height), g); // (1,2).
                DrawFractal(level - 1, new RectangleF(x3, y1, width, height), g); // (1,3).
                DrawFractal(level - 1, new RectangleF(x1, y2, width, height), g); // (2,1).
                DrawFractal(level - 1, new RectangleF(x3, y2, width, height), g); // (2,3).
                DrawFractal(level - 1, new RectangleF(x1, y3, width, height), g); // (3,1).
                DrawFractal(level - 1, new RectangleF(x2, y3, width, height), g); // (3,2).
                DrawFractal(level - 1, new RectangleF(x3, y3, width, height), g); // (3,3).
            }
        }
    }
}
