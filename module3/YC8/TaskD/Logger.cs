using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Print(string line);

class Logger
{
    List<LogPair> list = new List<LogPair>();
    public void OutputLogs()
    {
        for(int i = 0; i < list.Count; i++)
        {
            list[i].Method.Invoke(list[i].Log);
        }
    }

    public void MakeLog(Print method, string line)
    {
        list.Add(new LogPair(method, line)); 
    }
}

