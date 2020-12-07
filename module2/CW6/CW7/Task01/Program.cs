using System;
using System.IO;
/*
1)  ArgumentException +
2)  InvalidOperationException +
3)  NullReferenceException +
4)  ArgumentNullException +
5)  FormatException +
6)  DivideByZeroException +
7)  IOException +

*/
namespace Task01
{
    class M
    {

    }

    class Program
    {
        static int A(int a,int b)
        {
            return a + b;
        }
        static void B(string e)
        {
            Console.WriteLine(e[0]);
        }

        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine()); // format и zero
                int b = 4;
                Console.WriteLine(A(a, b));
                Console.WriteLine(b / a);
                string c = null;
                string e = "eee";
                //Console.WriteLine(c.ToLower()); //nullreference
                // string aaa = File.ReadAllText("a.txt."); //io
                //int e = int.Parse(null);  //argnull
                //e.CompareTo(new M()); //argexc
                M[] ch = { new M(), new M() }; 
                //Array.Sort(ch); // inval

            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }
            catch (IOException)
            {
                Console.WriteLine("IOException");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentException");
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("InvalidOperationException");
            }

        }
    }
}
