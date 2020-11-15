using System;

partial class Program
{
    static int[][] GetBellTriangle(uint rowCount)
    {
        int[][] array = new int[rowCount][];
        array[0] = new int[1];
        array[0][0] = 1;
        if (rowCount > 1)
        { 
        array[1] = new int[2];
        array[1][0] = 1;
        array[1][1] = 2;
        for (int i = 2; i < rowCount; i++)
        {
            array[i] = new int[i + 1];
            array[i][0] = array[i - 1][i - 1];

            for (int j = 1; j <= i; j++)
            {
                array[i][j] = array[i - 1][j - 1] + array[i][j - 1];


            }
        }
        }
        return array;
    }

    private static void PrintJaggedArray(int[][] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

