using System;

public abstract class Mob
{
    public int HP { get; set; }
    public int Attack { get; set; }
    public Mob(int hp, int attack)
    {
        HP = hp;
        Attack = attack;
    }
    
    public void AttackMob(Mob other)
    {
        while (this.HP > 0 && other.HP > 0)
        {
            
            Console.WriteLine(this.ToString() + " attacked " + other.ToString());
            Console.WriteLine(other.ToString() + " attacked " + this.ToString());
            other.HP -= this.Attack;
            this.HP -= other.Attack;

        } 
    }
}