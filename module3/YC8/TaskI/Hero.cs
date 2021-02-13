using System;

public class Hero : Mob
{
    public int StartHP { get; set; }
    public Hero(int hp, int attack) : base(hp,attack)
    {
        //HP = hp;
        StartHP = hp;
        //Attack = attack;
    }

    public override string ToString()
    {
        return $"Mario with HP = {HP} and attack = {Attack}";
    }

    public bool IsHpMoreThen75()
    {
        if ((double)HP/StartHP >= 0.75) return true;
        else return false;
    }
}

