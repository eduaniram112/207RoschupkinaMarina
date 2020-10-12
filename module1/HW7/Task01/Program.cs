using System;
using System.IO; 
using System.Text; 
//задача 3 из презентации 7
class Program
{
    static Random rand = new Random();

    private static string GenerateString()
    {
        string message = string.Empty;
        int length = rand.Next(20, 51);
        for (int j = 0; j < length; j++)
        {
            message += (char)rand.Next('А', 'Я');
        }

        return message;
    }

    private static string AddDot(string fileName, Encoding enc, string message)
    {
        Random t = new Random();
        int toch = t.Next(0, 2);
        if (toch == 1) { message += "." + Environment.NewLine; }
        else { message += Environment.NewLine; }
        File.AppendAllText(fileName, message, enc);
        Console.Write(message);
        return message;
    }

    private static void WriteStrings(string[] messages)
    {
        foreach (string item in messages)

            if (item[item.Length - 1] == '.') { Console.WriteLine(item.Substring(0, item.Length - 1)); }
            else { Console.WriteLine(item.Substring(0, item.Length)); }
    }

    static void Main()
    {

        const string fileName = "dialog.txt";
        Encoding enc = Encoding.Unicode;
        const int linesCount = 6;


        File.WriteAllText(fileName, string.Empty, enc);
        Console.WriteLine("Переписка до форматирования:");

        for (int i = 0; i < linesCount; i++)
        {
            string message = GenerateString();
            message = AddDot(fileName, enc, message);
        }

        string[] messages = File.ReadAllLines(fileName, enc);
        Console.WriteLine(Environment.NewLine + "Переписка после форматирования:");

        WriteStrings(messages);

        Console.ReadKey();
    }

 


}