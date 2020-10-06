using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0,s=0;
            bool x = int.TryParse(Console.ReadLine(), out n);
            int n2 = n;
            while (n > 0)
            {
                s += 1;
                n /= 10;
                
            }
            char[] a = new char[s];

            for (int i = 0; i < s; i++)
            {
               
                a[i] = (char)(n2 % 10 + '0');
                n2 /= 10;
            }

            
            Array.Reverse(a);

            Console.WriteLine(s);
            for (int i = 0; i < s; i++)
            {
                Console.Write(a[i]+" ");
            }


        }
    }
}
