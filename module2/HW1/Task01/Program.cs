using System;
//2 задача из презентации 1
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool x = int.TryParse(Console.ReadLine(), out n);
            int[][] a = new int[n][];

            for (int i = 0; i < n; i++)
            {
                a[i] = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                a[0][i] = i + 1;
            }

            for (int i = 1; i < n; i++)
            {

                for (int j = 0; j < n-1; j++)
                {
                    a[i][j] = a[i - 1][j + 1];
                }

                a[i][n - 1] = a[i - 1][0];

            }

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
