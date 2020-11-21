
using System;

public class Sheep
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Sound { get; set; }

    public Sheep(int id, string name, string sound)
    {
        ID = id;
        Name = name;
        Sound = sound;
    }
    public override string ToString()
    {
        return "[" + ID + "-" + Name + "]: " + Sound + "..." + Sound;
    }

}
