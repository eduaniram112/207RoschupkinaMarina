using System;
using System.IO;

public class Knight : LegendaryHuman
{
    string[] Equipment;
    public Knight(string name, int healthPoints, int power, string[] equipment) : base(name, healthPoints, power)
    {

        if (equipment.Length > 0)
        {
            Equipment = new string[equipment.Length];
            for (int i = 0; i < equipment.Length; i++)
            {
                Equipment[i] = equipment[i];
            }
        }
        else throw new ArgumentException("Not enough equipment.");

    }
    public override string ToString()
    {
        return "Knight " + Name + " with HP " + HealthPoints;
    }

    public override void Attack(LegendaryHuman enemy)
    {

        if (HealthPoints > 0 && enemy.HealthPoints > 0)
        {
            Console.WriteLine(this + " attacked " + enemy + ".");
            int attack = Power + 10 * Equipment.Length;
            enemy.HealthPoints -= attack;

            if (enemy.HealthPoints <= 0)
            {
                Console.WriteLine(enemy + " is dead.");
            }
        }


        

    }


}