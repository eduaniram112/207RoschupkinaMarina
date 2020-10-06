using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, s = 0;
            bool x = int.TryParse(Console.ReadLine(), out n);

            Random r = new Random();

            int[][] a = new int[n][];

            for (int i = 0; i < n; i++)
            {
                a[i] = new int[r.Next(5, 8)];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = r.Next(-10, 10);
                }
                
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();

            }
            


        }
    }
}
