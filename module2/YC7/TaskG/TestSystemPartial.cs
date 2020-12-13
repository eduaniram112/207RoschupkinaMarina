using System;
using System.Collections.Generic;

public partial class TestSystem
{
    List<User> users = new List<User>();

    public void Add(string username)
    {
        if (users.Exists(x => x.Name == username) && users.Find(x => x.Name == username).active == true)
            throw new ArgumentException("User already exists");
        if (users.Exists(x => x.Name == username) && users.Find(x => x.Name == username).active == false)
        {
            users.Find(x => x.Name == username).active = true;
            Notifications += users.Find(x => x.Name == username).SendMessage;
        }
        else
        {
            User u = new User(username);
            Notifications += u.SendMessage;
            users.Add(u);
        }
    }

    public void Remove(string username)
    {
        if (!users.Exists(x => x.Name == username))
            throw new ArgumentException("User does not exist");

        Notifications -= users.Find(x => x.Name == username).SendMessage;
        users.Find(x => x.Name == username).active = false;
       
    }

}