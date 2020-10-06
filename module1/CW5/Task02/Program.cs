using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool x = int.TryParse(Console.ReadLine(), out n);
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i ==n-j-1) { a[i, j] = 0; }
                    else if (i < n - j - 1) { a[i, j] = -1; }
                    else { a[i, j] = 1; }
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("{0,3}", a[i, j]));

                }
                Console.WriteLine();

            }
        }
    }
}
