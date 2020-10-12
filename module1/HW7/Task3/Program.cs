using System;
using System.IO;
using System.Linq;
//6 задача из презентации 7
namespace Task3
{
    class Program
    {
        private static string GetTextFromFile(string inputPath)
        {
            return File.ReadAllText(inputPath);
        }

        private static int GetNumberOfNum(string text)
        {
            string[] str2 = text.Split(new Char[] { ' ', '\n', '.', '!', '?', ',' });
            int k = 0;
            for (int i = 0; i < str2.Length; i++)
            {
                int n;
                bool x = int.TryParse(str2[i], out n);
                if (x) { k++; }
            }
            return k;
        }

        private static int[] GetNumbers(string text)
        {
            string[] str2 = text.Split(new Char[] { ' ', '\n', '.', '!', '?', ',' });
            int[] num = new int[GetNumberOfNum(text)];
            int k = 0;
            for (int i = 0; i < str2.Length; i++)
            {
                int n;
                bool x = int.TryParse(str2[i], out n);
                if (x) { num[k] = n;k++; }
            }
            return num;
        }

        static void Main(string[] args)
        {
            string inputPath = "../../../text.txt";
            string str = GetTextFromFile(inputPath);
            int[] numbers = GetNumbers(str);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(numbers.Average());
        }
    }
}
