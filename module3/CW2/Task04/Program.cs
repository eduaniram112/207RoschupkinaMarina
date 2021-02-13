using System;

namespace Task04
{
    delegate string ConvertRule(string a);
    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }

    }
    class Program
    {
        public static string RemoveDigits(string str)
        {

            string[] chars = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
            foreach (var c in chars)
            {
                str = str.Replace(c, string.Empty);
            }
            return str;
        }
        public static string RemoveSpaces(string str)
        {
            str = str.Replace(" ", string.Empty);
            return str;
        }

        static void Main(string[] args)
        {
            string a = "aaa 123 ddd1e0 svfk";
            ConvertRule cr1 = RemoveDigits;
            ConvertRule cr2 = RemoveSpaces;
            Converter c = new Converter();
            
            Console.WriteLine(a);
            Console.WriteLine(c.Convert(a, cr1));
            Console.WriteLine(c.Convert(a, cr2));

            ConvertRule cr = cr1;
            cr += cr2;
            Console.WriteLine(c.Convert(a, cr));
        }
    }
}
