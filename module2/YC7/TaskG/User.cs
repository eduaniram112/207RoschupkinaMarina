using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class User : IEquatable<User>
{

    public string Name { get; set; }
    public List<string> messages = new List<string>();
    public bool active { get; set; }
    public User(string username)
    {
        Name = username;
        active = true;
    }

    public override string ToString()
    {
        string s = "-"+Name+"-";
        if (messages.Count != 0)
        {
            s += "\nReceived notifications:";
            foreach(string m in messages)
            {
                s += "\n"+m;
            }
        }
        return s;
    }
    public void SendMessage(string text)
    {
        if (this.active)
        {
            Console.WriteLine(this + "\nNew notification: " + text);
            messages.Add(text);
        }
        
    }

    public bool Equals(User other)
    {
        if (this.Name == other.Name) return true;
        return false;
    }
}