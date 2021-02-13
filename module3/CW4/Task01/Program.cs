using System;

namespace Task01
{
    delegate double Calculate(int i);

    class MainClass
    {
        public static void Main()
        {
            int x;
            int.TryParse(Console.ReadLine(), out x);

            Calculate prF = x =>
            {
                double sum = 0;
                for (int i = 1; i <= 5; i++)
                {
                    double p = 1;
                    for (int j = 1; j <= 5; j++)
                        p = p * (i + 42) * x / j / j;
                    sum += p;
                }
                return sum;
            };



            Console.WriteLine(prF(x).ToString("f3"));
        }
    }
}
