using System;

partial class Program
{

    //public delegate int Comparison<in t>(t x, t y);

    public static int CompareLength(int a,int b)
    {
        return a.ToString().Length.CompareTo(b.ToString().Length);
    }

    internal static int[] StrangeSort(int[] arr)
    {
        int[] arr2 = new int[arr.Length];

        for(int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = arr[i];
        }

        Comparison<int> comp = new Comparison<int>(CompareLength);
        Array.Sort<int>(arr2, comp);
        return arr2;
        
    }
}