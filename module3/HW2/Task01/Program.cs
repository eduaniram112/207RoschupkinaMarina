using System;
// задача 5 из презентации 3
namespace Task01
{
    public delegate void MethodEvents();
    public delegate void ItemEvents(int[,] arr);

    static class ArrayOperations
    {
        public static event MethodEvents LineComplete;
        public static event ItemEvents NewItemFilled;

        public static void PrintArray(int[,] arr)
        {

            int cntr = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write(arr[i, j] + " \t");
                    cntr++;
                    if (cntr % 5 == 0) LineComplete?.Invoke();
                }
            }
        }

        public static void FillArray(int[,] arr, int lowerBound = 0, int upperBound = 100)
        {
            Random rand = new Random();
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    arr[i, j] = rand.Next(lowerBound, upperBound);
                    NewItemFilled?.Invoke(arr);
                }
            }
        }

        private static int ArrSum(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    sum += arr[i, j];
                }
            }

            return sum;
        }

        public static void ArrMax(int[,] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    if (arr[i, j] > max) max = arr[i, j];
                }
            }
            Console.WriteLine("max: " + max);
        }

        public static void ArrSumPrint(int[,] arr)
        {
            int sum = ArrSum(arr);
            Console.WriteLine("sum: " + sum);
        }

        public static void ArrAv(int[,] arr)
        {
            int sum = ArrSum(arr);
            Console.WriteLine("average: " + (double)sum / arr.Length);
        }

       
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            ArrayOperations.NewItemFilled += ArrayOperations.ArrSumPrint;
            ArrayOperations.NewItemFilled += ArrayOperations.ArrAv;
            ArrayOperations.NewItemFilled += ArrayOperations.ArrMax;

            ArrayOperations.FillArray(arr);

            ArrayOperations.LineComplete += () => { Console.WriteLine(); };
            Console.WriteLine();
            ArrayOperations.PrintArray(arr);
        }
    }
}
