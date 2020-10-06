using System;
//sem_03 задача 11
namespace Task02
{
    class Program
    {
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
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i < n; i++)
            {
                a[i] = 34 * a[i - 1] - a[i - 2] + 2;
            }
            Write(n, a);



        }
    }
}
