using System;
using System.Linq;

public partial class Program
{
    static bool IsArrayLengthCorrect(int length)
    {
        if (length > 0) { return true; }
        return false;

    }

    static bool GenerateArray(int length, out int[] arr)
    {
        bool flag = true;
        arr = new int[length];
        for (int i = 0; i < length;i++)
        {
            bool x = int.TryParse(Console.ReadLine(), out arr[i]);
            if (!x) { flag = false; }
        }
        return flag;

    }

    public static double GetArrayAverage(int[] arr)
    {
        return arr.Average();
    }

    public static int GetSumOfNumbersLessThanAverage(int[] arr, double average)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < average) { sum += arr[i]; }
        }
        return sum;
    }
}