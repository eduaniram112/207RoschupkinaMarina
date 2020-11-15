using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public partial class Program
{
    public static bool ParseCommandsCount(string input, out int count)
    {
        bool x = int.TryParse(input, out count);
        if (count > 0 && x)
        {
            return true;
        }
        return false;
    }

    public class Logger
    {
        static List<string> logs = new List<string>();
        static string filename = "logs.log";
        //static string filename = "/Users/MarinaRoshupkina/Projects/2020-2021/module2/YC5/TaskG/log.txt";
        private static Logger logger;

        /*
        public static Logger GetLogger()
        {
            throw new NotImplementedException();
        }*/

        public static void HandleCommand(string command)
        {
            string[] com = command.Split();
            if (com[0] == "AddLog")
            {
                string newlog = com[1].Substring(1, com[1].Length - 2);
                logs.Add(newlog);

            }
            if (com[0] == "DeleteLastLog")
            {
                if (logs.Any())
                {
                    logs.RemoveAt(logs.Count - 1);
                }
                else
                {
                    File.AppendAllText(filename, "No active logs\n");
                }

            }
            if (com[0] == "WriteAllLogs")
            {
                if (logs.Any())
                {
                    File.AppendAllLines(filename, logs);
                }
                else
                {
                    File.AppendAllText(filename, "No active logs\n");
                }
                logs.Clear();
                // List<string> lines = File.ReadAllLines(filename).ToList();

                //File.WriteAllLines(filename, lines.GetRange(0, lines.Count - 1).ToArray());

            }
            //Console.WriteLine(logs.Capacity);

        }

    }

}