using System;

class Kikstarter
{
    // Данный тип необходимо обязательно использовать
    public delegate int GetMoneyDelegate();

    GetMoneyDelegate[] getMoney;
    private int m;

    public Kikstarter(int m, Hipster[] hipsters)
    {
        this.m = m;
        int sum=0;
        if (hipsters.Length==0) throw new ArgumentException("Not enough hipsters");
        getMoney = new GetMoneyDelegate[hipsters.Length];
        for (int i = 0; i < hipsters.Length; i++)
        {
            sum += hipsters[i].Money;
            GetMoneyDelegate g = hipsters[i].GetMoney;
            getMoney[i] = g;
        }
        if (sum < m) throw new ArgumentException("Not enough money");
    }

    public int Run()
    {
        int weeks = 0;
        while (m > 0)
        {
            foreach(GetMoneyDelegate g in getMoney)
            {
                m -= g.Invoke();
                //Console.WriteLine(m);
            }
            weeks++;
        }
        return weeks;
    }
}