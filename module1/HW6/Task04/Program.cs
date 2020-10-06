using System;
using System.Linq;
//sem_03 задача 16
namespace Task04
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

            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                a[i] = r.Next(-10, 10);
            }
            int minIndex = Array.IndexOf(a, a.Min());
            int maxIndex = Array.IndexOf(a, a.Max());
            Write(n, a);
            Console.WriteLine(minIndex);
            Console.WriteLine(minIndex+maxIndex);



        }
    }
}
