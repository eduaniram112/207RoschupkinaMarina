using System;
class Program
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point() : this(0, 0) { } // конструктор умолчания
                                        // СВОЙСТВО RO
                                        // СВОЙСТВО FI
        public string PointData
        {   // СВОЙСТВО 
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }
        public double Ro
        {
            get
            {
                double ro = Math.Sqrt(X * X + Y * Y);
                return ro;
            }
        }
        public double Fi
        {
            get
            {
                if (X==0 && Y == 0){return 0;}
                else if(X==0 && Y < 0){return Math.PI * 1.5;}
                else if (X == 0 && Y > 0) { return Math.PI * 0.5; }
                else if (X < 0) { return Math.Atan(Y / X) + Math.PI; }
                else if (X >0 && Y<0) { return Math.Atan(Y / X) + 2*Math.PI; }
                else  { return Math.Atan(Y / X); }
            }
        }


        static void Main()
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);
            b = new Point(0, 3);
            Console.WriteLine(b.PointData);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x; c.Y = y;
                // #TODO3: следующий слайд
            } while (x != 0 | y != 0);


        }
    }
}
