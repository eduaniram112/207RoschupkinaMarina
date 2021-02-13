using System;

public class Monster : Mob
{
    public int Position { get; set; }

    public Monster(int hp, int attack, int position) : base(hp, attack)
    {
        //HP = hp;
        //Attack = attack;
        Position = position;
    }

    public override string ToString()
    {
        return $"Monster with HP = {HP} and attack = {Attack}";
    }

    public void AttackHero(Mob hero, int position)
    {
        if (position == Position)
        {
            Console.WriteLine($"Mario meet monster on {Position}");
            hero.AttackMob(this);
            //this.AttackMob(hero);
        }
    }
}