using System;
using System.IO;
using System.Linq;

//2 задача со слайда 33 из презентации 7
namespace Task04
{
    class Program
    {
        private static int[] GetArrayFromFile(string inputPath)
        {
            string[] str = File.ReadAllText(inputPath).Split(" ");
            int[] numbers = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                numbers[i] = Convert.ToInt32(str[i]);
            }
            return numbers;
        }

        private static int[] Log(int[] array)
        {
            int[] numbers = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                numbers[i] = (int)Math.Pow(2, (int)Math.Log2(array[i]));
            }
            return numbers;
        }

        private static string IntToText(int[] array)
        {
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i] + " ";
            }
            return str;
        }


        static void Main(string[] args)
        {
            string inputPath = "../../../input.txt";
            string outPath = "../../../output.txt";

            //int[] num = GetArrayFromFile(inputPath);
            //int[] lognum = Log(num);
            //File.WriteAllText(outPath, IntToText(lognum));
            File.WriteAllText(outPath, IntToText(Log(GetArrayFromFile(inputPath))));

        }

    }
}