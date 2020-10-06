using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool x = int.TryParse(Console.ReadLine(), out n);
            int[] a = new int[2*n];

            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                a[i] = r.Next(-10, 10);
            }
            for (int i = n; i < 2*n; i++)
            {

                a[i] = -100;
            }

            for (int i = 0; i < 2*n; i++)
            {

                Console.Write(a[i]+" ");
            }


            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0) {
                    a[i+n] = a[i];
                    a[i] = -100;
                }
            }

            for (int i = 0; i < 2 * n; i++)
            {

                Console.Write(a[i]+" ");
            }


            Console.WriteLine();

            int m = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != -100)
                {
                    a[m++] = a[i];
                }
            }

            if (m>0) { Array.Resize(ref a, m); }

            for (int i = 0; i < a.Length; i++)
            {
                
                Console.Write( a[i]+" ");
            }
        }
    }
}
