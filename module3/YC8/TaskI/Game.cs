using System;

public delegate void AtackHeroOnPosition(Mob hero, int position);
public class Game
{
    public int CastlePosition { get; set; }
    public int CountOfMonsters { get; set; }

    private Hero MyHero;
    private Boss MyBoss;

    public AtackHeroOnPosition attackHero;

    public Game(int castlePosition, int countOfMonster, Hero hero, Boss boss)
    {
        CastlePosition = castlePosition;
        CountOfMonsters = countOfMonster;
        MyHero = hero;
        MyBoss = boss;
    }
    public void Play()
    {

        for (int i = 0; i < CastlePosition; i++)
        {
            if (MyHero.HP <= 0)
            {
                Console.WriteLine("You Lose! Game over!");
                return;
            }
            attackHero?.Invoke(MyHero, i);
        }

        if (MyHero.HP <= 0)
        {
            Console.WriteLine("You Lose! Game over!");
            return;
        }

        MyHero.AttackMob(MyBoss);

        if (MyHero.HP <= 0)
        {
            Console.WriteLine("You Lose! Game over!");
            return;
        }

        if (MyHero.IsHpMoreThen75()) Console.WriteLine("You win! Princess released!");
        else Console.WriteLine("Thank you, Mario! But our princess is in another castle... You lose!");


    }
}
