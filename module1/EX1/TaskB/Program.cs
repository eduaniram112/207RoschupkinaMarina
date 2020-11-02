using System;

partial class Program
{
    public static void Main(string[] args)
    {
        int a, b,c;
        bool x = int.TryParse(Console.ReadLine(), out a);
        bool y = int.TryParse(Console.ReadLine(), out b);
        bool z = int.TryParse(Console.ReadLine(), out c);
        if (x && y && a+b>c && a+c>b && b+c>a)
        {
            Console.WriteLine(a + b + c);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }

    }
}