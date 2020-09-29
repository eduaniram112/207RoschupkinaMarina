using System;
//1 задача с 10 слайда 4 презентации
namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 21; a++)
            {
                for (int b = 1; b < 21; b++)
                {
                    for (int c = 1; c < 21; c++)
                    {
                        if (a!=b && a!=c && b != c)
                        {
                            if (a * a + b * b == c * c)
                            {
                                Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}",a, b, c);
                            }
                        }
                    }

                }

            }
        }
    }
}
