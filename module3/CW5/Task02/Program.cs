using System;
using System.Collections.Generic;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string str = Console.ReadLine();
            foreach (char a in str)
            {
                if (a=='(' || a == '{' || a == '[')
                {
                    stack.Push(a);
                }
                if ((a == ')' || a == '}' || a == ']') && Convert.ToInt32(a) - Convert.ToInt32(stack.Peek()) < 10)
                {
                    stack.Pop();
                }
                    
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Правильная");
            }
            else
            {
                Console.WriteLine("Неправильная");
            }
        }
    }
}
