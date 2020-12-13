using System;

namespace Task02
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Abr.ValidatedSplit(Console.ReadLine(), ';');
            foreach (string str in input)
            {
                Console.WriteLine(Abr.Abbrevation(str));
            }

        }

    }

}
