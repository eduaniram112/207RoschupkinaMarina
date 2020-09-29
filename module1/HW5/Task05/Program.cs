using System;
//3 задача с 18 слайда из презентации 5
namespace Task05
{
    class Program
    {
        static int[] Gen(int n,int a,int d)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = a + i * d;
                
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
            int n,a,d;
            bool x = int.TryParse(Console.ReadLine(), out n);
            bool y = int.TryParse(Console.ReadLine(), out a);
            bool z = int.TryParse(Console.ReadLine(), out d);
            int[] arr = Gen(n,a,d);
            W(arr);


        }
    }
}
