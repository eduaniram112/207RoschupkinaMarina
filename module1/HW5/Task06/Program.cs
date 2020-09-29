using System;
//4 задача с 18 слайда из презентации 5
namespace Task06
{
    class Program
    {
        static int[] Fib(int n)
        {
            int[] arr = new int[n];
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
                
            }
            return arr;
        }


        static void W(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n;
            bool x = int.TryParse(Console.ReadLine(), out n);
            int[] arr = Fib(n);
            W(arr);


        }
    }
}
