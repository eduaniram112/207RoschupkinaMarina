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
        Polygon polygon = new Polygon();
        Console.WriteLine(polygon.PolygonData());

        double rad;
        int number;
        Console.WriteLine("введите количество сторон и радиус");
        bool x = int.TryParse(Console.ReadLine(), out number);
        bool y = double.TryParse(Console.ReadLine(), out rad);
        polygon = new Polygon(number, rad);
        Console.WriteLine(polygon.PolygonData());



    }
}