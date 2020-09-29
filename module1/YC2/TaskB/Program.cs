using System;

class Program
{
    static void Main(string[] args)
    {
        int a, sum = 0;
        bool x = int.TryParse(Console.ReadLine(), out a);
        while (true)
        {
            if (a % 2 != 0) { sum += a; }
            if (a == 0 || x==false) break;
         
            x = int.TryParse(Console.ReadLine(), out a);
        }
        if (x == true)
        {
            Console.WriteLine(sum);
        }
        else { Console.WriteLine("Incorrect input"); }
        
    }
    
}
