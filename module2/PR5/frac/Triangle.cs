using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace frac
{
    // Класс треугольника.
    class Triangle : Fractal
    {

        // Конструктор треугольника.
        public Triangle(int lvl)
        {
            level = lvl;
        }

        // Метод лля отрисовки треугольника.
        public void DrawFractal(int level, PointF top, PointF left, PointF right, Graphics g)
        {

            // Условие выхода из рекурсии.
            if (level == 0)
            {
                PointF[] points = new PointF[3]{top, right, left};

                // Устанавливаем цвет ручки.
                pen = new Pen(colors[colornumb % 9]);
                // Рисуем первый треугольник.
                g.FillPolygon(pen.Brush, points);
            }
            else
            {
                // Вычисляем среднюю точку.
                var leftMid = MidPoint(top, left); // Левая сторона.
                var rightMid = MidPoint(top, right); // Правая сторона.
                var topMid = MidPoint(left, right); // Основание.

                // Меняем цвет.
                colornumb++;

                // Рекурсивно вызываем функцию для каждого из 3 треугольников.
                DrawFractal(level - 1, top, leftMid, rightMid,g);
                DrawFractal(level - 1, leftMid, left, topMid,g);
                DrawFractal(level - 1, rightMid, topMid, right,g);
            }
        }
        // Метод для нахождения средней точки между двумя.
        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }
    }
}
