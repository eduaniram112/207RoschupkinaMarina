using System;
using System.Linq;

namespace Lib01
{
    static public class Class1
    {
        static public int[] IntToArr(int n)
        {
            int[] arr = n.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            return arr;
        }
        static public void Print(int [] arr)
        {
            foreach(int a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}
