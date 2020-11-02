using System;

namespace Task02
{
    class LatinChar
    {
        private char _char;

        public LatinChar()
        {
            _char = 'a';
        }

        public LatinChar(char ch)
        {
            _char = ch;
        }

        public LatinChar(int ch)
        {
            _char = (char)ch;
        }

        public char CH
        {
            get
            {
                return _char;
            }
            set
            {
                _char = value;
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            double rmin = double.Parse(Console.ReadLine());
            double rmax = double.Parse(Console.ReadLine());
            double delta = double.Parse(Console.ReadLine());
            int n = (int)(rmax - rmin) / (int)delta;



            LatinChar[] c = new LatinChar[n];
            int k = 0;
            double m = 0;
            for (double i = rmin; i <= rmax; i += delta)
            {
                c[k] = new LatinChar((int)i);
                Console.WriteLine(c[k].CH);

            }
            Console.WriteLine(m);
        }
    }
}
