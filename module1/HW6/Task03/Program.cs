using System;
//sem_03 задача 13
namespace Task03
{
    class Program
    {
        static void Write(int n, int[] a)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            int n,k;
            bool x = int.TryParse(Console.ReadLine(), out n);
            bool y = int.TryParse(Console.ReadLine(), out k);
            int[] a = new int[n+1];

            for (int i = 1; i <= n; i++)
            {
                Random r = new Random();
                a[i] = r.Next(-10, 10);
            }
            Write(n, a);
            for (int i = 1; i <= n; i*=k)
            {
                Console.Write(a[i] + " ");
            }



        }
    }
}
