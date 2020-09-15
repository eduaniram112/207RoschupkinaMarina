using System;
//7 задача из классной
namespace Task03
{
    class Program
    {
        static public bool ur(int a,int b,int c)
        {
            bool kor;
            if (a ==0 && b==0)
            {
                kor = false;
                
            }
            else
            {
                kor = true;
                //double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 / a;
               // double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 / a;

            }
            return kor;

        }
        static void Main(string[] args)
        {
            int a,b,c;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);
            if (ur(a, b, c))
            {
                double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 / a;
                double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 / a;
                Console.WriteLine(ur(a, b, c)+" "+x1.ToString("F3")+" "+x2.ToString("F3"));

            }
            else
            {
                Console.WriteLine(ur(a, b, c));
            }


        }
    }
}
