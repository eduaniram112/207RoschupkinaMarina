using System;

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    private Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public static Student Parse(string line)
    {
        int grade;
        string[] str = line.Split();
        if (!int.TryParse(str[1],out grade))
        {
            throw new ArgumentException("Incorrect input mark");
        }
        if (str[0].Length < 3 || Char.IsLower(str[0][0]))
        {
            throw new ArgumentException("Incorrect name");
        }
        if (grade<0 || grade > 10)
        {
            throw new ArgumentException("Incorrect mark");
        }
        return new Student(str[0], grade);
    }

    public override string ToString()
    {
        return Name + " got a grade of " + Grade+".";
    }
}