using System.Collections.Generic;
using System.IO;
using System.Linq;

public partial class Program
{
    private const string InputPath = "/Users/MarinaRoshupkina/Projects/2020-2021/module2/YC7/TaskC/input.txt";
    private const string OutputPath = "/Users/MarinaRoshupkina/Projects/2020-2021/module2/YC7/TaskC/output.txt";


    public static void Main()
    {
        List<Point> points = GetPoints();
        HashSet<Point> uniquePoints = GetUnique(points);
        
        using var sw = new StreamWriter(OutputPath);
        sw.WriteLine(points.Count);
        sw.WriteLine(uniquePoints.Count);
        uniquePoints.ToList().ForEach(sw.WriteLine);
    }
}