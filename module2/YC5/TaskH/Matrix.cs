using System;
using System.IO;

internal class Matrix
{
    int[,] matrix;

    public Matrix(string filename)
    {
        string[] str = File.ReadAllLines(filename);
        string[] str2 = str[0].Split(';');
        matrix = new int[str.Length, str2.Length];
        for (int i = 0; i < str.Length; i++)
        {
            string[] st = str[i].Split(';');
            for (int j = 0; j < st.Length; j++)
            {
                bool x = int.TryParse(st[j], out matrix[i, j]);
            }
        }
    }

    public int SumOffEvenElements
    {
        get
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0) sum+=matrix[i,j];
                }

            }
            return sum;
        }
    }


    public override string ToString()
    {
        string str = "";
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                str += matrix[i, j] + "\t";
            }
            str += "\n";
        }
        return str;
    }
}