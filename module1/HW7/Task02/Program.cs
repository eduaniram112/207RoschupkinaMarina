using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4 задача из презентации 7
namespace LabReadWriteText
{
    class Program
    {
        static string scorePath = "../../../Score.csv";

        static int ReadInt(int left, int right)
        {
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n < left || n > right)
                        throw new ArgumentException();
                    return n;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный ввод, повторите.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Нет такого пункта");
                }
            }
        }

   
        static void PrintMainMenu()
        {
            Console.WriteLine("Добро пожаловать в ваш личный словарь!!!\n Выберите номер пункта, что вы хотите сделать:\n" +
                "\t 1. Добавить новый словарь.\n" +
                "\t 2. Добавить новое слово и перевод.\n" +
                "\t 3. Найти перевод слова.\n" +
                "\t 4. Игра в карточки\n" +
                "\t Для выхода введите 0");
        }

        static void Main(string[] args)
        {
            while (true)
                Start();
        }


        static void Start()
        {
            PrintMainMenu();
            int n = ReadInt(0, 4);
            switch (n)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    AddNewLanguage();
                    break;
                case 2:
                    AddNewWord();
                    break;
                case 3:
                    FindTranslate();
                    break;
                case 4:
                    PlayCard();
                    break;
            }
        }

        static void AddNewLanguage()
        {
            Console.Write("Введите название словаря: ");
            string dictName = Console.ReadLine() + ".txt";

            if (File.Exists(dictName))
            {
                try
                {
                    Console.WriteLine("Такой словарь уже существует");
                }
                catch (IOException)
                {
                    Console.WriteLine("Ошибка при создании словаря");
                }
            }
            else
            {
                File.AppendAllText(dictName, "");
            }
        }

   
        static void AddNewWord()
        {
            
            string dictName;
            try
            {
                dictName = CheckIfExist();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.Write("Введите новое слово: ");
            string word = Console.ReadLine();
            Console.Write("Введите перевод: ");
            string translate = Console.ReadLine();

            try
            {
                File.AppendAllText(dictName, word + "-" + translate + "\n");
            }
            catch (IOException)
            {
                Console.WriteLine("Неудалось добавить новое слово");
            }
        }


        static void FindTranslate()
        {
            string dictName;
            try
            {
                dictName = CheckIfExist();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            string[] allWords = null;
            try
            {
                allWords = File.ReadAllLines(dictName);
            }
            catch (IOException)
            {
                Console.WriteLine("Неудалось считать слова");
            }

            // Ищем первое слово в словаре нужное нам
            foreach (string str in allWords)
            {
                if (str.Split('-').Length != 2)
                {
                    Console.WriteLine("Ошибка в записи " + str);
                    continue;
                }

                string dictWord = str.Split('-')[0];
                if (dictWord == word)
                {
                    Console.WriteLine("Перевод:" + str.Split('-')[1]);
                    return;
                }
            }

            Console.WriteLine("Слово отсутсвтует");
        }


        static void PlayCard()
        {
            int newScore = 0;
            string dictName;
            try
            {
                dictName = CheckIfExist();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


            Random rnd = new Random();
            string[] allWords = null;
            try
            {
                allWords = File.ReadAllLines(dictName);
            }
            catch (IOException)
            {
                Console.WriteLine("Неудалось считать слова");
            }

            Console.WriteLine("Вам будут выводиться слова на выбранном языке, а вам неодходимо написать перевод. \nДля выхода в меню \"Exit\"");

            int len = allWords.Length;
            while (true)
            {
                string pair = allWords[rnd.Next(len)];

                if (pair.Split('-').Length != 2)
                {
                    Console.WriteLine("Ошибка в записи " + pair + "\nИсправьте");
                    return;
                }

                Console.WriteLine(pair.Split('-')[0]);
                string answer = Console.ReadLine();

                if (answer == "Exit")
                {
                    Console.Write("Введите ваше имя для сохранения результатов: ");
                    string name = Console.ReadLine();
                    try
                    {
                        File.AppendAllText(scorePath, name + ";" + newScore + ";" + System.DateTime.Now.ToString() + "\n");
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Неудалось записать результат");
                    }
                    return;
                }
                if (answer == pair.Split('-')[1])
                {
                    Console.WriteLine("Верно!");
                    ++newScore;
                }
                else
                    Console.WriteLine("Невеврно. Верный ответ: " + pair.Split('-')[1]);
            }
        }


        static string CheckIfExist()
        {
            Console.Write("Введите название словаря: ");
            string dictName = Console.ReadLine() + ".txt";

            if (!File.Exists(dictName))
                throw new ArgumentException("Такого словаря не существует:(");

            return dictName;
        }
    }
}
