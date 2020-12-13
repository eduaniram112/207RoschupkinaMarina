using System;

public class Snowflake
{
    int size;
    int rays;
    int [,]arr;
    public Snowflake(int widthAndHeight, int raysCount)
    {
        if (widthAndHeight <= 0 || widthAndHeight%2 == 0 || (raysCount & (raysCount - 1)) != 0 || raysCount<4)
        {
            throw new ArgumentException("Incorrect input");
        }
        size = widthAndHeight;
        rays = raysCount;
        arr = new int[size,size];
    }
    public void CreateArr()
    {
        for(int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if(i== size / 2  || j == size / 2 )
                {
                    arr[i, j] = 1;
                }
            }
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i % 2 == j % 2 && (Math.Abs(i-j) < (rays - 4) / 4 || Math.Abs(size-1-i-j) < (rays - 4) / 4) && i != size / 2 && j != size / 2)
                {
                    arr[i, j] = 1;
                }
            }
        }

    }

    public override string ToString()
    {
        CreateArr();
        string s="";

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {

                
                if (arr[i, j] == 1)
                {
                    s += "* ";
                }
                else s += "  ";
            }
            s += "\n";
        }
        return s;
    }
}