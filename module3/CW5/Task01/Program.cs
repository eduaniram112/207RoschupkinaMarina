using System;
using System.Collections.Generic;
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);

            LinkedList<int> list = new LinkedList<int>();
            Stack<int> stack = new Stack<int>();

            string str = n.ToString();

            foreach (char a in str)
            {
                list.AddLast(Convert.ToInt32(a.ToString()));
                stack.Push(Convert.ToInt32(a.ToString()));
               
            }

            Stack<int> r = new Stack<int>();
            while (stack.Count != 0)
            {
                r.Push(stack.Pop());
            }

            foreach (int a in list)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();

            foreach (int a in r)
            {
                Console.Write(a + " ");
            }
        }
    }
}

