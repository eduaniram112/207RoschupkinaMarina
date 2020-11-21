using System;
using System.Collections.Generic;

public class Grassland
{
    public List<Sheep> Sheeps;
    public Grassland(List<Sheep> sheeps)
    {
        Sheeps = new List<Sheep>(sheeps);
    }

    public List<Sheep> GetEvenSheeps()
    {
        List<Sheep> EvenSheeps = new List<Sheep>();
        foreach (Sheep shaun in Sheeps)
        {
            if (shaun.ID % 2 == 0) EvenSheeps.Add(shaun);
        }
        return EvenSheeps;
    }

    public List<Sheep> GetOddSheeps()
    {
        List<Sheep> OddSheeps = new List<Sheep>();
        foreach (Sheep shaun in Sheeps)
        {
            if (shaun.ID % 2 != 0) OddSheeps.Add(shaun);
        }
        return OddSheeps;
    }

    public List<Sheep> GetSheepsByContainsName(string name)
    {
        List<Sheep> FavSheeps = new List<Sheep>();
        foreach (Sheep shaun in Sheeps)
        {
            if (shaun.Name.Contains(name)) FavSheeps.Add(shaun);
        }
        return FavSheeps;
    }
}
