using System;

class Program
{
    public static void Main(string[] args)
    {
        short a, b;
        bool x = short.TryParse(Console.ReadLine(), out a);
        bool y = short.TryParse(Console.ReadLine(), out b);
        if (x && y)
        {
            Console.WriteLine(a ^ b);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}