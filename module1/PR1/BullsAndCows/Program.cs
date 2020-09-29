using System;

namespace BullsAndCows
{
    class Program
    {

        static long Gen(int n)
        {
            /* Метод для генерации случайного числа с разными цифрами.
             * В цикле генерируем число и проверяем, что все цифры различны 
             * и выходим из цикла. Странный способ с генерацией последней цифры
             * нужен для того, чтобы 10-ти значное число начиналось не только с 1 
             * или 2 (иначе оно не влезает в int, а рандом не умеет работать с long)
             */
            long number;
            while (true)
            {
                Random r = new Random();

                number = r.Next((int)Math.Pow(10, n - 2), (int)Math.Pow(10, n - 1) - 1);
                number *= 10;
                number += r.Next(1, 9);

                bool[] digits = new bool[10];
                long clone = number;

                while (clone != 0)
                {
                    if (digits[clone % 10]) { break; }
                    digits[clone % 10] = true;
                    clone /= 10;
                }
                if (clone == 0) { break; }
            }
            return number;
        }

        static bool ValidateN(int n) //Метод для проверки корректности n
        {
            if (n > 10 || n < 1) { return false; }
            else { return true; }
        }

        static bool ValidateGuess(long guess, int n) //Метод для проверки корректности guess
        {
            if (guess >= Math.Pow(10, n - 1) && guess < Math.Pow(10, n)) { return true; }
            else { return false; }
        }

        static int Bulls(long number, long guess)
        {
            /* Метод для поиска количества быков.
             * По очереди отделяем цифры от догадки
             * и от исходного числа и сравниваем
             */
            int b = 0;
            while (number > 0)
            {
                if (number % 10 == guess % 10) { b++; }
                number /= 10;
                guess /= 10;
            }
            return b;
        }

        static int Cows(long number, long guess)
        {
            /* Метод для поиска количества коров.
             * Массив нужен для того, чтобы одинаковые 
             * числа в догадках не считались по несколько раз
             */
            int c = 0;
            int[] arr = new int[10];

            while (guess > 0)
            {

                long digit = guess % 10; //одна из цифр догадки
                long clone = number; //клон исходного числа

                while (clone > 0)
                {
                    if (clone % 10 == digit) { arr[digit] = 1; }
                    clone /= 10;

                }
                guess /= 10;
            }

            for (int i = 0; i < 10; i++) { c += arr[i]; }
            return c;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Быки и коровы - игра, где вам предстоит угадать заданное компьютером число");
            Console.WriteLine("Bulls = x значит что вы угадали х цифр и угадали их позиции");
            Console.WriteLine("Cows = y значит что вы угадали y цифр, но не факт, что угадали их место");
            Console.WriteLine("иными словами Bulls входит в Cows (чтобы вам было сложнее)");
            Console.WriteLine("Цифры в загаданном числе не повторяются\n");

            while (true)
            {
                Console.WriteLine("Введите количество цифр в исходном числе (от 1 до 10)");
                int n;
                long number;
                bool x = int.TryParse(Console.ReadLine(), out n);

                /*
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(Gen(n));
                }*/

                if (ValidateN(n) && x)
                {
                    int bulls = 0, cows = 0;
                    number = Gen(n);
                    while (bulls != n)
                    {
                        Console.WriteLine("Введите вашу догадку (n-значное число)");

                        long guess;
                        bool y = long.TryParse(Console.ReadLine(), out guess);

                        if (y && ValidateGuess(guess, n))
                        {
                            bulls = Bulls(number, guess);
                            cows = Cows(number, guess);
                            //Console.WriteLine(number);
                            Console.WriteLine("Bulls = {0}, Cows = {1}", bulls, cows);

                        }
                        else
                        {
                            Console.WriteLine("Неправильный формат числа");
                        }

                    }

                    Console.WriteLine("Ура, вы угадали! Давайте сыграем еще раз? y/n");
                    string answer = Console.ReadLine();
                    if (answer != "y") { break; }


                }
                else
                {
                    Console.WriteLine("Пожалуйста введите корректное количество цифр");
                }

            }

        }
    }
}
