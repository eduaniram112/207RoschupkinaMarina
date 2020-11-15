using System;
using System.IO;

partial class Program
{
    public static void Main(string[] args)
	{
        int[] vector;
        bool valid = TryParseVectorFromFile("/Users/MarinaRoshupkina/Projects/2020-2021/module2/YC5/TaskC/vector.txt", out vector);
        if (!valid)
        {
            File.WriteAllText("/Users/MarinaRoshupkina/Projects/2020-2021/module2/YC5/TaskC/vector.txt", "Incorrect input");
            return;
        }
        int[,] matrix = MakeMatrixFromVector(vector);
        WriteMatrixToFile(matrix, "/Users/MarinaRoshupkina/Projects/2020-2021/module2/YC5/TaskC/matrix.txt");
    }
}

