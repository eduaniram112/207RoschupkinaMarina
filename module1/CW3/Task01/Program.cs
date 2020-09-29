using System;

namespace Task01
{
    class Program
    {
        static void Square(int [] arr,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                arr[i] = r.Next(0, 100);
            }

        }
        static void Write(int [] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
        static void Main(string[] args)
        {
            int n;
            bool x = int.TryParse(Console.ReadLine(), out n);
            int[] arr = new int[n];
            Square(arr, n);
            Write(arr, n);

        }
    }
}
