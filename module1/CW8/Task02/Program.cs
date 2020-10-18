using System;

namespace Task02
{
    class Program
    {

        static bool IsInRing(int x,int y)
        {
            if (Math.Sqrt(x * x + y * y) <= 4 && Math.Sqrt(x * x + y * y) >= 2) return true;
            else return false;
        }

        static void Write(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void Write2(int[] a,int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("("+a[i] + "," + b[i]+") ");
            }
            Console.WriteLine();
        }


        static void ArrayInOut(int[] a,int[] b, ref int[] ain, ref int[] aout, ref int[] bin, ref int[] bout)
        {
            int inn = 0;
            int outt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (IsInRing(a[i], b[i]))
                {
                    ain[inn] = a[i];
                    bin[inn] = b[i];
                    inn++;
                }
                else
                {
                    aout[outt] = a[i];
                    bout[outt] = b[i];
                    outt++;

                }
            }

            Array.Resize(ref ain, inn);
            Array.Resize(ref bin, inn);
            Array.Resize(ref aout, outt);
            Array.Resize(ref bout, outt);

        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter array size");
                int n;
                bool x = int.TryParse(Console.ReadLine(), out n);
                if (x)
                {
                    Console.WriteLine("Enter numbers");
                    int[] a = new int[n];
                    int[] b = new int[n];

                    int[] ain = new int[n];
                    int[] bin = new int[n];
                    int[] aout = new int[n];
                    int[] bout = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        //string s = Console.ReadLine();
                        //bool y = int.TryParse(s.Split()[0], out a[i]);
                        //bool z = int.TryParse(s.Split()[1], out b[i]);
                        Random r = new Random();
                        a[i] = r.Next(-5, 6);
                        b[i] = r.Next(-5, 6);
                        //if (!y) { Console.WriteLine("error"); x = false; break; }
                    }
                    
                        Write2(a,b);
                        
                        ArrayInOut(a, b, ref ain, ref aout, ref bin, ref bout);
                        Console.WriteLine("In");
                        Write2(ain,bin);
                        Console.WriteLine("Out");
                        Write2(aout,bout);

                    

                }
                else
                {
                    Console.WriteLine("error");
                }

            }
        }
    }
}
