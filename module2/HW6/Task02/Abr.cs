using System;
namespace Task02
{
    public class Abr
    {
        public Abr()
        {
        }
        // проверка, что строки состоят только из символов латинского алфавита // и пробелом
        public static bool Validate(string str)
        {

            str = str.ToLower();
            char[] english = new char[27];
            english[0] = ' ';
            for (int i = 1; i < english.Length; i++)
            {
                english[i] = (char)('a' + i);
            }
            if (str.IndexOfAny(english) < 0) return false;
            return true;
        }

        // получение массива строк
        // каждый элемент проверен на соответствие формату
        public static string[] ValidatedSplit(string str, char ch)
        {
            string[] output = null;
            output = str.Split(ch);
            foreach (string s in output)
            {
                if (!Validate(s)) return null;
            }
            return output;
        }

        // Обрезка строки по первому гласному
        public static string Shorten(string str)
        {
            string str2 = str.ToLower();
            char[] alph = { 'a', 'e', 'i', 'o', 'u', 'y' }; int ind = str2.IndexOfAny(alph);
            return str.Substring(0, ind + 1);
        }

        // Метод создания аббревиатуры для ПОДстроки (в ней много слов)
        public static string Abbrevation(string str)
        {
            string output = String.Empty;
            if (str != String.Empty)
            {
                string[] tmp = str.Split(' '); foreach (string s in tmp)
                {
                    string shortenS = Shorten(s); FirstUpcase(ref shortenS); output += shortenS;
                }
            }
            return output;
        }

        // Метод преобразования первого символа к заглавному
        public static void FirstUpcase(ref string str)
        {
            char[] chars = str.ToCharArray();
            str = str[0].ToString().ToUpper() + str.Substring(1).ToLower();
        }
    }

}
}
