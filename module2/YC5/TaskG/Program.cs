using System;
using System.IO;

public partial class Program
{
    static void Main(string[] args)
    {
        int count;

        if (!ParseCommandsCount(Console.ReadLine(), out count))
        {
            File.WriteAllText("/Users/MarinaRoshupkina/Projects/2020-2021/module2/YC5/TaskG/log.txt", "Incorrect input");
            //return;
        }
        //Console.WriteLine("aaa");
        for (int i = 0; i < count; i++)
        {
            Logger.HandleCommand(Console.ReadLine());
        }
    }
}