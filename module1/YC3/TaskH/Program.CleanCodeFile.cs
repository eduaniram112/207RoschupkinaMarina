using System;
using System.IO;

//using System.Collections.Generic;

partial class Program
{
    private static string[] ReadCodeLines(string codePath)
    {
        string[] str2 = File.ReadAllLines(codePath);
        //string[] str2 = str.Trim().Split('\n');
        return str2;

    }

    private static string[] CleanCode(string[] codeWithComments)
    {

        int k = 0, i = 0;
        string[] codeWithOutComments = new string[codeWithComments.Length];
        bool s = false,s2=false;
        while (i < codeWithComments.Length )
        {
            s2 = false;
            if (!string.IsNullOrEmpty(codeWithComments[i]))
            {
                int w = 0;
                while (codeWithComments[i][w] == ' ' && w < codeWithComments[i].Length - 1) { w++; }

                if (codeWithComments[i][w] == '/' && codeWithComments[i][w + 1] == '*')
                {
                    s = true;
                }
               

                int q = 0;
                while (codeWithComments[i][q] == ' ' && q < codeWithComments[i].Length - 1) { q++; }
                if ((codeWithComments[i][q] == '/' && codeWithComments[i][q + 1] == '/')) { s2 = true; }
                if (s2 != true && s != true)
                {

                    codeWithOutComments[k] = codeWithComments[i];
                    k++;
                }

                if (codeWithComments[i].Contains("*/") && i < codeWithComments.Length - 1)
                {

                    s = false;

                }

                i++;
                




            }
            else { i++; }

        }
        return codeWithOutComments;

    }

    private static void WriteCode(string codeFilePath, string[] codeLines)
    {
       /* for (int i = 0; i < codeLines.Length; i++)
        {
            codeLines = CleanCode(codeLines);
        }*/
        for (int i = 0; i < codeLines.Length; i++)
        {
            if (!string.IsNullOrEmpty(codeLines[i]))
            {
                File.AppendAllText(codeFilePath, codeLines[i] + Environment.NewLine);
            }
        }

    }

    private static void Write(string[] code)
    {
        for (int i = 0; i < code.Length; i++)
        {
            Console.WriteLine(code[i]);
            Console.WriteLine();
        }
    }
}