using System;
using System.IO;
using System.Linq;

//1 задача со слайда 33 из презентации 7
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

        private static bool[] Bool(int[] array)
        {
            bool[] numbers = new bool[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) { numbers[i] = true; }
                else numbers[i] = false;
            }
            return numbers;
        }

        private static string BoolToText(bool[] array)
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
            //bool[] boolnum = Bool(num);
            //File.WriteAllText(outPath, BoolToText(boolnum));
            File.WriteAllText(outPath, BoolToText(Bool(GetArrayFromFile(inputPath))));

        }
           
    }
}
