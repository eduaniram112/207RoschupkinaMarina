using System;
using System.IO;


namespace Task01
{
    class Program
    {
        static string Bin(int x)
        {
            string s = "";
            while (x > 0)
            {
                s = (x % 2).ToString() + s;
                x /= 2;
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n;
            bool x = int.TryParse(Console.ReadLine(),out n);
            File.WriteAllText("../../../../binary.txt", Bin(n));
        }
    }
}
