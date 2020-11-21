using System;
using System.Collections.Generic;
using System.IO;

public class Wizard : LegendaryHuman
{
    public string Rank;
    List<string> Ranks = new List<string>() { "Neophyte", "Adept", "Charmer", "Sorcerer", "Master", "Archmage" };
    public Wizard(string name, int healthPoints, int power, string rank) : base(name, healthPoints,
        power)
    {

        if (Ranks.Contains(rank)) Rank = rank;
        else throw new ArgumentException("Invalid wizard rank.");
    }
    public override string ToString()
    {
        return Rank + " Wizard " + Name + " with HP " + HealthPoints;
    }
    public override void Attack(LegendaryHuman enemy)
    {
        if (HealthPoints > 0 && enemy.HealthPoints > 0)
        {
            Console.WriteLine(this + " attacked " + enemy + ".");
            int attack = Power * (int)Math.Pow(Ranks.IndexOf(Rank) + 1, 1.5) + HealthPoints / 10;
            enemy.HealthPoints -= attack;

            if (enemy.HealthPoints <= 0)
            {
                Console.WriteLine(enemy + " is dead.");
            }
        }


    }
}