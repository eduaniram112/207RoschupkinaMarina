using System;

internal class Hipster
{
    private int money;
    private int donate;

    public int Money => money;
    public int Donate => donate;

    public Hipster(int money, int donate)
    {
        this.money = money;
        this.donate = donate;
    }

    public int GetMoney()
    {
        if (money > donate)
        {
            money -= donate;
        }
        else
        {
            donate = money;
            money = 0;
        }
        return donate;

    }
}