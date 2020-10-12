using System;
using System.Linq;

partial class Program
{
    private static int[] ParseInput(string input)
    {
        //int[] array = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        string[] e = input.Split(' ');
        int[] ar = new int[e.Length];
        for(int i = 0; i < e.Length; i++)
        {
            ar[i] = Convert.ToInt32(e[i]);
        }
        return ar;

    }

    private static int GetMaxInArray(int[] numberArray)
    {
        return numberArray.Max();
    }
}