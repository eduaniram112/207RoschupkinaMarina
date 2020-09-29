using System;

namespace Task02
{
    class Program
    {
        static void Gen(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                arr[i] = r.Next(10, 50);
            }

        }
        static void Write(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(" ");

        }

        static int Chet(int[] arr, int n)
        {
            int chet = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0) { chet++; }
                
            }
            return chet;

        }

        static int[] Add(int[] a, int [] b, int n,int m)
        {
            int[] c = new int[n + Chet(b, m)];
            for (int i = 0; i < n; i++)
            {
                c[i] = a[i];
            }

            int nx = n;
            for(int i = 0; i < m; i++)
            {
                if (b[i] % 2 == 0) {
                    c[nx] = b[i];
                    nx++;
                }
                
            }
            return c;


        }

        static void Main(string[] args)
        {
            int n,m;
            bool x = int.TryParse(Console.ReadLine(), out n);
            bool y = int.TryParse(Console.ReadLine(), out m);
            int[] a = new int[n];
            int[] b = new int[m];
            Gen(a, n);
            Gen(b, m);
            int []c = Add(a, b, n, m);
            Write(a, n);
            Write(b, m);
            Write(c, c.Length);

        }
    }
}
