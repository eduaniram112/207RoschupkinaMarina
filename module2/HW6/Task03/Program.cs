using System;
using System.IO;

namespace Task03
{
    class Program
    {
        static int[] stat = new int[26];
        static void Main(string[] args)
        {
            string tmp;
            int openBrackets = 0;
            int closedBrackets = 0;
            int total = 0;

            var In = Console.In;
            var Out = Console.Out;

            StreamReader stream_in = new StreamReader(@"..\..\Program.cs");
            StreamWriter stream_out = new StreamWriter(@"..\..\Output.txt");

            Console.SetIn(stream_in);
            Console.SetOut(stream_out);

            while (true)
            {
                tmp = Console.ReadLine();
                if (tmp == null) break;
                total += tmp.Length;

                BracketsCount(tmp.Trim(), ref openBrackets, ref closedBrackets);
                Console.WriteLine(tmp);
            }

            stream_in.Close();
            Console.SetIn(In);


            if (openBrackets == closedBrackets)
                tmp = "Баланс скобок соблюдён, количество блоков: " + closedBrackets;
            else tmp = "Баланс скобок не соблюдён";

            Console.WriteLine(StatToString());
            Console.WriteLine(tmp);

            stream_out.Close();
            Console.SetOut(Out);

            Console.WriteLine("Для завершения работы нажмите любую клавишу.");
            Console.ReadKey();
        }

        private static void BracketsCount(string tmp, ref int openBrackets, ref int closedBrackets)
        {

            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] >= 'a' && tmp[i] <= 'z') stat[tmp[i] - 'a']++;
                if ((tmp[i] == '{') && (tmp.Length == 1)) openBrackets++;
                if ((tmp[i] == '}') && (tmp.Length == 1)) closedBrackets++;
            }
        }

        public static string StatToString()
        {
            string output = string.Empty;
            for (int i = 0; i < stat.Length; i++)
            {
                output += (char)('a' + i) + " - " + stat[i] + " ";
            }
            return output;
        }
    }
}
