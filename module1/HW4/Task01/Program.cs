using System;
//задача 6 из презентации 4
namespace Task01
{
    class Program
    {
        static double S1(int x)
        {
            double s = 0, ps=-1;
            int i = 2, f = 1, z=1;
            do
            {
                ps = s;
                f *= (i - 1) * i;
                s += (Math.Pow(x, i) * Math.Pow(2, i - 1) * z) / f;
                i += 2;
                z *= -1;
            } while (s - ps > 0.1);

            return s;
        }

        static double S2(int x)
        {
            double s = 0, ps = -1;
            int i = 2, f = 1, z = 1;
            do
            {
                ps = s;
                f *=i;
                s += Math.Pow(x, i)/f;
                i += 2;
                z *= -1;
            } while (s - ps > 0.1);

            return s;
        }
        static void Main(string[] args)
        {
            int x;
            bool y = int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine(S1(x));
            Console.WriteLine(S2(x));

        }
    }
}
