using System;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int kv = 12345678 % 1000000 / 100;
            Console.WriteLine(kv);
        }
    }
}
