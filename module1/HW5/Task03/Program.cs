using System;
//1 задача с 18 слайда из презентации 5
namespace Task03
{
    class Program
    {
        static int[] Gen(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = (int)Math.Pow(2, i);
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
            int[] arr = Gen(n);
            W(arr);
            

        }
    }
}
