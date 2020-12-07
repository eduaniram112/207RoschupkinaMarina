using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frac
{
    public partial class Form1 : Form
    {
        
        public Pen p; // Ручка.
        public double angle = Math.PI / 2; // Угол поворота на 90 градусов.
        public double ang1 = Math.PI / 4;  // Угол поворота на 45 градусов.
        public double ang2 = Math.PI / 6;  // Угол поворота на 30 градусов.
        public double length = 200; // Длина.
        public double coef = 0.7; // Отношение отрезков.
        public int level = 1; // Уровень рекурсии.

        // Булы, чтобы знать какие кнопки нажаты.
        bool but1 = false;
        bool but2 = false;
        bool but3 = false;
        bool but4 = false;
        bool but5 = false;




        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Уровень рекурсии " + trackBar1.Value;
            textBox3.Text = "Угол1 =  " + trackBar2.Value;
            textBox4.Text = "Угол2 =  " + trackBar3.Value;
            textBox5.Text = "Длина =  " + trackBar4.Value;
            textBox6.Text = "Соотношение отрезков = " + coef.ToString("F2");
        }

        // Метод для отрисовки всего.
        // Если рисовать не в нем, то не будет работать сохранение, поэтому такая кривая реализация.
        private void panel1_Paint(object sender, PaintEventArgs e) 
        {
            //Начальные настройки.
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Рисуем обдуваемое дерево.
            if (but1)
            {
                // Сажаем дерево.
                Tree tre = new Tree(level, ang1, ang2, length, coef);
                tre.DrawFractal(panel1.Width / 2, panel1.Height * 0.99, tre.length, angle, g);
            }
            // Рисуем кривую.
            if (but2)
            {
                Koch koch = new Koch(level);

                // Начальные координаты.
                double y1 = panel1.Height * 0.9;
                double y2 = (y1 + Math.Sqrt(length*length*12));
                double x1 = (panel1.Width-4*length) * 0.5;
                double x2 = (panel1.Width + 4*length) * 0.5;

                // Начальные точки.
                var point1 = new PointF((float)x1, (float)y1);
                var point2 = new PointF((float)x2, (float)y1);
                var point3 = new PointF((float)panel1.Width/2, (float)y2);

                koch.DrawFractal(point1, point2, point3, level, g);

            }
            // Рисуем ковер.
            if (but3)
            {
                RectangleF carpet = new RectangleF(0, 0, panel1.Width, panel1.Height);
                Carpet carp = new Carpet(level);
                carp.DrawFractal(carp.level, carpet,g);
            }
            // Рисуем треугольник.
            if (but4)
            {
                // Начальные точки.
                PointF topPoint = new PointF(panel1.Width / 2f, 0);
                PointF leftPoint = new PointF(0, panel1.Height);
                PointF rightPoint = new PointF(panel1.Width, panel1.Height);

                // А вот и сам треугольник.
                Triangle triangle = new Triangle(level);
                triangle.DrawFractal(triangle.level, topPoint, leftPoint, rightPoint, g);
 
            }
            // Рисуем множество.
            if (but5)
            {
                int x = panel1.Width / 2 - (int)length * 5/2;
                Cantor cantor = new Cantor();
                cantor.DrawFractal(x, (int)(panel1.Height*0.1), (int)length * 5, g);
                
            }

          
        }
        // 5 одинаковых методов для клика на кнопку.
        // Обновляют paint и меняют соотвествующий бул.
        private void button1_Click(object sender, EventArgs e)
        {
            but1 = true;
            but2 = but3 = but4 = but5 = false;
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            but2 = true;
            but1 = but3 = but4 = but5 = false;
            panel1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            but3 = true;
            but1 = but2 = but4 = but5 = false;
            panel1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            but4 = true;
            but1 = but2 = but3 = but5 = false;
            panel1.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            but5 = true;
            but1 = but2 = but3 = but4 = false;
            panel1.Invalidate();

        }

        // Трекбар для реcurseи.
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = "Уровень рекурсии " + trackBar1.Value;
            level = trackBar1.Value;
            this.Invalidate();
        }

        

        // Нытье и немного FAQ.
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа писалась на виртуалке на маке, так что давайте просто порадуемся, что она вообще запускается (запускается ведь?). " +
                "Пока я это писала, виртуалкая съела все свободное место на компе и пару раз выкинула черный экран, а дизайн винды теперь будет сниться мне в кошмарах." +
                " Часть алгоритмов взята из открытых источников, потому что у меня не было ни сил, ни желания разбираться еще и с этим." +
                " \n \n Чтобы что-то отрисовать нажмите на кнопку отрисовки справа, чтобы перерисовать с другими параметрами - тоже " +
                "\n Если после изменения ползунков ничего не поменялось - значит они не относятся к данному фракталу и не надо их трогать ");
        }

        // Трекбар для угла1.
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = "Угол1 =  " + trackBar2.Value;
            ang1 = trackBar2.Value * Math.PI / 180;
            this.Invalidate();

        }

        // Трекбар для угла2.
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = "Угол2 =  " + trackBar3.Value;
            ang2 = trackBar3.Value * Math.PI / 180;
            this.Invalidate();
        }

        // Трекбар для длины.
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            textBox5.Text = "Длина =  " + trackBar4.Value;
            length = trackBar4.Value;
            this.Invalidate();

        }

        // Трекбар для соотношения отрезков.
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            coef = trackBar5.Value / 100.0;
            textBox6.Text = "Соотношение отрезков = " + coef.ToString("F2");
            this.Invalidate();
        }
        // Кнопка для сохранения фрактала на рабочий стол.
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сохранили ваш фрактал на рабочий стол, чтобы вы могли им любоваться");
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0,0,panel1.Width,panel1.Height));
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"panel1.jpg");
            bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        

    

    }

}
