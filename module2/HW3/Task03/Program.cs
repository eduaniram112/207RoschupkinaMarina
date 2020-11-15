using System;
using System.Collections.Generic;
//11 задача из презентации 5-6
namespace Task03
{
    class GeometricProgression
    {
        double _start;
        double _increment;
        
        public GeometricProgression()
        {
            _start = 0;
            _increment = 1;
        }

        public GeometricProgression(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }

        public double this[int index]
        {
            get
            {
                return _start * Math.Pow(_increment, index - 1);
            }
        }
        public double Increment
        {
            get {return _increment;}
        }

        public string GetInfo()
        {
            return "start = "+_start + " increment = "+_increment;
        }

        public double GetSum(int n)
        {
            return _start * (1 - Math.Pow(_increment, n)) / (1 - _increment);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random rand = new Random();
            n = rand.Next(5, 16);
            List<GeometricProgression> gplist = new List<GeometricProgression>();
            GeometricProgression gp;
            do
            {
                gp = new GeometricProgression(rand.Next(0, 11), rand.Next(0, 6));
            } while (gp.Increment == 0);

            Console.WriteLine("Главная прогрессия: " + gp.GetInfo());
            Console.WriteLine("Созданные прогрессии:");
            for (int i = 0; i < n; i++)
            {
                
                  gplist.Add(new GeometricProgression(rand.Next(0, 11), rand.Next(0, 6)));
                  Console.WriteLine((i + 1) + ". " + gplist[i].GetInfo());
            }

            int step = rand.Next(3, 16);
            Console.WriteLine("\nПрогрессии, у которых элемент с номером " + step +" больше соответствующего элемента главной прогрессии:");

            for (int i = 0; i < n; i++)
            {
                if (gplist[i][step] > gp[step])
                {
                    Console.WriteLine((i + 1) + ". " + gplist[i].GetInfo() + " Sum("+step+") = "+gplist[i].GetSum(step));
                }

            }

        }
    }
}
