using System;
//3 задача из 5 презентации
namespace Task07
{
    class Program
    {
        static int F(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * F(x - 1);
            }
        }

        static double[]Arr(int n, double angle)
        {
            double[] arr = new double[n];
            double x = angle % (2 * Math.PI);
            int i = 1;
            double sin = x, memb = x, sinOld = 0, mem = 0; 
            for (int m = 1; m<=n; m++)
            {
                sinOld = sin;
                sin += memb;
                mem = Math.Pow(x, i)/F(i);
                arr[m - 1] = mem;
                sin += memb;
                i += 2;
                
                
                
                
            }
            
            return arr;
        }

        static double Sinus(double angle, double[]arr)
        {
           
            double x = angle % (2 * Math.PI);
            double sin=x, memb=x, sinOld=0;
            for (int m = 1;m<arr.Length;m++)
            {
                sinOld = sin;
                memb = arr[m] * Math.Pow(-1, m);
                sin += memb;

            }
            return sin;
        }

        static void Main(string[] args)
        {
            int n;
            double angle,sin,sinOld,memb;
            bool y = double.TryParse(Console.ReadLine(), out angle);
            bool z = int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(angle % (2 * Math.PI));
            double[] a = Arr(n, angle);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i].ToString("F3"));
            }
            Console.WriteLine(Sinus(angle,a));
            Console.WriteLine(Math.Sin(angle));
            



        }
    }
}
