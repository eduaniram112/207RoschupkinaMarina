using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{
    static int Count(int[] arr, int k)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i!=j && arr[i] + arr[j] == k)
                {
                    sum++;
                }

            }

        }
        return sum/2;
    }
}
