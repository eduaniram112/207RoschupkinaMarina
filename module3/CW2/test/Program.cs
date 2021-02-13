using System;

namespace test
{
    class Program
    {
        delegate void MyDel();

        static void Main()
        {
            MyDel md = Main;
            Console.WriteLine(md.Target is null ? 1 : 2);

        }


    }
}
