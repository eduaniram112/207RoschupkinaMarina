using System;

partial class Program
{
    // Проверка на валидные входные данные
    private static bool ValidateData(int day, int month, int year)
    {
        DateTime date;
        bool d = DateTime.TryParse(string.Format("{0}-{1}-{2}", year, month, day), out date);
        if (year<1701 || year > 1800 || d == false)
        {
           return false;
        }
        else { return true; }

    }
    /// <summary>
    /// Получение дня недели
    /// </summary>
    /// <param name="day"></param>
    /// <param name="month"></param>
    /// <param name="year"></param>
    /// <returns>Возвращает число от 1 до 7, где 1 - понедельник, и т.д. </returns>
    private static int GetDayOfWeek(int day, int month, int year)
    {
        DateTime date;
        bool d = DateTime.TryParse(string.Format("{0}-{1}-{2}", year, month, day), out date);
        int wday = ((int)date.DayOfWeek == 0) ? 7 : (int)date.DayOfWeek;
        return wday;

    }

    private static string GetDateOfFriday(int dateOfWeek, int day, int month, int year)
    {
        DateTime date;
        bool d = DateTime.TryParse(string.Format("{0}-{1}-{2}", year, month, day), out date);
        if (GetDayOfWeek(day, month, year) == 5)
        {
            return GetFormatMessage(day, month, year);
        }
        else
        {
            while(date.DayOfWeek != DayOfWeek.Friday)
            {
                date = date.AddDays(1);
            }
            return GetFormatMessage(date.Day, date.Month, date.Year);

        }

    }


}