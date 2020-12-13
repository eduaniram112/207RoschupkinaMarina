using System;
using System.Collections.Generic;

public class Group
{
    List<Student> Students = new List<Student>();
    public Group(Student[] students)
    {
        if (students.Length < 5)
        {
            throw new ArgumentException("Incorrect group");
        }
        foreach(Student s in students)
        {
            Students.Add(s);
        }
    }

    public Student this[int index]
    {
        get
        {
            return Students[index];
        }
        set
        {
            Students[index] = value;
        }
    }

    public int IndexOfMaxGrade()
    {
        int max = -1, indmax = 0;
        for(int i = 0; i < Students.Count; i++)
        {
            if (Students[i].Grade > max)
            {
                max = Students[i].Grade;
                indmax = i;
            }
        }
        return indmax;
    }

    public int IndexOfMinGrade()
    {
        int min = 11, indmin = 0;
        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].Grade < min)
            {
                min = Students[i].Grade;
                indmin = i;
            }
        }
        return indmin;
    }
}