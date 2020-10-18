using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("oh no");
            }
            finally
            {
                Console.WriteLine("well");
            }

        }
    }
}
