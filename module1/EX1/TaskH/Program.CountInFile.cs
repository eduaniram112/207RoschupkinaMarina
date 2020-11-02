using System;
using System.IO;
partial class Program
{
    private static readonly string[] Separators = { " ", ". ", ", ", "? ", "! ", ": ", "; ", };

    private static void CountInFile(string filePath, out int linesCount, out int wordsCount, out int charsCount)
    {
        string a = File.ReadAllText(filePath);
        int space = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == '\n') { space++; }
        }
        charsCount = a.Length - space;

        string[] arr = File.ReadAllLines(filePath);
        linesCount = arr.Length;

        wordsCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            string[] words = arr[i].Split(Separators,StringSplitOptions.None);
            wordsCount += words.Length;
        }

    }
}