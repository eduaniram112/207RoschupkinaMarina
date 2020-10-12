using System;
using System.IO;

partial class Program
{
    private static string GetTextFromFile(string inputPath)
    {
        return File.ReadAllText(inputPath); 
    }

    private static int GetSumFromText(string text)
    {
        string[] str2 = text.Split(new Char[] { ' ', '\n', '.', '!', '?', ',' });
        int sum = 0;
        for (int i = 0; i < str2.Length; i++)
        {
            int n;
            bool x = int.TryParse(str2[i], out n);
            if (x){sum += n;}
        }
        return sum;
     
    }
}