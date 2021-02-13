using System;

namespace Task02
{
    public delegate void NewLine(string str);
    class Errey
    {
        int[,] arr = { { 1, 2, 3, 4 }, { 3, 4, 6, 6 }, { 13, 40, 34, 6 }};
        public event NewLine OnNewLine;
        public void Print()
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                OnNewLine?.Invoke("");
            }
        }
    }

    class Handler1
    { 
        public void Message(string str)
        {
            Console.WriteLine(str);
        }
        public void Message2(string str)
        {
            Console.WriteLine("********");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Errey err = new Errey();
            Handler1 hndlr1 = new Handler1();
            err.OnNewLine += hndlr1.Message;
            err.Print();
            Console.WriteLine();
            err.OnNewLine += hndlr1.Message2;
            err.Print();

        }
    }
}
