using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{
    static bool Validate(int n)
    {
        if (n < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static int DivisorsSum(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0) { sum += i; }
        }
        return sum;
    }
}
