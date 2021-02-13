using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split();
        int[] arr = new int[str.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(str[i]);
        }
        Console.WriteLine(arr.Average().ToString("F3"));
    }
}