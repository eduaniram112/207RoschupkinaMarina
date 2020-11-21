using System;


public partial class Program
{
    static Sheep ParseSheep(string line)
    {
        string[] str = line.Split();
        string name = str[1];
        string sound = str[6];
        int id;
        bool idbool = int.TryParse(str[4], out id);
        if (!idbool || id <= 0 || id >= 1000) throw new ArgumentException("Incorrect input");

        Sheep shaun = new Sheep(id,name,sound);
        return shaun;
    }
}
