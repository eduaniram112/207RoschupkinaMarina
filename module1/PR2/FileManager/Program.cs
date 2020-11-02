using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

/*
  надеюсь, это спиритический круг сработает:

                 🕯     🕯
        🕯                        🕯
           
      🕯    недушные проверяющие     🕯️               
              
        🕯                        🕯
                🕯        🕯
 */

namespace FileManager
{
    class Program
    {

        /*
         Переменные в которых хранятся значения текущих диска, директориии
         файла чтобы пользователь мог каждый раз их не вводить.
        */
        static string drive;
        static string directory;
        static string file;

        //Метод, который выводит список дисков и позволяет выбрать один из них.
        static void SetDrive(ref string drive)
        {
            try
            {
                //На маке он пихает в диски dmg и какие-то странные служебные разделы.
                if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.WriteLine("Функция может некорректно работать на вашей системе");
                }

                //Получаем список всех дисков и выводим его.
                string[] allDrives = Directory.GetLogicalDrives();
                for (int i = 0; i < allDrives.Length; i++)
                {
                    string d = allDrives[i];
                    Console.WriteLine("{1} Drive: {0}", d, i + 1);
                }

                Console.WriteLine("Введите номер диска, который хотите сделать основным");

                int newDrive;
                bool flag = false;

                //Выбираем диск.
                while (!flag)
                {
                    bool x = int.TryParse(Console.ReadLine(), out newDrive);

                    if (x && newDrive <= allDrives.Length)
                    {
                        drive = allDrives[newDrive - 1];
                        directory = drive;
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста введите корректный номер диска");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
                Console.WriteLine("Проверьте права доступа");
            }

        }

        //Метод для выбора директории через меню.
        static void SetDirectory(ref string directory)
        {
            try
            {
                //Получаем список всех директорий внутри нашей.
                string[] allDirectories = Directory.GetDirectories(directory);

                //Проверка на то, что в директории не пусто.
                if (allDirectories.Length > 0)
                {
                    //Выводим список директорий.
                    for (int i = 0; i < allDirectories.Length; i++)
                    {
                        string d = allDirectories[i];
                        Console.WriteLine("{1} Directory: {0}", d, i + 1);
                    }

                    Console.WriteLine("Введите номер директории, которую хотите выбрать");
                    int newDir;
                    bool flag = false;

                    //Выбираем директорию.
                    while (!flag)
                    {
                        bool x = int.TryParse(Console.ReadLine(), out newDir);

                        if (x && newDir <= allDirectories.Length)
                        {
                            directory = allDirectories[newDir - 1];
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста введите корректный номер директории");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("К сожалению эта директория пуста");
                }
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Что-то пошло не так");
                Console.WriteLine("Проверьте права доступа");
            }
        }

        //Метод чтобы подняться в родительскую директорию и перейти в другую оттуда.
        static void DirectoryGoUp(ref string directory)
        {
            try
            {
                //Проверка того, что наша директория и ее родитель существуют.
                if (Directory.Exists(directory) && Directory.Exists(Directory.GetParent(directory).FullName))
                {
                    directory = Directory.GetParent(directory).FullName;
                    //SetDirectory(ref directory);
                }
                else
                {
                    Console.WriteLine("Директории не существует");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }

        //Метод для просмотра файлов в текущей директории.
        static void LookUpFiles(ref string directory, ref string file)
        {
            try
            {
                //Получаем список всех файлов и выводим его.
                string[] allFiles = Directory.GetFiles(directory);
                if (allFiles.Length > 0)
                {
                    for (int i = 0; i < allFiles.Length; i++)
                    {
                        string d = allFiles[i];
                        Console.WriteLine("{1} File: {0}", d, i + 1);
                    }

                    Console.WriteLine("Введите номер файла который хотите выбрать");
                    int newFile;
                    bool flag = false;

                    //Выбираем нужный файл из списка.
                    while (!flag)
                    {
                        bool x = int.TryParse(Console.ReadLine(), out newFile);

                        if (x && newFile <= allFiles.Length)
                        {
                            file = allFiles[newFile - 1];
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста введите корректный номер файла");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Директория пуста");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }

        }

        //Метод для выбора директории через ввод полного пути.
        static void WriteDirectoryPath(ref string directory)
        {
            try
            {
                Console.WriteLine("Введите корректный и полный путь до директории");

                //Вводим путь и проверяем, что он корректный.
                string dirPath = Console.ReadLine();
                if (Directory.Exists(dirPath))
                {
                    directory = dirPath;
                }
                else
                {
                    Console.WriteLine("Данный путь некорректен, поэтому будет использован предыдущий");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }

        //Метод для выбора директории через ввод полного пути.
        static void WriteFilePath(ref string file)
        {
            try
            {
                Console.WriteLine("Введите корректный и полный путь до файла");

                //Вводим путь и проверяем, что он корректный.
                string filePath = Console.ReadLine();
                if (File.Exists(filePath))
                {
                    file = filePath;
                }
                else
                {
                    Console.WriteLine("Данный путь некорректен, поэтому будет использован предыдущий");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }

        //Метод для вывода содержимого файла.
        static void ReadFile(ref string file)
        {
            try
            {
                //Пользователь может использовать ранее выбранный файл или ввести путь до нового.
                Console.WriteLine("Хотите ввести путь до файла?");
                Console.WriteLine("1) Да, сейчас сам все введу");
                Console.WriteLine("2) Нет, используй ранее выбранный");

                //Метод для ввода нового пути.
                string msg1 = "Введите путь до файла";
                CommandMenu(ref file, ref directory, 2, msg1, "");



                //Выводим содержимое файла.
                if (File.Exists(file))
                {
                    Encoding currentEncoding = SetEncoding();
                    Console.WriteLine(File.ReadAllText(file, currentEncoding));
                }
                else
                {
                    Console.WriteLine("Данный файл поврежден или не существует");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }

        //Метод для выбора кодировки.
        static Encoding SetEncoding()
        {
            Encoding currentEncoding = Encoding.UTF8;

            try
            {
                //Получаем список всех доступных кодировок и выводим его.
                EncodingInfo[] allEncodings = Encoding.GetEncodings();
                for (int i = 0; i < allEncodings.Length; i++)
                {
                    string e = allEncodings[i].DisplayName.ToString();
                    Console.WriteLine("{1} File: {0}", e, i + 1);
                }

                Console.WriteLine("Введите номер кодировки, которую хотите выбрать");

                int newEncoding;

                bool flag = false;
                //Выбираем кодировку из списка.
                while (!flag)
                {
                    bool x = int.TryParse(Console.ReadLine(), out newEncoding);

                    if (x && newEncoding <= allEncodings.Length)
                    {
                        currentEncoding = allEncodings[newEncoding - 1].GetEncoding();
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста введите корректный номер кодировки");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }
            return currentEncoding;
        }

        //Метод для перемещения файла.
        static void MoveFile(ref string file, ref string directory)
        {
            try
            {
                //Пользователь может использовать ранее выбранные файл и директорию или ввести пути до новых.
                Console.WriteLine("Хотите ввести пути до файла и директории?");
                Console.WriteLine("1) Да, сейчас сам все введу");
                Console.WriteLine("2) Нет, используй ранее выбранные");

                //Метод для ввода новых путей.
                string msg1 = "Введите путь до директории, в которую хотите переместить файл";
                string msg2 = "Введите путь до файла, который хотите переместить";
                CommandMenu(ref file, ref directory, 3, msg1, msg2);

                //Проверяем, что все в порядке и перемещаем файл.
                if (Directory.Exists(directory) && File.Exists(file))
                {
                    string newFile = Path.Combine(directory, Path.GetFileName(file));
                    File.Move(file, newFile);
                }
                else
                {
                    Console.WriteLine("Данный путь некорректен или файл не существует");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }


        }

        //Метод для копирования файла.
        static void CopyFile(ref string file, ref string directory)
        {
            try
            {
                //Пользователь может использовать ранее выбранные файл и директорию или ввести путь до нового.
                Console.WriteLine("Хотите ввести пути до файла и директории?");
                Console.WriteLine("1) Да, сейчас сам все введу");
                Console.WriteLine("2) Нет, используй ранее выбранные");

                //Метод для ввода новых путей.
                string msg1 = "Введите путь до директории, в которую хотите копировать файл";
                string msg2 = "Введите путь до файла, который хотите копировать";
                CommandMenu(ref file, ref directory, 3, msg1, msg2);

                //Проверяем, что все в порядке и копируем файл, давая ему новое имя.
                if (Directory.Exists(directory) && File.Exists(file))
                {
                    //Создание пути к новому файлу.
                    string newFile = Path.Combine(directory, "copy" + Path.GetFileName(file));
                    File.Copy(file, newFile);
                }

                else
                {
                    Console.WriteLine("Данный путь некорректен или файл не существует");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }

        //Метод для удаления файла.
        static void DeleteFile()
        {
            try
            {
                //Ввод пути к файлу.
                //Здесь нет возможности использовать заранее выбранный тк это серьезная и необратимая операция.
                Console.WriteLine("Введите путь до файла, который хотите удалить");
                string delFile = "";
                WriteFilePath(ref delFile);
                if (File.Exists(delFile))
                {
                    //Еще одно подтверждение серьезности намериений.
                    Console.WriteLine("Вы уверены, что хотите удалить файл? Только ввод 1 приведет к удалению");
                    Console.WriteLine("1) Да");
                    Console.WriteLine("2) Нет");
                    bool flag = false;
                    while (!flag)
                    {
                        int ans;
                        bool x = int.TryParse(Console.ReadLine(), out ans);
                        if (ans == 1)
                        {
                            flag = true;
                            File.Delete(delFile);

                        }
                        else if (ans == 2)
                        {
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Введен неправильный номер команды");
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }

        }

        //Метод для создания файла.
        static void CreateFile(ref string directory)
        {
            try
            {
                //Пользователь может использовать ранее выбранную директорию или ввести путь до новой.
                Console.WriteLine("Хотите ввести путь до директории?");
                Console.WriteLine("1) Да, сейчас сам все введу");
                Console.WriteLine("2) Нет, используй ранее выбранную");

                //Метод для ввода нового пути.
                string msg1 = "Введите путь до директории, в которой хотите создать файл";
                CommandMenu(ref file, ref directory, 1, msg1, "");

                bool flag = false;

                //Ввод имени и содержимого файла.
                while (!flag)
                {
                    Console.WriteLine("Введите имя и расширение файла ");
                    string fileName = Console.ReadLine();
                    if (!IsValidFilename(fileName))
                    {
                        Console.WriteLine("Некорректное имя файла");
                    }
                    else
                    {
                        flag = true;
                        Console.WriteLine("Введите содержимое файла ");
                        string fileContent = Console.ReadLine();

                        //Создание пути к новому файлу.
                        string newFile = Path.Combine(directory, fileName);

                        Encoding currentEncoding = SetEncoding();
                        File.WriteAllText(newFile, fileContent, currentEncoding);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }

        //Метод для проверки вводимого пользователем имени файла.
        static bool IsValidFilename(string testName)
        {
            Regex containsABadCharacter = new Regex("[" + Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars())) + "]");
            if (containsABadCharacter.IsMatch(testName)) { return false; };

            return true;
        }

        //Метод для объединения двух файлов в один.
        static void Join2Files(ref string file)
        {
            try
            {
                //Пользователь может использовать ранее выбранный файл или ввести путь до нового.
                Console.WriteLine("Хотите ввести путь до первого файла ?");
                Console.WriteLine("1) Да, сейчас сам все введу");
                Console.WriteLine("2) Нет, используй ранее выбранный");

                //Метод для ввода нового пути.
                string msg1 = "Введите путь до первого файла";
                CommandMenu(ref file, ref directory, 2, msg1, "");

                //Ввод пути ко второму файлу.
                Console.WriteLine("А теперь введите путь до второго файла");
                string file2 = "";
                WriteFilePath(ref file2);

                //Получаем содержимое файлов.
                string fileContent1 = File.ReadAllText(file);
                string fileContent2 = File.ReadAllText(file2);

                string newDirectory = "";
                string newFile = "";
                //Вводим путь для нового файла.
                Console.WriteLine("Введите директорию, в которой будет хранится новый файл");
                WriteDirectoryPath(ref newDirectory);

                bool flag = false;

                while (!flag)
                {
                    //Вводим имя нового файла.
                    Console.WriteLine("Введите имя и расширение файла ");
                    string fileName = Console.ReadLine();
                    if (!IsValidFilename(fileName))
                    {
                        Console.WriteLine("Некорректное имя файла");
                    }
                    else
                    {
                        flag = true;

                        //Создание пути к новому файлу.
                        newFile = Path.Combine(newDirectory, fileName);
                        Encoding currentEncoding = SetEncoding();

                        //Записываем информацию из двух файлов в новый.
                        File.AppendAllText(newFile, fileContent1, currentEncoding);
                        File.AppendAllText(newFile, Environment.NewLine, currentEncoding);
                        File.AppendAllText(newFile, fileContent2, currentEncoding);
                    }
                }
                ReadFile(ref newFile);
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }

        }

        //Метод для записи в конец файла.
        static void AddToFile(ref string file)
        {
            try
            {
                //Пользователь может использовать ранее выбранные файл и директорию или ввести путь до новых.
                Console.WriteLine("Хотите ввести путь до файла?");
                Console.WriteLine("1) Да, сейчас сам все введу");
                Console.WriteLine("2) Нет, используй ранее выбранный");

                //Метод для ввода нового пути.
                string msg1 = "Введите путь до файла";
                CommandMenu(ref file, ref directory, 2, msg1, "");

                Encoding currentEncoding = SetEncoding();

                if (File.Exists(file))
                {
                    //Дописывание в файл.
                    Console.WriteLine("Введите то, что хотите дописать ");
                    string fileContent = Console.ReadLine();
                    File.AppendAllText(file, Environment.NewLine, currentEncoding);
                    File.AppendAllText(file, fileContent, currentEncoding);

                }
                else
                {
                    Console.WriteLine("Данный файл поврежден или не существует");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }

        /*
         Метод для возможного ввода пути файла и директории внутри других методов.
         Выглядит не очень красиво, но существенно экономит место и мое время.
         Метод вызывается с параметром type, которые определяет что сейчас будет вводиться (директория, файл или оба).
         msg1 и msg2 - сообщения, поясняющие, что нужно вводить.
         Так как пояснения каждый раз разные, то сообщения тоже приходится передавать.
        */
        static void CommandMenu(ref string file, ref string directory, int type, string msg1, string msg2)
        {
            int ans = 0;
            bool flag = false;


            //Цикл, выход из которого происхоит только если пользователь ввел 1 или 2.
            while (!flag)
            {
                bool x = int.TryParse(Console.ReadLine(), out ans);

                if (ans == 1)
                {
                    //Вводим только директорию.
                    if (type == 1)
                    {
                        flag = true;
                        Console.WriteLine(msg1);
                        WriteDirectoryPath(ref directory);

                    }

                    //Вводим только файл.
                    if (type == 2)
                    {
                        flag = true;
                        Console.WriteLine(msg1);
                        WriteFilePath(ref file);
                    }

                    //Вводим директорию и файл.
                    if (type == 3)
                    {
                        flag = true;
                        Console.WriteLine(msg1);
                        WriteDirectoryPath(ref directory);
                        Console.WriteLine(msg2);
                        WriteFilePath(ref file);

                    }
                    flag = true;
                }

                else if (ans == 2)
                {
                    flag = true;
                }

                else
                {
                    Console.WriteLine("Введен неправильный номер команды");
                }
            }

        }

        //Метод для вывода доступных команд.
        static void MainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Список доступных команд");
            Console.WriteLine("1) Выбор диска");
            Console.WriteLine("2) Выбор директории");
            Console.WriteLine("3) Поднятся на один уровень в директориях");
            Console.WriteLine("4) Ручной ввод пути до директории");
            Console.WriteLine("5) Выбрать файл в директории");
            Console.WriteLine("6) Ручной ввод пути до файла");
            Console.WriteLine("7) Вывести содержимое файла");
            Console.WriteLine("8) Копировать файл");
            Console.WriteLine("9) Переместить файл");
            Console.WriteLine("10) Удалить файл");
            Console.WriteLine("11) Создать новый файл");
            Console.WriteLine("12) Объединить 2 файла");
            Console.WriteLine("13) Дописать в файл (ура допфункции)");
            Console.WriteLine("14) Просмотреть выбранное");
            Console.WriteLine("15) Выйти");

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в файловый менеджер");

            //Начальные настройки.
            string[] allDrives = Directory.GetLogicalDrives();
            drive = allDrives[0];
            directory = drive;

            //Цикл который работает пока человек не выберет exit.
            bool exit = false;
            while (!exit)
            {
                //Метод для вывода списка доступных команд.
                MainMenu();
                int n;
                bool x = int.TryParse(Console.ReadLine(), out n);
                if (!x || n < 1 || n > 15)
                {
                    Console.WriteLine("Введите правильный номер команды");
                }
                else
                {
                    //Switch для выбора нужного пункта меню.
                    switch (n)
                    {
                        case 1:
                            SetDrive(ref drive);
                            break;
                        case 2:
                            SetDirectory(ref directory);
                            break;
                        case 3:
                            DirectoryGoUp(ref directory);
                            break;
                        case 4:
                            WriteDirectoryPath(ref directory);
                            break;
                        case 5:
                            LookUpFiles(ref directory, ref file);
                            break;
                        case 6:
                            WriteFilePath(ref file);
                            break;
                        case 7:
                            ReadFile(ref file);
                            break;
                        case 8:
                            CopyFile(ref file, ref directory);
                            break;
                        case 9:
                            MoveFile(ref file, ref directory);
                            break;
                        case 10:
                            DeleteFile();
                            break;
                        case 11:
                            CreateFile(ref directory);
                            break;
                        case 12:
                            Join2Files(ref file);
                            break;
                        case 13:
                            AddToFile(ref file);
                            break;
                        case 14:
                            Console.WriteLine("drive: " + drive);
                            Console.WriteLine("directory: " + directory);
                            Console.WriteLine("file: " + file);
                            break;
                        case 15:
                            exit = true;
                            break;

                    }
                }
            }
        }
    }
}