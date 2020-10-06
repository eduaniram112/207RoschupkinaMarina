using System;
//sem_04 задача 5
namespace Task07
{
    class Program
    {
        static void Write(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("{0,3} ", a[i, j]));
                }
                Console.WriteLine();
            }

        }

        static void Write1(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i>j && i<n-1-j) Console.Write(String.Format("{0,2} ", a[i, j]));
                    else Console.Write("   ");
                }
                Console.WriteLine();
            }

        }
        static void Write2(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j && i >= n - 1 - j) Console.Write(String.Format("{0,2} ", a[i, j]));
                    else Console.Write("   ");
                }
                Console.WriteLine();
            }

        }
        static void Write3(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i > j && i > n - 1 - j) ||  (i < j && i < n - 1 - j)) Console.Write(String.Format("{0,2} ", a[i, j]));
                    else Console.Write("   ");
                }
                Console.WriteLine();
            }

        }
        static void Write4(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i > j && i > n - 1 - j && j<=n/2)  || (i < j && i < n - 1 - j && j>=n/2)) Console.Write(String.Format("{0,2} ", a[i, j]));
                    else Console.Write("   ");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            int n, y;
            bool x = int.TryParse(Console.ReadLine(), out n);
            int[,] a = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = r.Next(0, 10);
                }
            }
            Write(n, a);
            Console.WriteLine();
            Write1(n, a);
            Console.WriteLine();
            Write2(n, a);
            Console.WriteLine();
            Write3(n, a);
            Console.WriteLine();
            Write4(n, a);






        }
    }
}
