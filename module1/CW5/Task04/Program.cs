using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m = 1;
            bool x = int.TryParse(Console.ReadLine(), out n);
            int[,] a = new int[n, n];

            if (n % 2 != 0) { a[n / 2, n / 2] = (n * n); }

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    a[i, j] = m;
                    m++;
                }

                for (int j = 1; j < n - i - i; j++)
                {
                    a[i + j, n - 1 - i] = m;
                    m++;
                }

                for (int j = n - 2 - i; j >= i; j--)
                {
                    a[n - 1 - i, j] = m;
                    m++;
                }

                for (int j = n - 2 - i; j > i; j--)
                {
                    a[j, i] = m;
                    m++;
                }



            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("{0,4}", a[i, j]));

                }
                Console.WriteLine();

            }
        }
    }
}
