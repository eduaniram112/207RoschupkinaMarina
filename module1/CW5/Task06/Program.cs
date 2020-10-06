using System;

namespace Task06
{
    class Program
    {
        static int S(int n,int k)
        {

            if (n == k && n >= 0) { return 1; }
            if (n == 0 && k>0 ) { return 0; }
            if (k == 0 && n > 0) { return 0; }
            else { return S(n - 1, k - 1) + k * S(n - 1, k); }
        }
        static void Main(string[] args)
        {
            int n, k;
            bool x = int.TryParse(Console.ReadLine(), out n);
            bool y = int.TryParse(Console.ReadLine(), out k);
            Console.WriteLine(S(n, k));
        }
    }
}
