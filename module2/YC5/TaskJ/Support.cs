using System;
using System.Collections.Generic;

public class Support
{
    private readonly List<Task> tasks = new List<Task>();
    public IEnumerable<Task> Tasks => tasks;
    // Task testtask = new Task(0, "test");
    //tasks.Add(testtask);


    public int OpenTask(string text)
    {
        Task newtask = new Task(tasks.Count + 1, text);
        tasks.Add(newtask);
        return newtask.Id;
    }

    public void CloseTask(int id, string answer)
    {
        tasks[id - 1].Answer = answer;
        tasks[id - 1].IsResolved = true;
    }

    public List<Task> GetAllUnresolvedTasks()
    {
        List<Task> untasks = new List<Task>();
        foreach (Task a in tasks)
        {
            if (a.IsResolved == false)
            {
                untasks.Add(a);
            }
        }
        return untasks;
    }

    public void CloseAllUnresolvedTasksWithDefaultAnswer(string answer)
    {
        foreach (Task a in tasks)
        {
            if (a.IsResolved == false)
            {
                a.IsResolved = true;
                a.Answer = answer;
            }
        }

    }

    public string GetTaskInfo(int id)
    {
        return tasks[id-1].ToString();
    }
}