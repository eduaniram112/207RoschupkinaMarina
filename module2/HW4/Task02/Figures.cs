using System;
namespace figures
{
    public class Point : IComparable<Point>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public virtual double Area { get; }
        public virtual double Perimeter { get; }
        public virtual string Display()
        {
            return "X = "+ X.ToString("F2") +", Y = "+Y.ToString("F2");
        }

        public int CompareTo(Point p)
        {
            return this.Area.CompareTo(p.Area);
        }
    }

    public class Circle : Point
    {
        double r;
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        public Circle(double x, double y, double rad)
        {
            X = x;
            Y = y;
            R = rad;
        }
        public override double Area => Math.PI * R * R;
        public override double Perimeter => 2 * Math.PI * R;
        public override string Display()
        {
            return "Круг, радиус = "+R.ToString("F2") + ", центр: " + base.Display() + ", площадь = " + Area.ToString("F2");
        }
    }

    public class Square : Point
    {
        double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public Square(double x, double y, double side)
        {
            X = x;
            Y = y;
            Side = side;
        }

        public override double Area => Side * Side;
        public override double Perimeter => 4 * Side;
        public override string Display()
        {
            return "Квадрат, длина стороны = "+side.ToString("F2")+", центр: " + base.Display() + ", площадь = "+Area.ToString("F2");
        }
    }
}
