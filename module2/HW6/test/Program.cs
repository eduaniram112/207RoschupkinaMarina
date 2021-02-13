using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 50; i++)
            {
                if (12 % i == 0 || 15%i==0 || 42 % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
