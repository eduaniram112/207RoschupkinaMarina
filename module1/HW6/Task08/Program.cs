using System;

namespace Task08
{
    class Program
    {
        static void Write(int[,] a,int n,int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(String.Format("{0,3} ", a[i, j]));
                }
                Console.WriteLine();
            }

        }

        static int Det3(int[,] a,int s)
        {
            int detplus = a[0, 0+s] * a[1, 1+s] * a[2, 2+s] + a[0, 1+s] * a[1, 2+s] * a[2, 0+s] + a[0, 2+s] * a[1, 0+s] * a[2, 1+s];
            int detmin = a[0, 0+s] * a[1, 2+s] * a[2, 1+s] + a[0, 1+s] * a[1, 0+s] * a[2, 2+s] + a[0, 2+s] * a[1, 1+s] * a[2, 0+s];
            return detplus - detmin;
        }
        

        static void Main(string[] args)
        {
            int n, y;
            //bool x = int.TryParse(Console.ReadLine(), out n);
            int[,] a = new int[3, 6];
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    a[i, j] = r.Next(0, 20);
                }
            }
            Write(a,3,6);
            int[,] a2 = new int[1, 2];
            a2[0,0] = Det3(a, 0);
            a2[0,1] = Det3(a, 3);
            Write(a2, 1, 2);





        }
    }
}
