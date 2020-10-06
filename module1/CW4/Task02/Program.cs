using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, s = 0;
            bool x = int.TryParse(Console.ReadLine(), out n);
            
            Random r = new Random();

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(-10, 10);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();

            int m = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    a[m++] = a[i];
                }
                
            }
            if (m > 0) { Array.Resize(ref a, m); }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }


        }
    }
}
