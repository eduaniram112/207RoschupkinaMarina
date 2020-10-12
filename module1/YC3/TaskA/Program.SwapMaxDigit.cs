using System;
using System.Linq;

partial class Program
{
    private static bool TryParseInput(string inputA, string inputB, out int a, out int b)
    {
        bool x = int.TryParse(inputA, out a);
        bool y = int.TryParse(inputB, out b);
        if (x == false || y == false || a<0 || b<0) return false;
        else return true;

    }

    static int[] IntToArr(int a)
    {
        int copy_a = a, n = 0;
        if (copy_a != 0)
        {
            while (copy_a > 0)
            {
                copy_a /= 10;
                n++;
            }
            int[] arr = new int[n];
            copy_a = a;

            for (int i = 0; i < n; i++)
            {
                arr[i] = copy_a % 10;
                copy_a /= 10;
            }
            Array.Reverse(arr);
            return arr;
        }
        else
        {
            int[] arr = new int[1];
            arr[0] = 0;
            return arr;
        }


    }

    private static void SwapMaxDigit(ref int a, ref int b)
    {
        int copy_a = 0;
        int copy_b = 0;
        int[] a_arr = IntToArr(a);
        int[] b_arr = IntToArr(b);

        int max_a = a_arr.Max();
        int max_b = b_arr.Max();
        

        Array.Reverse(a_arr);
        Array.Reverse(b_arr);

        for (int i = 0; i < a_arr.Length; i++)
        {
            if (a_arr[i] == max_a) a_arr[i] = max_b;
            copy_a += a_arr[i] * (int)Math.Pow(10, i);
        }

        for (int i = 0; i < b_arr.Length; i++)
        {
            if (b_arr[i] == max_b) b_arr[i] = max_a;
            copy_b += b_arr[i] * (int)Math.Pow(10, i);

        }
        
        a = copy_a;
        b = copy_b;


    }
}