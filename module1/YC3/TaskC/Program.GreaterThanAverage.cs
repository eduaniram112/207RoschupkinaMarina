using System;

partial class Program
{
    private static int GetCountGreaterThanValue(int[] array, double average)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > average)
            {
                count++;
            }
                
        }
        return count;
    }

    private static double GetAverage(int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }
    
    private static bool ValidateNumber(out int n)
    {
        
        bool x = int.TryParse(Console.ReadLine(), out n);
        if (n >= 0 && x == true ) return true;
        else return false;


    }
    
    private static bool ReadNumbers(int n, out int[] array)
    {
        array = new int[n];
        for (int i = 0; i < n; i++)
        {
            bool x = int.TryParse(Console.ReadLine(), out array[i]);
            if (x == false || array[i]< 0) { return false;}
        }
        return true;


    }
}