using System;

partial class Program
{
    public static void Main(string[] args)
	{
        Matrix matrix = new Matrix("/Users/MarinaRoshupkina/Projects/2020-2021/module2/YC5/TaskH/matrix.txt");
        Console.Write(matrix);
        Console.WriteLine(matrix.SumOffEvenElements);
    }
}

