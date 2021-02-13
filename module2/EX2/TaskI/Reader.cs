using System;
using System.IO;
using System.Linq;


public static class Reader
{
    public static int[] ReadFile(string fileName)
    {
        string[] all = File.ReadAllText(fileName).Split();
        int[] arr = new int[all.Length];
        for (int i = 0; i < all.Length; i++)
        {
            arr[i] = ParseWord(all[i]);
        }
        return arr;
    }

    private static int ParseWord(string word)
    {
        string str = new string((from c in word where !char.IsLetter(c) select c ).ToArray());
        str = str.Replace("+", "");
        string res = "";
        int count = 0;

        //Console.WriteLine(str);

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '-') count++;
            if (Char.IsDigit(str[i])) break;
        }

        str = str.Replace("-", "");

        if (count % 2 != 0) res += "-";
        res += str;
        return int.Parse(res);
    }
}