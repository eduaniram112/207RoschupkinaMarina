using System;

public class Boat
{
    public bool IsAtThePort { get; set; }
    public int Cost { get; set; }

    public Boat(int value, bool isAtThePort)
    {
        IsAtThePort = isAtThePort;
        Cost = value;
    }

    public int CountCost(int weight)
    {
        return weight * Cost;
    }

}


