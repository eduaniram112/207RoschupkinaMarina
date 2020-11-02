using System;
using System.Linq;

partial class Program
{
    private static char MostCommon(string str)
    {
        char mc = 'a';
        int[] alph = new int[200];
        for (int i = 0; i < str.Length; i++)
        {
            alph[(int)str[i]]++;
        }
        int maxind = alph.ToList().IndexOf(alph.Max());
        mc = (char)maxind;
        return mc;
    }

    private static char LeastCommon(string str)
    {
        char mc = 'a';
        int[] alph = new int[200];
        for (int i = 0; i < str.Length; i++)
        {
            alph[(int)str[i]]++;
        }
        int minval = int.MaxValue;
        for (int i = 0; i < alph.Length; i++)
        {
            if (alph[i] < minval && alph[i] != 0) minval = alph[i];
        }
        int minind = alph.ToList().IndexOf(minval);
        mc = (char)minind;
        return mc;
    }

    private static string Encrypt(string input)
    {
        char least = LeastCommon(input);
        char most = MostCommon(input);
        string a = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == least){a += most;}
            else if (input[i] == most){a += least;}
            else{a += input[i];}
        }

        return a;
    }
}
