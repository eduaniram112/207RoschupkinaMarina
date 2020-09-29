using System;

partial class Program
{
    
    static int Factorial(int value)
    {
        
        if (value == 0) { return 1; }

        else
        {
            int f = 1;
            while (value > 0)
            {
                f = f * value;
                value--;
            }
            return f;
        }
    }

    static bool IsInputNumberCorrect(int number)
    {
        if (number < 0) { return false; }
        else { return true; }
    }
}