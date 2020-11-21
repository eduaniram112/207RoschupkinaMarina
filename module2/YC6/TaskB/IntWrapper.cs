using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IntWrapper
{
    int number;
    public IntWrapper(int number)
    {
        this.number = number;
    }

    public int FindNumberLength()
    {
        if (number<0) throw new ArgumentException("Number should be non-negative.");
        if (number == 0) return 1;
        else
        {   int length = 0;
            while (number > 0)
            {
                number /= 10;
                length++;
            }
            return length;
        }
    }
}
