using System;

partial class Program
{
    private static void GetLetterDigitCount(string line, out int digitCount, out int letterCount)
    {

        int d = 0;
        int l = 0;
        for (int i = 0; i < line.Length; i++)
        {
            if (Char.IsDigit(line, i)){d++;}
            if (Char.IsLetter(line, i)) { l++; }  
        }
        digitCount = d;
        letterCount = l;

    }
}