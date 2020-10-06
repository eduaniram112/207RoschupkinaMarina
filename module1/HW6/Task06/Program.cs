using System;
//sem_04 задача 4
//предыдущие задачи в cw5
namespace Task06
{
    class Program
    {
        static void Write(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   Console.Write(String.Format("{0,3} ", a[i, j]));
                }
                Console.WriteLine();
            }
    
        }
        static int Det2(int[,] a)
        {
            int det = a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
            return det;
        }

        static int Det3(int[,] a)
        {
            int detplus = a[0, 0] * a[1, 1] * a[2,2] + a[0,1]*a[1,2]*a[2,0] + a[0,2]*a[1,0]*a[2,1];
            int detmin = a[0, 0] * a[1, 2] * a[2, 1] + a[0, 1] * a[1, 0] * a[2, 2] + a[0, 2] * a[1, 1] * a[2, 0];
            return detplus-detmin;
        }


        static void Main(string[] args)
        {
            int n, y;
            bool x = int.TryParse(Console.ReadLine(), out n);
            int[,] a = new int[n,n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = r.Next(0,10);
                }
            }
            Write(n, a);
            if (n==2) Console.WriteLine(Det2(a));
            else if (n==3) Console.WriteLine(Det3(a));





        }
    }
}
