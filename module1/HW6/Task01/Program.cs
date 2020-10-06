using System;
//sem_03 задача 9
namespace Task01
{
    class Program
    {
        static void Hill(int n, int[] a)
        {
            Array.Sort(a);
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 1) { b[n - 1 - i / 2] = a[i]; }
                else { b[i / 2] = a[i]; }
            }
            Write(n, a);
            Write(n, b);
        }

        static void Write(int n, int[] a)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            int n;
            bool x = int.TryParse(Console.ReadLine(), out n);
            int[] a = new int[n];
            int[] b = new int[n];

            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                a[i] = r.Next(-10, 10);
            }
            Hill(n, a);

            
        }

        
    }
}
