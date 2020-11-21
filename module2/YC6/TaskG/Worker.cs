using System;
using System.Collections.Generic;
using System.Linq;

public class Worker
{
    Apple[] Apples;
    public Worker(Apple[] apples)
    {
        Apples = new Apple[apples.Length];
        for (int i = 0; i < apples.Length; i++)
        {
            Apples[i] = apples[i];
        }
    }

    public Apple[] GetSortedApples()
    {
        Array.Sort(Apples);
        Apple[] ap = new Apple[Apples.Length];
        for (int i = 0; i < Apples.Length; i++)
        {
            ap[i] = Apples[i];
        }
        return ap;
    }
}