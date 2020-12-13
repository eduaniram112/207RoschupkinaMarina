using System;

public class Brigantine : Boat
{
    public Brigantine(int value, bool isAtThePort) : base(value, isAtThePort)
    {
        Cost = value;
        IsAtThePort = isAtThePort;
    }

    public new int CountCost(int weight)
    {
        if (weight <= 500) return Cost * Cost * weight;
        else return Cost * weight;
    }
}