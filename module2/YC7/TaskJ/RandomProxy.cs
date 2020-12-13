using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class User
{
    public string Login { get; set; }
    public int Age { get; set; }
    public User(string login, int age)
    {
        Login = login;
        Age = age;
    }
}

class RandomProxy
{
    StreamWriter log;

    public Random rand = new Random(1579);
    List<User> users;
    public RandomProxy(StreamWriter log)
    {
        this.log = log;
        users = new List<User>();
    }

    public void Register(string login, int age)
    {
        if (users.Exists(x => x.Login == login))
            throw new ArgumentException($"User {login}: login is already registered");
        users.Add(new User(login, age));
        log.WriteLine($"User { login}: login registered");

    }

    public int Next(string login)
    {
        int numb;
        if (!users.Exists(x => x.Login == login))
            throw new ArgumentException($"User {login}: login is not registered");

        User u = users.Find(x => x.Login == login);
        if (u.Age < 20)
        {
            numb = rand.Next(0, 1000);
        }
        else
        {
            numb = rand.Next(0, int.MaxValue);
        }
        log.WriteLine($"User {login}: generate number {numb}");
        return numb;

    }

    public int Next(string login, int maxValue)
    {
        int numb;
        if (!users.Exists(x => x.Login == login))
            throw new ArgumentException($"User {login}: login is not registered");

        User u = users.Find(x => x.Login == login);
        if (u.Age < 20 && maxValue>1000)
        {
            throw new ArgumentOutOfRangeException($"User {login}: random bounds out of range");
        }
        else
        {
            numb = rand.Next(0, maxValue);
        }
        log.WriteLine($"User {login}: generate number {numb}");
        return numb;
    }

    public int Next(string login, int minValue, int maxValue)
    {
        int numb;
        if (!users.Exists(x => x.Login == login))
            throw new ArgumentException($"User {login}: login is not registered");

        User u = users.Find(x => x.Login == login);
        if (u.Age < 20 && maxValue-minValue > 1000)
        {
            throw new ArgumentOutOfRangeException($"User {login}: random bounds out of range");
        }
        else
        {
            numb = rand.Next(minValue, maxValue);
        }
        log.WriteLine($"User {login}: generate number {numb}");
        return numb;
    }

}
