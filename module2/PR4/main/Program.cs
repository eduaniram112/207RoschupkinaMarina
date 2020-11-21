using System;
using System.Collections.Generic;
using System.IO;
using vegetables;


/*
 
            |￣￣￣￣￣￣￣￣|
              душные овощи
            |＿＿＿＿＿＿＿＿| 
               \  (•◡•)  /   
                  (   ) куда ящик нести, начальник?
                   | |

 */


namespace main
{
    public partial class Program
    {
        /// <summary>
        /// Метод для ввода контейнера и его ящиков через консоль.
        /// </summary>
        /// <param name="container">Контейнер, который мы изменяем.</param>
        static void SimpleEnterContainer(out Container container)
        {
            //Создаем контейнер.
            container = new Container();
            Console.WriteLine(container);
            Console.WriteLine("Сколько ящиков хотите туда положить? Могут влезть не все");
            int number;
            bool numbbool = int.TryParse(Console.ReadLine(), out number);
            if (numbbool && number>=0)
            {
                //Добавляем ящики.
                for (int i = 0; i < number; i++)
                {
                    Box box;
                    Console.WriteLine("Введите через пробел вес ящика, цену за кг и название");
                    Console.WriteLine("Названия вводятся по-английски в единственном числе и в одно слово");
                    string[] str = Console.ReadLine().Split();
                    double weight, price;
                    //Создаем ящик.
                    box = new Box();
                    if (str.Length >= 3)
                    {
                        bool weibool = double.TryParse(str[0], out weight);
                        bool prbool = double.TryParse(str[1], out price);
                        if (weibool && prbool && weight>=0 && price>=0)
                        {
                            //Заполняем ящик.
                            box = new Box(weight, price, str[2]);
                        }
                        else
                        {
                            Console.WriteLine("Неправильно введены данные, все будет заполнено нулями");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Неправильно введены данные, все будет заполнено нулями");

                    }
                    //Добавляем ящик в контейнер.
                    container.AddToContainer(box);
                }
            }
            else
            {
                Console.WriteLine("Неправильно введены данные, все будет заполнено нулями");
            }
        }

        /// <summary>
        /// Метод для изменения склада, который работает и с файлами и без.
        /// Осознанное потребление места в коде и все такое.
        /// </summary>
        /// <param name="str">Массив строк с параметрами.</param>
        /// <param name="warehouse">Склад, который мы изменяем</param>
        static void EnterWarehouse(string[] str, out Warehouse warehouse)
        {

            int capacity, charge;
            if (str.Length >= 2)
            {
                //Получаем параметры.
                bool capbool = int.TryParse(str[0], out capacity);
                bool chbool = int.TryParse(str[1], out charge);
                // Проверяем, что параметры правильные.
                if (chbool && capbool && capacity>=0 && charge >=0)
                {
                    //Изменяем склад.
                    warehouse = new Warehouse(capacity, charge);
                }
                else
                {
                    Console.WriteLine("Неправильно введены данные, все будет заполнено нулями");
                    warehouse = new Warehouse();
                }
            }
            else
            {
                Console.WriteLine("Неправильно введены данные, все будет заполнено нулями");
                warehouse = new Warehouse();
            }
        }

        /// <summary>
        /// Метод для парсинга контейнера из файла.
        /// </summary>
        /// <param name="path">Путь к файлу с контейнерами.</param>
        /// <param name="line">Номер строки откуда берется контейнер.</param>
        /// <returns>Заполненный контейнер.</returns>
        static Container ParseContainer(string path, int line)
        {
            //Считываем список контейнеров из файла.
            string[] str = File.ReadAllLines(path);

            //Берем нужный и разбиваем строку на ящики.
            string[] info = str[line - 1].Split("| ");

            //Количество ящиков в контейнере.
            int boxes = int.Parse(info[0]);

            Container newContainer = new Container();
            Console.WriteLine("Контейнер: " + newContainer);
            Console.WriteLine("Добавляем ящики:");
            for (int i = 1; i < boxes; i++)
            {
                string[] boxInfo = info[i].Split();

                double weight, price;
                //Создаем пустой ящик.
                Box box = new Box();
                if (boxInfo.Length >= 3)
                {
                    //Получаем параметры.
                    bool weibool = double.TryParse(boxInfo[0], out weight);
                    bool prbool = double.TryParse(boxInfo[1], out price);

                    //Проверяем правильность параметров.
                    if (weibool && prbool && weight>=0 && price >=0)
                    {
                        //Заполняем ящик.
                        box = new Box(weight, price, boxInfo[2]);
                        Console.WriteLine("Ящик " + i + ": " + box);
                    }
                    else
                    {
                        Console.WriteLine("Неправильно введены данные про ящик, все будет заполнено нулями");
                    }
                }
                else
                {
                    Console.WriteLine("Неправильно введены данные про ящик, все будет заполнено нулями");
                }

                //Добавляем ящик в контейнер.
                newContainer.AddToContainer(box);

            }
            Console.WriteLine();
            return newContainer;
        }

        /// <summary>
        /// Метод для работы со складом через файлы.
        /// </summary>
        /// <param name="warehousePath">Путь до склада.</param>
        /// <param name="containerPath">Путь до контейнера.</param>
        /// <param name="actionsPath">Путь до файла с действиями.</param>
        /// <returns>Изменненый склад.</returns>
        private static Warehouse FileWarehouse(string warehousePath, string containerPath, string actionsPath)
        {
            //Создаем склад.
            Warehouse warehouse;
            string[] str = File.ReadAllText(warehousePath).Split();
            EnterWarehouse(str, out warehouse);

            //Получаем список действий из файла.
            string[] actions = File.ReadAllLines(actionsPath);
            for (int i = 0; i < actions.Length; i++)
            {
                //Разбиваем действие на команду и индекс.
                string[] command = actions[i].Split();

                //Добавляем контейнер.
                if (command[0] == "Add")
                {
                    int line;
                    if (int.TryParse(command[1], out line))
                    {
                        Container newContainer = ParseContainer(containerPath, line);
                        warehouse.AddToWarehouse(newContainer);
                    }
                    else
                    {
                        Console.WriteLine("С командами что-то не так");
                    }
                }

                //Удаляем контейнер.
                else if (command[0] == "Delete")
                {
                    int line;
                    if (int.TryParse(command[1], out line))
                    {
                        warehouse.RemoveFromWarehouse(line - 1);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("С командами что-то не так");
                    }

                }
                else
                {
                    Console.WriteLine("С командами что-то не так");
                }

            }

            return warehouse;
        }

        /// <summary>
        /// Меню для работы со складом через консоль.
        /// </summary>
        /// <param name="warehouse">Измененный склад.</param>
        static void Menu(Warehouse warehouse)
        {
            int ans = 0;

            //Работает пока пользователь не захочет выйти.
            while (ans != 3)
            {
                Console.WriteLine();
                Console.WriteLine("Что хотите делать?");
                Console.WriteLine("1) Добавить контейнер на склад");
                Console.WriteLine("2) Удалить контейнер");
                Console.WriteLine("3) Выйти");
                Console.WriteLine("4) Посмотреть список контейнеров");
                Console.WriteLine("5) Секретный протокол");
                bool ansbool = int.TryParse(Console.ReadLine(), out ans);
                switch (ans)
                {
                    //Добавление контейнера на склад.
                    case 1:
                        Container newContainer;
                        SimpleEnterContainer(out newContainer);
                        warehouse.AddToWarehouse(newContainer);
                        break;
                    //Удаление контейнера со склада.
                    case 2:
                        int number;
                        warehouse.ListofContainers();
                        Console.WriteLine("Введите номер контейнера который хотите удалить");
                        bool numbbool = int.TryParse(Console.ReadLine(), out number);
                        warehouse.RemoveFromWarehouse(number);
                        break;
                    //Выходим.
                    case 3:
                        break;
                    //Выводим список контейнеров.
                    case 4:
                        Console.WriteLine("Список контейнеров на складе:");
                        warehouse.ListofContainers();
                        break;
                    //Хм, похоже на доп функции.
                    case 5:
                        warehouse.OlivieProtocol(); break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            }
        }

        /// <summary> Метод для вывода инструкции по работе с файлами. </summary>
        private static void FileMenu()
        {
            Console.WriteLine("Посмотрите примеры в папке Examples");
            Console.WriteLine("Склад передается в формате: {вместимость} {плата за хранение}");
            Console.WriteLine("Каждый контейнер передается в формате: {количество ящиков} | {вес 1 ящика} {цена за кг 1 ящика} {наименование товара} | {вес 2 ящика} {цена за кг 2 ящика} {наименование товара} ... ");
            Console.WriteLine("Add {n} - добавляет n-ый контейнер из файла на склад");
            Console.WriteLine("Delete {n} - удаляет n-ый контейнер со склада \n");
        }

        /// <summary> Метод для окончательного выход из программы. Появился чтобы мейн стал чуть поменьше.</summary>
        /// <returns>Ответ пользователя.</returns>
        private static int Exit()
        {
            Console.WriteLine("И что дальше?");
            Console.WriteLine("1) Выйти совсем");
            Console.WriteLine("2 или что угодно еще)  Начать заново");
            int ansexit;
            bool ansexitbool = int.TryParse(Console.ReadLine(), out ansexit);
            return ansexit;
        }

        /// <summary>
        /// Основной метод.
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                bool flag = false;
                while (!flag)
                {
                    Console.WriteLine("Как работаем?");
                    Console.WriteLine("1) Как обычно");
                    Console.WriteLine("2) Через файлы");
                    int ans;
                    bool ansbool = int.TryParse(Console.ReadLine(), out ans);
                    if (ansbool && (ans == 1 || ans == 2))
                    {
                        Warehouse warehouse;
                        //Режим работы через консоль.
                        if (ans == 1)
                        {
                            Console.WriteLine("Введите через пробел вместимость склада и плату за хранение");
                            string[] str = Console.ReadLine().Split();

                            EnterWarehouse(str, out warehouse);
                            Console.WriteLine(warehouse);
                            Menu(warehouse);
                            if (Exit() == 1) flag = true;
                        }
                        //Режим работы через файлы.
                        else if (ans==2)
                        {
                            FileMenu();

                            Console.WriteLine("Пожалуйста введите полный и корректный путь до файла склада");
                            string warehousePath = Console.ReadLine();
                            Console.WriteLine("Пожалуйста введите полный и корректный путь до файла с контейнерами");
                            string containerPath = Console.ReadLine();
                            Console.WriteLine("Пожалуйста введите полный и корректный путь до файла с командами");
                            string actionsPath = Console.ReadLine();

                            if (File.Exists(warehousePath) && File.Exists(containerPath) && File.Exists(actionsPath))
                            {
                                warehouse = FileWarehouse(warehousePath, containerPath, actionsPath);
                                Console.WriteLine("Информация про склад:");
                                Console.WriteLine(warehouse + "\n");
                                Console.WriteLine("Список контейнеров на складе:");
                                warehouse.ListofContainers();
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("С файлами или путями что-то не так");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Такой команды нет");
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Вы что-то нажали и все сломалось \n" + e.Message);
            }

        }

       
    }
}
