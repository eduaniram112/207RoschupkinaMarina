using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool x = int.TryParse(Console.ReadLine(), out n);
            char[][] a = new char[n][];

            for (int i = 1; i < n; i++)
            {
                a[i] = new char[i];
                Array.Fill(a[i], '*');

            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(String.Format("{0,3}", a[i][j]));

                }
                Console.WriteLine();

            }
        }
    }
}
