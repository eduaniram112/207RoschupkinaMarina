using System;

class Linguist : Editor
{
    string BannedWord { get; set; }
    private Linguist(string name, int salary, string bannedWord) : base(name, salary)
    {
        Name = name;
        Salary = salary;
        BannedWord = bannedWord;
    }

    public new string EditHeader(string header)
    {
        return base.EditHeader(header.Replace(BannedWord, ""));
    }

    public static Linguist Parse(string line)
    {
        string[] words = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        if (words.Length != 3 || !int.TryParse(words[1], out int payment) || payment < 0)
        {
            throw new ArgumentException("Incorrect input");
        }

        return new Linguist(words[0], payment, words[2]);
    }
}