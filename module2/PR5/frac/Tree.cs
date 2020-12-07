using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace frac
{
    // Класс дерева.
    class Tree : Fractal
    {

        public double angle { get; set; } // Угол первой ветки.
        public double ang1 { get; set; } // Угол1.
        public double ang2 { get; set; } // Угол2.
        public double length { get; set; } // Длина отрезка.
        public double coef { get; set; } // Отношение сторон отрезков.

        // Коструктор дерева.
        public Tree(double Angle, double Ang1, double Ang2, double Length, double Coef)
        {
            angle = Angle;
            ang1 = Ang1;
            ang2 = Ang2;
            length = Length;
            coef = Coef;
        }
        //Метод для отрисовки.
        public void DrawFractal(double x, double y, double len, double angle, Graphics g) 
        {
            // Выставляем цвет ручки.
            pen = new Pen(colors[colornumb % 9]);
            // Условие для выхода из рекурсии.
            if (len > length*0.01)
            {
                len *= coef; // Уменьшаем len.
                
                colornumb++; // Меняем цвет.

                // Считаем координаты.
                double xnew = Math.Round(x + len * Math.Cos(angle)),
                       ynew = Math.Round(y - len * Math.Sin(angle));

                // Рисуем линию между вершинами.
                g.DrawLine(pen, (float)x, (float)y, (float)xnew, (float)ynew);

                // Переприсваеваем координаты.
                x = xnew;
                y = ynew;

                //Вызываем рекурсивную функцию для левой и правой ветки.
                DrawFractal(x, y, len, angle + ang1, g);
                DrawFractal(x, y, len, angle - ang2, g);
            }
        }

    }
}
