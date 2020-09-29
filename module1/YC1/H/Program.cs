using System;

namespace H
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            bool x = char.TryParse(Console.ReadLine(), out a);


            if (x == true && Char.IsLower(a)) //проверяем что у нас маленькая буква
            {

                Console.WriteLine((int)a-96);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            
            //Console.WriteLine((int)a);

        }
    }
}
