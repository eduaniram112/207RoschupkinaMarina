using System;

internal class Program
{
    private const string Path = "/Users/MarinaRoshupkina/Projects/2020-2021/module2/EX2/TaskI/input.txt";
    
    public static void Main(string[] args)
    {
        int[] arr = Reader.ReadFile(Path);
        Console.WriteLine(string.Join(" " ,arr));
    }
}