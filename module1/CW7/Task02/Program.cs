using System; // Для доступа к классу Console
using System.IO; // Для работы с файлами и директориями
namespace Task02
{
    class Program
    {

        static void DirectoryOverview(string dirName)
        {
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                    Console.WriteLine("Подподкаталоги:");
                    string[] dirs2 = Directory.GetDirectories(s);
                    foreach (string s2 in dirs2)
                    {
                        Console.WriteLine(s2);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
           }
        }

        static void Main(string[] args)
        {
            try
            {
                DirectoryOverview(@"../../../");
            }
            catch (FormatException)
            {
                Console.WriteLine("error");
            }
            finally
            {
                Console.WriteLine("well");
                

            }

        }
    }
}
