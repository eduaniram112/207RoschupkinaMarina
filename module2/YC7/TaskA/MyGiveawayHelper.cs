using System;
using System.Collections.Generic;
using System.Linq;

internal class MyGiveawayHelper
{
    List<String> Logins;
    List<String> Prizes;
    int curNumb;
    int n;
    public MyGiveawayHelper(string[] logins, string[] prizes)
    {
        Logins = new List<string>(logins);
        Prizes = new List<string>(prizes);
        curNumb = 1579;
        n = logins.Length;
    }

    public bool HasPrizes => Prizes.Any();

    public (string prize,string login) GetPrizeLogin()
    {
        string prize = Prizes[0];
        Prizes.RemoveAt(0);
        NewNumber();
        int numb = curNumb % n;
        return (prize, Logins[numb]);
        
    }

    public void NewNumber()
    {
        int kv = curNumb * curNumb % 1000000 /100; //12 3456 78
        curNumb = kv;
        
    }
    
}   