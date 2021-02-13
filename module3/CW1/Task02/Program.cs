using System;

namespace Task02
{
    class Program
    {
        delegate int Cast(double a);
        static void Main(string[] args)
        {
            Cast c1 = delegate(double a)
                {
                    return (int)Math.Round(a);
                };

            Cast c2 = delegate (double a)
                {
                    return Math.Round(a).ToString().Length;
                };

            Cast c3 = c1;
            c3 += c2;
            Console.WriteLine(c3.Invoke(12.4));
        }
    }
}
