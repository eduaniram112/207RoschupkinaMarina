using System;

class Program
{
    public static void Main(string[] args)
    {

        int n = 100, max1=0, max2=-1;
        while (n != 0)
        {
            int.TryParse(Console.ReadLine(), out n);
            if ((n < 100 || n > 150) && n!=0) Console.WriteLine("Incorrect number");
            else
            {
                if (n > max1)
                {
                    max2 = max1;
                    max1 = n;
                }
                else if (n > max2)
                {
                    max2 = n;
                }
            }
        }
        Console.WriteLine(max1);
        Console.WriteLine(max2);

    }
}