using System;
//8 задача из презентации 5
namespace Task01
{
    class Program
    {
        static double[] Gen(int n)
        {
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = (i * (i + 1) / 2) % n;
            }
            return arr;
        }

        static double[] Norm(double[] a)
        {
            double max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) { max = a[i]; }
            }
            for (int i = 0; i < a.Length; i++)
            {
                a[i] /= max;
            }

            return a;
        }

        static void W(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i].ToString("F3")+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n;
            bool x = int.TryParse(Console.ReadLine(), out n);
            double[] arr = Gen(n);
            W(arr);
            W(Norm(arr));
           
        }
    }
}
