using System;
//9 задача из презентации 5
namespace Task02
{
    class Program
    {
        static double[] mx(double[]a, double p)
        {
            double max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) { max = a[i]; }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == max) { a[i] = p; }
            }
            return a;
        }

        static void W(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i].ToString("F3") + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n,p;
            bool x = int.TryParse(Console.ReadLine(), out n);
            bool y = int.TryParse(Console.ReadLine(), out p);
            double[] arr = new double[n];
            for (int i = 0; i < arr.Length; i++)
            {
                bool a = double.TryParse(Console.ReadLine(), out arr[i]);
            }

            W(arr);
            W(mx(arr, p));
           

        }
    }
}
