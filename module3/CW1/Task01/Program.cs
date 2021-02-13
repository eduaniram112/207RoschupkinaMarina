using System;
using Lib01;

namespace Task01
{
    class Program
    {
        delegate int[] Del1(int p);
        delegate void Del2(int[] arr);

        static void Main(string[] args)
        {
            int a = 12345;
            int[] arr1 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 99 };
            int[] arr2 = { 11, 22, 30, 73, 50, 60, 70, 30, 78, 14 };

            
            Del1 del1 = Class1.IntToArr;
            Del2 del2 = Class1.Print;
            del1.Invoke(a);
            del2.Invoke(del1.Invoke(a));


        }
    }
}

