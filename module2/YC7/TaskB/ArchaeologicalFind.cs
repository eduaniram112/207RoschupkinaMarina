using System;
using System.Collections.Generic;
#pragma warning disable

public class ArchaeologicalFind
{
    static int FNumber = 0;
    int Age;
    int Weight;
    string Name;
    int number = 0;
    public ArchaeologicalFind(int age, int weight, string name)
    {
        if (age > 0) Age = age;
        else throw new ArgumentException("Incorrect age");

        if (weight > 0) Weight = weight;
        else throw new ArgumentException("Incorrect weight");

        if (name != "?") Name = name;
        else throw new ArgumentException("Undefined name");
    }
    
    /// <summary>
    /// Добавляет находку в список.
    /// </summary>
    /// <param name="finds">Список находок.</param>
    /// <param name="archaeologicalFind">Находка.</param>
    public static void AddFind(ICollection<ArchaeologicalFind> finds, ArchaeologicalFind archaeologicalFind)
    {
        bool InFinds = false;
        foreach (ArchaeologicalFind f in finds)
        {
            if (f.Equals(archaeologicalFind)) InFinds = true;
        }
        if (!InFinds)
        {
            archaeologicalFind.number = FNumber;
            finds.Add(archaeologicalFind);
           
        }
        FNumber++;
    }


    public static int TotalFindsNumber => FNumber;

    public override bool Equals(object obj)
    {
        ArchaeologicalFind b = obj as ArchaeologicalFind;
        if (this.Age == b.Age && this.Weight == b.Weight && this.Name == b.Name)
        {
            return true;
        }
        return false;
    }

    public override string ToString() => number + " " + Name + " " + Age + " " + Weight;
}