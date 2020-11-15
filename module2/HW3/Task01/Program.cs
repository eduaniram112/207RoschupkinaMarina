using System;
using System.Collections.Generic;
//9 задача из презентации 5-6
namespace Task01
{
    class LinearEquation : IComparable<LinearEquation>
    {
        int a;
        int b;
        int c;

        public LinearEquation(int A,int B,int C)
        {
            a = A;
            b = B;
            c = C;
        }

        public double X()
        {
            return (c-b)/(double)a;
        }

        public int CompareTo(LinearEquation p)
        {
            return this.X().CompareTo(p.X());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество выражений");
            bool x = int.TryParse(Console.ReadLine(), out n);
      
            List<LinearEquation> le = new List<LinearEquation>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите коэффициенты");
                int a=0,b=0,c=0;
                bool y = int.TryParse(Console.ReadLine(), out a);
                bool z = int.TryParse(Console.ReadLine(), out b);
                bool w = int.TryParse(Console.ReadLine(), out c);
                le.Add(new LinearEquation(a, b, c));
            }
            le.Sort();
            foreach (LinearEquation a in le)
            {
                Console.WriteLine("x = " + a.X());
            }
        }
    }
}
