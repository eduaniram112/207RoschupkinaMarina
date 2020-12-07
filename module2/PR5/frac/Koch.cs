using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace frac
{
    // Класс кривой Коха.
    class Koch : Fractal
    {
        // Конструктор кривой.
        public Koch(int lvl)
        {
            level = lvl;
        }

        // Метод для отрисовки кривой.
        public void DrawFractal(PointF p1, PointF p2, PointF p3, int iter, Graphics g)
        {
            // Устанавлмваем цвет.
            pen = new Pen(colors[colornumb % 9]);
            // Условие выхода из рекурсии.
            if (iter > 0)  
            {
                colornumb++;
                // Средняя треть отрезка.
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                // Координаты вершины угла.
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);
                // Рисуем угол.
                g.DrawLine(pen, p4, pn);
                g.DrawLine(pen, p5, pn);
                


                // Рекурсивно вызываем функцию нужное число раз.
                DrawFractal(p4, pn, p5, iter - 1, g);
                DrawFractal(pn, p5, p4, iter - 1, g);
                DrawFractal(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), iter - 1, g);
                DrawFractal(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), iter - 1, g);

            }

        }
    }
}
