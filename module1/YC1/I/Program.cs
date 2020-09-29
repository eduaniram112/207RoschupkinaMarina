using System;

namespace I
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            bool x = double.TryParse(Console.ReadLine(), out a);


            if (x == true) //проверяем что у нас число
            {
                double b = Math.Abs(a - (int)a);

                if (b<0.5) { Console.WriteLine((int)a); }
                else if (b>0.5) {
                    if (a >= 0) { Console.WriteLine((int)(a) + 1); }
                    else { Console.WriteLine((int)(a) - 1); }
                }
                else
                {
                    
                    if (a >= 0) {
                        if ((int)a % 2 == 1)
                        {
                            Console.WriteLine((int)a);
                        }
                        else
                        {
                            Console.WriteLine((int)(a) + 1);
                        }
                    }
                    else {
                        if ((int)a*(-1) % 2 == 1)
                        {
                            Console.WriteLine((int)a);
                        }
                        else
                        {
                            Console.WriteLine((int)(a) - 1);
                        }

                    }

                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

            //Console.WriteLine((int)a);
        }
    }
}
