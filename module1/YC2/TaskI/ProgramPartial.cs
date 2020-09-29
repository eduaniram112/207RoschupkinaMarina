using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{

    // Проверка входных чисел на корректность
    static bool Validate(int a)
    {
        if (a <= 0) { return false; }
        else { return true; }
    }

    static int GetPerfectNumber(int a)
    {
        int res = 0;
        int n = a;
        while (true)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) { sum += i; }
            }
            if (sum == n) { res = n; break; }
            n++;
            
        }
        return res;
    }
  
}
