using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace frac
{
    // Основной класс фрактала.
    // Если вам кажется, что здесь происходит натягивание ооп на глобуc, то вам не кажется.
    class Fractal
    {
        public int level { get; set; } // Уровень рекурсии.
        public Pen pen; //Ручка
        
        // Массив для градиента.
        public Color[] colors = {
            ColorTranslator.FromHtml("#07007e"),
            ColorTranslator.FromHtml("#310080"),
            ColorTranslator.FromHtml("#4a0081"),
            ColorTranslator.FromHtml("#720082"),
            ColorTranslator.FromHtml("#810083"),
            ColorTranslator.FromHtml("#a40084"),
            ColorTranslator.FromHtml("#bf0085"),
            ColorTranslator.FromHtml("#dd0086"),
            ColorTranslator.FromHtml("#ff0088"),
        };

        // Номер цвета.
        public int colornumb = 0;

        // Конструкторы.
        public Fractal(){}
        public Fractal(int level)
        {
            this.level = level;
        }
        // Метод для отрисовки.
        virtual public void DrawFractal() { }
    }
}
