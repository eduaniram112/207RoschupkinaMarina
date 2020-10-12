using System;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool x = int.TryParse(Console.ReadLine(), out n);
            int m = 0, k = 0;
            string path = @"../../../firstFile.txt";
            string str = File.ReadAllText(path);
            string[] str2 = str.Split(new Char[] { ' ', '\n' });
            string strfinal = "";
            for (int i = 0; i < str2.Length; i++)
            {
                int n;
                bool x = int.TryParse(str2[i], out n);
                if (x)
                {
                    str2[i] = (n * 2).ToString();
                    k++;
                }
                else
                {
                    char[] str3 = str2[i].ToCharArray(0, str2[i].Length);
                    for (int j = 0; j < str3.Length; j++)
                    {
                        if (Char.IsUpper(str3[j]))
                        {
                            str3[j] = Char.ToLower(str3[j]);
                            m++;
                        }
                    }
                    str2[i] = new string(str3);
                }
                strfinal += str2[i] + " ";
                Console.WriteLine(str2[i]);

            }
            File.WriteAllText("../../../secondFile.txt", strfinal);
            Console.WriteLine(str);
            string str4 = "\nбукв изменено " + m + " чисел изменено " + k;
            File.AppendAllText("../../../secondFile.txt", str4);

        }
    }
}
