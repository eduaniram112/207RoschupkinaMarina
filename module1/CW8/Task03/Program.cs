using System;

namespace Task03
{
    class Program
    {

        static int CS(int x)
        {
            int sum = 0;
            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }

        static int CD(int x)
        {
            int n = 0;
            while (x > 0)
            {
                n++;
                x /= 10;
            }
            return n;
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a and b");
                int a,b;
                bool flag = false;
                string s = Console.ReadLine();
                bool y = int.TryParse(s.Split()[0], out a);
                bool z = int.TryParse(s.Split()[1], out b);
                if (y && z)
                {
                    Console.WriteLine("CD = CS");
                    for (int i = a; i <= b; i++)
                    {
                        if (CD(i) == CS(i))
                        {
                           Console.WriteLine(i);
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        Console.WriteLine("2CD = CS");
                        for (int i = a; i <= b; i++)
                        {
                            if (2*CD(i) == CS(i))
                            {
                                Console.WriteLine(i);
                                flag = true;
                            }
                        }
                    }
                    if (!flag)
                    {
                        Console.WriteLine(":(");
                    }

                }
                else
                {
                    Console.WriteLine("error");
                }

            }
        }
    }
}
