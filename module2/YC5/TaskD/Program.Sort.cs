using System;

public partial class Program
{
    static bool ParseArrayFromLine(string line, out int[] arr)
    {
        string[] str = line.Split();
        bool flag = true;
        arr = new int[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            bool x = int.TryParse(str[i], out arr[i]);
            if (!x)
            {
                flag = false;
            }
        }
        return flag;
    }


    private static void Merge(int[] arr, int left, int right, int mid)
    {
        int tl = left, tr = mid, ind = 0;
        int[] tarr = new int[right - left];

        while (tl < mid && tr < right)
        {
            if (arr[tl] < arr[tr])
            {
                tarr[ind] = arr[tl];
                tl++;
            }
            else
            {
                tarr[ind] = arr[tr];
                tr++;
            }

            ind++;
        }

        for (int i = tl; i < mid; i++)
        {
            tarr[ind] = arr[i];
            ind++;
        }

        for (int i = tr; i < right; i++)
        {
            tarr[ind] = arr[i];
            ind++;
        }

        for (int i = 0; i < tarr.Length; i++)
        {
            arr[left + i] = tarr[i];
        }

    }

}