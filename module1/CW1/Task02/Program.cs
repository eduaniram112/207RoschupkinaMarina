using System;
//3 задача из классной
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =0;
            double d,oldi = 0,s = 0;
            int.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out d);

            for (double i = 0.0; i < a; i+=d)
            {
                s += d * 0.5 * (i*i+oldi*oldi);
                oldi = i;
                 
            }
            s += (a - oldi) * 0.5 * (oldi * oldi + a * a);
            Console.WriteLine(s);
        }
    }
}
