using System;
using System.Data;

partial class Program
{
    public static double Ev(string a)
    {
        DataTable t = new DataTable();
        t.Columns.Add("a", typeof(string), a);
        DataRow row = t.NewRow();
        t.Rows.Add(row);
        return double.Parse((string)row["a"]);
    }

    public static void Main(string[] args)
    {
        string a = Console.ReadLine();
        Console.WriteLine(Ev(a));
    }
}