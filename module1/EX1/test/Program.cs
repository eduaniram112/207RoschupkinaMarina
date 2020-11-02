using System;
using System.Linq;

namespace test
{
    class Program
    {
        private static char LeastCommon(string str)
        {
            char mc = 'a';
            int[] alph = new int[200];
            for (int i = 0; i < str.Length; i++)
            {
                alph[(int)str[i]]++;
            }
            int minval=int.MaxValue;
            for (int i = 0; i < alph.Length; i++)
            {
                if (alph[i] < minval && alph[i] != 0) minval = alph[i];
            }
            int minind = alph.ToList().IndexOf(minval);
            mc = (char)minind;
            return mc;
        }

        static void Main(string[] args)
        {
            string str = "aaaEEqqqqqqq";
            char mc = 'a';
            int[] alph = new int[200];

            for (int i = 0; i < str.Length; i++)
            {
                alph[(int)str[i]]++;
            }

            int minval = int.MaxValue;
            for (int i = 0; i < alph.Length; i++)
            {
                if (alph[i] < minval && alph[i] > 0) minval = alph[i];
            }
            int minind = alph.ToList().IndexOf(minval);
            Console.WriteLine(minval);
            Console.WriteLine(minind);
            mc = (char)minind;

            Console.WriteLine(mc);
        }
    }
}
