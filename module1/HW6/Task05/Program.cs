using System;
//sem_03 задача 20
namespace Task05
{
    class Program
    {
        static void Write(int n, int[] a)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();

        }
        static void ArrayItemDouble(ref int[] a,int x)
        {
            for (int i = 0; i < a.Length; i++)
            { 

                    if (a[i] == x) { a[i] *= 2; }
            }

        }

        static void Main(string[] args)
        {
            int n,y;
            bool x = int.TryParse(Console.ReadLine(), out n);
            bool z = int.TryParse(Console.ReadLine(), out y);
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                a[i] = r.Next(10,100);
                    
            }
            Write(n, a);
            ArrayItemDouble(ref a, y);
            Write(n, a);

        }
    }
}
