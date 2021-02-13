using System;

internal class ChristmasArray : BaseArray
{

    public ChristmasArray(int[] array) : base(array)
    {

    }


    public override int this[int number]
    {
        get
        {
            int closest = -1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i]<number && array[i] > closest)
                {
                    closest = array[i];
                }

            }
            if (closest == -1) throw new ArgumentException("Number does not exist.");
            return closest;
            
        }
        
    }


    public override double GetMetric()
    {
        int sixs = 0;
        int all = 0;
        for (int i = 0; i < array.Length; i++)
        {
            string s = array[i].ToString();
            sixs += s.Length - s.Replace("6", "").Length;
            all += array[i].ToString().Length;
        }
        return sixs/(double)all;
    }
}