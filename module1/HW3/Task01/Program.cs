using System;
//1 задача с 13 слайда
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, s = 0, maxi = 0;
            for (int i = 1; i < 1000; i++)
            {
                sum += i;
                if (sum < 1000 && sum > 100 && sum % 10 == sum / 100 && sum / 100 == sum / 10 % 10)
                {
                    s = sum;
                    maxi = i;
                    Console.WriteLine(s);
                    Console.WriteLine(maxi);

                }
              
            }
            Console.WriteLine("1+2+3+...+" + (maxi - 2).ToString()+"+"+(maxi - 1).ToString()+"+"+maxi.ToString());
        }
    }
}
