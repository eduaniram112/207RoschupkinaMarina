using System;
//3 задача из презентации 2

public class Polygon
{
    int numb;
    double radius;
    public Polygon(int n = 3, double r = 1)
    { // конструктор       
        numb = n;
        radius = r;
    }
    public double Perimeter
    {
        get
        {
            double term = Math.Tan(Math.PI / numb);
            return 2 * numb * radius * term;
        }
    }

    public double Area
    {
        get
        {
            return Perimeter * radius / 2;
        }
    }
    public string PolygonData()
    {
        string res =
        string.Format("N={0}; R={1}; P={2,2:F3}; S={3,4:F3}",
        numb, radius, Perimeter, Area);
        return res;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("многоугольник по умолчанию");
        Polygon poly = new Polygon();
        Console.WriteLine(poly.PolygonData());
        Console.WriteLine("введите количество многоугольников");
        int n;
        bool nbool = int.TryParse(Console.ReadLine(), out n);
        Polygon[] polygon = new Polygon[n];

        for (int i = 0; i < n; i++)
        {
            double rad;
            int number;
            Console.WriteLine("введите количество сторон и радиус");
            string[] a = Console.ReadLine().Split();
            bool x = int.TryParse(a[0], out number);
            bool y = double.TryParse(a[1], out rad);
            polygon[i] = new Polygon(number, rad);
            Console.WriteLine(polygon[i].PolygonData());
        }
        int minind = 0, maxind = 0;
        double max = 0, min = 1000000;
        for (int i = 0; i < n; i++)
        {
            if (polygon[i].Area > max)
            {
                max = polygon[i].Area;
                maxind = i;
            }

            if (polygon[i].Area < min)
            {
                min = polygon[i].Area;
                minind = i;
            }
        }
        Console.WriteLine("самый маленький");
        Console.WriteLine(polygon[minind].PolygonData());
        Console.WriteLine("самый большой");
        Console.WriteLine(polygon[maxind].PolygonData());


    }
}