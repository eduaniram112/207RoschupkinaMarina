using System;
using System.Text;
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "5A1";
            Console.WriteLine(Hex2Bin(a));
            StringBuilder b = new StringBuilder("F16");
            Console.WriteLine(Hex2BinBuilder(b));
        }

        public static string Hex2Bin(string Hex)
        {
            return Convert.ToString(Convert.ToInt32(Hex, 16), 2);
        }

        public static string Hex2BinBuilder(StringBuilder Hex)
        {
            StringBuilder hex = new StringBuilder(Hex.Length * 2);
            foreach (char s in Hex.ToString())
                hex.AppendFormat("{0:x2}", s);
            return hex.ToString();
        }
    }
}
