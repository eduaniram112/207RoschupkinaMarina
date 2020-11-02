using System.IO;

public static partial class Program
{
    private static int GetCountCapitalLetters(string inputPath)
    {
        string a = File.ReadAllText(inputPath);
        int cap = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (char.IsUpper(a[i])) { cap++; }
        }
        return cap;

    }

    private static void WriteCount(string outputPath, int count)
    {
        File.WriteAllText(outputPath, count.ToString());
    }
}