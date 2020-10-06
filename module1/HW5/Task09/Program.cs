using System;
//6 задача из презентации 5

namespace Task09
{
    class Program
    {
        public static bool Check(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        public static int[] Compress(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] * arr[i + 1] % 3 == 0)
                {
                    arr[i] *= arr[i + 1];
                    for (int j = i + 1; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    Array.Resize(ref arr, arr.Length - 1);
                }
            }

            return arr;
        }
        public static int CompressAgain(ref int[] arr)
        {
            int[] temp;
            int count = 0;

            while (true)
            {
                temp = Compress(arr);
                if (Check(arr, temp))
                    break;
                count++;
                arr = temp;
            }

            return count;
        }

        public static void Write(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" "); 
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            uint n;
            bool x = uint.TryParse(Console.ReadLine(), out n);
            Random r = new Random(DateTime.Now.Millisecond);
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10, 11);
            }

            Write(arr);
            CompressAgain(ref arr);
            Write(arr);
            
        }

        

        

        

       
    }
}

