using System;
//4 задача из 5 презентации
namespace Task08
{
    class Program
    {
       
        public static uint[] FormArray(uint a)
        {
            uint[] arr = new uint[1];
            arr[0] = a;
            int count = 0;

            while (arr[count] != 1)
            {

                if (arr.Length == count + 1)
                {
                    uint[] tempArr = new uint[arr.Length * 2];
                    Array.Copy(arr, tempArr, arr.Length);
                    arr = tempArr;
                }
                arr[count + 1] = arr[count] % 2 == 0 ? arr[count] / 2 : 3 * arr[count] + 1;
                count++;
            }


            if (arr.Length > ++count){Array.Resize(ref arr, count);}

            return arr;
        }

        public static void Write(uint[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"[{i}] = {arr[i]}\t");
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            uint a;
            bool x = uint.TryParse(Console.ReadLine(), out a);

            Write(FormArray(a));
            Console.ReadKey();
        }

        

        

        
    }
}
