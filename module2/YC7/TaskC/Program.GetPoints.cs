using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public partial class Program
{
    /// <summary>
    /// Считывает точки в список.
    /// </summary>
    /// <returns>Список точек.</returns>
    private static List<Point> GetPoints()
    {
        List<Point> points = new List<Point>();
        //string InputPath = "/Users/MarinaRoshupkina/Projects/2020-2021/module2/YC7/TaskC/input.txt";
        string InputPath = "input.txt";
        string[] str = File.ReadAllLines(InputPath);
        foreach(string s in str)
        {
            string[] par = s.Split();
            Point p = new Point(int.Parse(par[0]), int.Parse(par[1]), int.Parse(par[2]));
            points.Add(p);
        }
        return points;
    }


    /// <summary>
    /// Получает коллекцию уникальных точек.
    /// </summary>
    /// <param name="points">Список исходных точек.</param>
    /// <returns>Коллекция точек.</returns>
    private static HashSet<Point> GetUnique(List<Point> points)
    {
        HashSet<Point> points1 = new HashSet<Point>();
        //points = (List<Point>)points.Distinct().ToHashSet();
        foreach (Point p in points)
        {

            if (!points1.Contains(p)) points1.Add(p);
        }
        return points1;
    }
}