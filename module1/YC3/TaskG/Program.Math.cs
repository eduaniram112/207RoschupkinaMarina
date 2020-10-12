using System;
using System.Linq;

partial class Program
{
    private static double GetMin(double[] array)
    {
        return array.Min();
    }

    private static double GetAverage(double[] array)
    {
        
        return array.Sum() / array.Length;

    }

    private static double GetMedian(double[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        if (array.Length % 2 == 0) return (array[array.Length / 2] + array[(array.Length / 2) - 1]) / 2;
        return array[array.Length / 2];

    }
    
    private static double[] ReadNumbers(string line)
    {
        //int[] array = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        string[] e = line.Split(' ');
        double[] ar = new double[e.Length];
        for (int i = 0; i < e.Length; i++)
        {
            ar[i] = Convert.ToDouble(e[i]);
        }
        return ar;

    }
    
}