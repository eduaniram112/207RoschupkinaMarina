using System;
using System.Collections.Generic;

internal static class Program
{

    private static void Main(string[] args)
    {
        String[] str = Console.ReadLine().Split(",");
        int[,] arr = new int[str.Length,str.Length];
        //Console.WriteLine(str.Length);

        for(int i = 0; i<str.Length; i++)
        {
            bool y = int.TryParse(str[i], out arr[0, i]);
        }
        
        for (int i = 1; i < str.Length; i++)
        {
            arr[i, str.Length - 1] = arr[i-1, 0] ;

            for (int j = 1; j < str.Length; j++)
            {
                arr[i, j - 1] = arr[i - 1, j];
            }

        }

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();

        }



    }
}