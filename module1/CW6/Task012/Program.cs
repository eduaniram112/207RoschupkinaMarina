using System;
using System.IO;

namespace Task012
{
    class Program
    {
        static int Dec(string s)
        {
            int x = 0;
            for (int i = 0; i < s.Length; ++i)
                x = x * 2 + s[i] - '0';
            return x;
        }
        static void Main(string[] args)
        {
            int n;
            //bool x = int.TryParse(Console.ReadLine(), out n);
            string path = @"../../../../binary.txt";
            string str = File.ReadAllText(path);
            Console.WriteLine(Dec(str));
        }
    }
}
