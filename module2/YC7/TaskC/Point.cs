using System;

public class Point 
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override bool Equals(object obj)
    {
        Point b = obj as Point;
        if (this.X == b.X && this.Y == b.Y && this.Z == b.Z) return true;
        return false;
    }

    public override int GetHashCode() => X.GetHashCode();

    public override string ToString() => X + " " + Y + " " + Z;
}