using System;

namespace Task01
{
    class Program
    {
        static bool Shifter(ref char ch)
        {
            if (Char.IsLower(ch))
            {
                if (ch != 'x' || ch != 'y' || ch != 'z') { ch = (char)((int)ch + 3); }

                if (ch == 'x') ch = 'a';
                if (ch == 'y') ch = 'b';
                if (ch == 'z') ch = 'c';
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            Shifter(ref ch);
            Console.WriteLine(ch);
        }
    }
}
