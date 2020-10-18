using System;
using System.Linq;
namespace Task01
{
    class Program
    {
        static void Write(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();

        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        static int[] Primes (int[]a)
        {
            int[] arr = new int[a.Length];
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (IsPrime(a[i]))
                {
                    arr[count] = a[i];
                    count++;
                }
            }
            Array.Resize(ref arr, count);
            return arr;

        }

        static bool IsNonDecreasing(int[] a)
        {
            bool flag = true;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[i - 1]) { flag = false; }
            }
            return flag;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter array size");
                int n;
                bool x = int.TryParse(Console.ReadLine(), out n);
                if (x)
                {
                    Console.WriteLine("Enter numbers");
                    int[] a = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        bool y = int.TryParse(Console.ReadLine(), out a[i]);
                        if (!y) { Console.WriteLine("error"); x = false; break; }
                    }
                    if (x)
                    {
                        Write(a);
                        Write(Primes(a));
                        Console.WriteLine(IsNonDecreasing(a));
                        Console.WriteLine(a.Min());
                    }

                }
                else
                {
                    Console.WriteLine("error");
                }

            }
        }
    }
}
