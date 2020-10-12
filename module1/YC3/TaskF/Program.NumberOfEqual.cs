using System;

partial class Program
{
    private static int[] ParseInput(string input)
    {
        //int[] array = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        string[] e = input.Split(' ');
        int[] ar = new int[e.Length];
        for (int i = 0; i < e.Length; i++)
        {
            ar[i] = Convert.ToInt32(e[i]);
        }
        return ar;
    }

    private static int GetNumberOfEqualElements(int[] f, int[] s)
    {
        int c = 0;
        int[] all = new int[f.Length + s.Length + 1];
        for (int i = 0; i < f.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                if (f[i] == s[j]) c++;
            }
        }
        
        return c;

    }
}