using System;

namespace Task02
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
                a[i] = new int[i + 1];
                
            }

            a[0][0] = 1;
            a[1][0] = 1;
            a[1][1] = 1;

            for (int i = 2; i < n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    a[i][j] = a[i - 1][j - 1] + a[i - 1][j];
                }
            }

            foreach(int[] b in a)
            {
                foreach(int c in b)
                {
                    Console.Write(c+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
