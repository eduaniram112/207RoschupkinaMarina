using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][][] arr = new char[3][][];
            Random r = new Random();
            arr[0] = new char[3][];
            arr[0][0] = new char[] { (char)r.Next(97,123), (char)r.Next(97, 123) };
            arr[0][1] = new char[] { (char)r.Next(97, 123), (char)r.Next(97, 123), (char)r.Next(97, 123) };
            arr[0][2] = new char[] { (char)r.Next(97, 123), (char)r.Next(97, 123), (char)r.Next(97, 123), (char)r.Next(97, 123) };

            arr[1] = new char[2][];
            arr[1][0] = new char[] { (char)r.Next(97, 123), (char)r.Next(97, 123) };
            arr[1][1] = new char[] { (char)r.Next(97, 123), (char)r.Next(97, 123), (char)r.Next(97, 123) };

            arr[2] = new char[1][];
            arr[2][0] = new char[] { (char)r.Next(97, 123), (char)r.Next(97, 123), (char)r.Next(97, 123), (char)r.Next(97, 123) };
            Console.WriteLine(arr);

            foreach (char[][] a in arr)
            {
                foreach (char[] b in a)
                {
                    foreach (char c in b)
                    {
                        Console.Write($"{c} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine('\n');
            }


        }
    }
}
