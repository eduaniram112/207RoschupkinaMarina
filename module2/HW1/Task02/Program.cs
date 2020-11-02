using System;
using System.Linq;
//7 задача из презентации 1
namespace Task02
{
    class Program
    {
        static string[] Filials = { "Западный", "Центральный", "Восточный" };
        static string[] Kvartal = { "I", "II", "III", "IV" };
        static int[,] auto = { { 20, 24, 25 }, // I
                { 21, 20, 18 }, // II
                { 23, 27, 24 }, // III
                { 22, 19, 20 }  // IV
            };


        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += auto[i, j];
                }
            }
            Console.WriteLine("1 " + sum);

            int max=0, maxind=0, maxname=0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (auto[i, j] > max) { max = auto[i, j]; maxind = i; maxname = j; }
                }
            }
            Console.WriteLine("2 " + max + " " + Kvartal[maxind] + " " + Filials[maxname]);

            int[] year = new int[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    year[i] += auto[j, i];
                }
            }
            int ind = Array.IndexOf(year,year.Max());
            Console.WriteLine("3 " + year[ind] +  " " + Filials[ind]);

            int[] kv = new int[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    kv[i] += auto[i, j];
                }
            }
            int ind2 = Array.IndexOf(kv, kv.Max());
            Console.WriteLine("4 " + kv[ind2] + " " + Kvartal[ind2]);



        }
    }
}
