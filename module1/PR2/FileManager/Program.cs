using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace FileManager
{
    class Program
    {
        static string drive;
        static string directory;
        static string file;

        static void SetDrive(ref string drive)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.WriteLine("Функция может некорректно работать на вашей системе");
            }

            string[] allDrives = Directory.GetLogicalDrives();
            for (int i = 0; i < allDrives.Length; i++)
            {
                string d = allDrives[i];
                Console.WriteLine("{1} Drive: {0}", d, i + 1);
            }

            Console.WriteLine("Введите номер диска, который хотите сделать основным");
            int newDrive;
            bool flag = false;

            while (!flag)
            {
                bool x = int.TryParse(Console.ReadLine(), out newDrive);

                if (x && newDrive <= allDrives.Length)
                {
                    drive = allDrives[newDrive - 1];
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Пожалуйста введите корректный номер диска");
                }
            }
        }

        static void SetDirectory(ref string directory)
        {
            string[] allDirectories = Directory.GetDirectories(directory);
            for (int i = 0; i < allDirectories.Length; i++)
            {
                string d = allDirectories[i];
                Console.WriteLine("{1} Directory: {0}", d, i + 1);
            }

            Console.WriteLine("Введите номер директории, которую хотите выбрать");
            int newDir;
            bool flag = false;

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

        static void DirectoryGoUp(ref string directory)
        {

            if (Directory.Exists(directory))
            {
                directory = Directory.GetParent(directory).FullName;
                SetDirectory(ref directory);
            }
        }

        static void LookUpFiles(ref string directory, ref string file)
        {
            string[] allFiles = Directory.GetFiles(directory);
            for (int i = 0; i < allFiles.Length; i++)
            {
                string d = allFiles[i];
                Console.WriteLine("{1} File: {0}", d, i + 1);
            }

            Console.WriteLine("Введите номер файла который хотите выбрать");
            int newFile;
            bool flag = false;
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

        static void WriteDirectoryPath(ref string directory)
        {
            Console.WriteLine("Введите корректный и полный путь до директории");
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

        static void WriteFilePath(ref string file)
        {
            Console.WriteLine("Введите корректный и полный путь до файла");
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

        static void ReadFile(ref string file)
        {
            Console.WriteLine("Хотите ввести путь до файла?");
            Console.WriteLine("1) Да, сейчас сам все введу");
            Console.WriteLine("2) Нет, используй ранее выбранный");
            string msg1 = "Введите путь до файла";
            CommandMenu(ref file, ref directory, 2, msg1, "");

            Encoding currentEncoding = SetEncoding();

            if (File.Exists(file))
            {
                Console.WriteLine(File.ReadAllText(file, currentEncoding));
            }
            else
            {
                Console.WriteLine("Данный файл поврежден или не существует");
            }
        }

        static Encoding SetEncoding()
        {
            EncodingInfo[] allEncodings = Encoding.GetEncodings();
            for (int i = 0; i < allEncodings.Length; i++)
            {
                string e = allEncodings[i].DisplayName.ToString();
                Console.WriteLine("{1} File: {0}", e, i + 1);
            }

            Console.WriteLine("Введите номер кодировки, которую хотите выбрать");
            int newEncoding;
            Encoding currentEncoding = Encoding.UTF8;
            bool flag = false;

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

            return currentEncoding;
        }

        static void MoveFile(ref string file, ref string directory)
        {
            Console.WriteLine("Хотите ввести пути до файла и директории?");
            Console.WriteLine("1) Да, сейчас сам все введу");
            Console.WriteLine("2) Нет, используй ранее выбранные");

            string msg1 = "Введите путь до директории, в которую хотите переместить файл";
            string msg2 = "Введите путь до файла, который хотите переместить";

            CommandMenu(ref file, ref directory, 3, msg1, msg2);

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

        static void CopyFile(ref string file, ref string directory)
        {
            Console.WriteLine("Хотите ввести пути до файла и директории?");
            Console.WriteLine("1) Да, сейчас сам все введу");
            Console.WriteLine("2) Нет, используй ранее выбранные");

            string msg1 = "Введите путь до директории, в которую хотите копировать файл";
            string msg2 = "Введите путь до файла, который хотите копировать";

            CommandMenu(ref file, ref directory, 3, msg1, msg2);
            
            if (Directory.Exists(directory) && File.Exists(file))
            {
                string newFile = Path.Combine(directory, "copy" + Path.GetFileName(file));
                File.Copy(file, newFile);
            }

            else
            {
                Console.WriteLine("Данный путь некорректен или файл не существует");
            }

        }

        static void DeleteFile()
        {
            Console.WriteLine("Введите путь до файла, который хотите удалить");
            string delFile = "";
            WriteFilePath(ref delFile);
            if (File.Exists(delFile))
            {
                Console.WriteLine("Вы уверены, что хотите удалить файл? Только ввод 1 приведет к удалению");
                Console.WriteLine("1) Да");
                Console.WriteLine("2) Нет");
                bool flag = false;
                while (!flag)
                {
                    int ans = 0;
                    bool x = int.TryParse(Console.ReadLine(), out ans);
                    if (ans == 1)
                    {
                        File.Delete(delFile);
                        flag = true;
                    }
                    if (ans == 2)
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

        static void CreateFile(ref string directory)
        {
            Console.WriteLine("Хотите ввести путь до директории?");
            Console.WriteLine("1) Да, сейчас сам все введу");
            Console.WriteLine("2) Нет, используй ранее выбранную");
            string msg1 = "Введите путь до директории, в которой хотите создать файл";
            CommandMenu(ref file, ref directory, 1, msg1, "");

            

            bool flag = false;

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

                    string newFile = Path.Combine(directory, fileName);

                    Encoding currentEncoding = SetEncoding();
                    File.WriteAllText(newFile, fileContent, currentEncoding);
                }
            }
            

        }

        static bool IsValidFilename(string testName)
        {
            Regex containsABadCharacter = new Regex("[" + Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars())) + "]");
            if (containsABadCharacter.IsMatch(testName)) { return false; };

            return true;
        }

        static void Join2Files(ref string file)
        {
            Console.WriteLine("Хотите ввести путь до первого файла ?");
            Console.WriteLine("1) Да, сейчас сам все введу");
            Console.WriteLine("2) Нет, используй ранее выбранный");

            string msg1 = "Введите путь до первого файла";
            CommandMenu(ref file, ref directory, 2, msg1, "");

            Console.WriteLine("А теперь введите путь до второго файла");
            string file2="";
            WriteFilePath(ref file2);

            string fileContent1 = File.ReadAllText(file);
            string fileContent2 = File.ReadAllText(file2);
            string newDirectory = "";
            string newFile = "";
            Console.WriteLine("Введите директорию, в которой будет хранится новый файл");
            WriteDirectoryPath(ref newDirectory);

            bool flag = false;
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
                    newFile = Path.Combine(newDirectory, fileName);
                    Encoding currentEncoding = SetEncoding();
                    File.AppendAllText(newFile, fileContent1, currentEncoding);
                    File.AppendAllText(newFile, Environment.NewLine, currentEncoding);
                    File.AppendAllText(newFile, fileContent2, currentEncoding);
                }
            }
            ReadFile(ref newFile);

        }

        static void AddToFile(ref string file)
        {
            Console.WriteLine("Хотите ввести путь до файла?");
            Console.WriteLine("1) Да, сейчас сам все введу");
            Console.WriteLine("2) Нет, используй ранее выбранный");
            string msg1 = "Введите путь до файла";
            CommandMenu(ref file, ref directory, 2, msg1, "");

            Encoding currentEncoding = SetEncoding();

            if (File.Exists(file))
            {
                Console.WriteLine("Введите то, что хотите дописать ");
                string fileContent = Console.ReadLine();
                File.AppendAllText(file, Environment.NewLine, currentEncoding);
                File.AppendAllText( file, fileContent, currentEncoding);
                
            }
            else
            {
                Console.WriteLine("Данный файл поврежден или не существует");
            }
        }

        static void CommandMenu(ref string file,ref string directory,int type,string msg1, string msg2)
        {
            int ans = 0;
            bool flag = false;
            bool x = int.TryParse(Console.ReadLine(), out ans);
            while (!flag)
            {
                if (ans == 1)
                {
                    if (type == 1)
                    {
                        flag = true;
                        Console.WriteLine(msg1);
                        WriteDirectoryPath(ref directory);
                        
                    }
                    if (type == 2)
                    {
                        flag = true;
                        Console.WriteLine(msg1);
                        WriteFilePath(ref file);
                    }
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

        static void MainMenu()
        {
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
            Console.WriteLine("14) Выйти");

        }

        static void Main(string[] args)
        {
            //Начальные настройки.
            string[] allDrives = Directory.GetLogicalDrives();
            drive = allDrives[0];
            directory = drive;

            bool exit = false;
            while (!exit)
            {
                MainMenu();
                int n;
                bool x = int.TryParse(Console.ReadLine(),out n);
                if (!x || n<1 || n > 14)
                {
                    Console.WriteLine("Введите правильный номер команды");
                }
                else
                {
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
                            SetDirectory(ref directory);
                            break;
                        case 5:
                            LookUpFiles(ref directory, ref file);
                            break;
                        case 6:
                            Console.WriteLine("Case 1");
                            break;
                        case 7:
                            Console.WriteLine("Case 1");
                            break;
                        case 8:
                            Console.WriteLine("Case 1");
                            break;
                        case 9:
                            Console.WriteLine("Case 1");
                            break;
                        case 10:
                            Console.WriteLine("Case 1");
                            break;
                        case 11:
                            Console.WriteLine("Case 1");
                            break;
                        case 12:
                            Console.WriteLine("Case 1");
                            break;
                        case 13:
                            Console.WriteLine("Case 1");
                            break;
                        case 14:
                            exit = true;
                            break;

                    }
                    
                }
            }

        }
    }
}
