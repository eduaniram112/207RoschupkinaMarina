using System;
using System.Linq;
using System.Text;
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "qqq   eee ff       ww";
            Console.WriteLine(OneSpace(str));

            StringBuilder str2 = new StringBuilder("ajdjv fjvjfj     fjfjf ");
            Console.WriteLine(OneSpaceBuilder(str2));

            //string str4 = "aaaa qqqq eee r qwertyuicc";
           // Console.WriteLine(MoreThan4(str4));
            //Console.WriteLine(IsVowel(str4));
        }


        public static string OneSpace(string str)
        {
            string[] strarr = str.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            return String.Join(" ", strarr);
        }


        public static string OneSpaceBuilder(StringBuilder str)
        {
            return string.Join(" ", str.ToString().Split(" ",StringSplitOptions.RemoveEmptyEntries));

        }

        static string RemoveSpaces(string s)
        {
            StringBuilder t = new StringBuilder();
            t.AppendJoin(' ', s.Split(' ', StringSplitOptions.RemoveEmptyEntries));
            return t.ToString();

        }

        public static int MoreThan4(string str)
        {
            string[] strarr = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach(string s in strarr)
            {
                if (s.Length > 4) count++;
            }
            return count;
        }

        public static int IsVowel(string str)
        {
            string[] strarr = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string s in strarr)
            {
                if ("aeiouAEIOU".Contains(s[0])) count++;
            }
            return count;
        }


    }
}
