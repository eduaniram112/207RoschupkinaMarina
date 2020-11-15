using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

partial class Program
{
    static bool TryParseVectorFromFile(string filename, out int[] vector)
    {
        string[] str = File.ReadAllText(filename).Split();
        bool flag = true;
        vector = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            bool x = int.TryParse(str[i], out vector[i]);
            if (!x)
            {
                flag = false;
            }
        }
        return flag;
    }

    static int[,] MakeMatrixFromVector(int[] vector)
    {
        int[,] arr = new int[vector.Length, vector.Length];
        for(int i = 0; i < vector.Length; i++)
        {
            for (int j = 0; j < vector.Length; j++)
            {
                arr[i, j] = vector[j] * vector[i];

            }
        }
        return arr;
    }

    static void WriteMatrixToFile(int[,] matrix, string filename)
    {
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string str = "";
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                str += matrix[i, j] + " ";
            }
            str += "\n";
            File.AppendAllText(filename,str);
        }
    }
}
