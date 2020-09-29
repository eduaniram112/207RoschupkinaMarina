using System;

partial class Program
{
    // В случае, если введённый день недели не соответствует формату входных данных
    // метод должен вернуть int.MinValue.
    // Гарантируется, что int.MinValue не может быть получен как верный ответ.
    static int MorningWorkout(String dayOfWeek, int firstNumber, int secondNumber)
    {
        switch (dayOfWeek)
        {
            case "Monday":
            case "Wednesday":
            case "Friday":
                return GetSumOfOddOrEvenDigits(firstNumber, 1);
            case "Tuesday":
            case "Thursday":
                return GetSumOfOddOrEvenDigits(secondNumber, 2);
            case "Saturday":
                return Maximum(firstNumber, secondNumber);
            case "Sunday":
                return Multiply(firstNumber, secondNumber);
            default: return int.MinValue;
        }
    }

    static int GetSumOfOddOrEvenDigits(int value, int remainder)
    {
        int sum = 0;
        value = Math.Abs(value);
        if (remainder == 1) //считаем нечетные у 1
        {
            while (value > 0)
            {
                int a = value % 10;
                if (a % 2 == 1) { sum += a; }
                value /= 10;
            }
        }
        if (remainder == 2) //считаем четные у 2
        {
            while (value > 0)
            {
                int a = value % 10;
                if (a % 2 == 0) { sum += a; }
                value /= 10;
            }
        }
        return sum;
    }

    static int Multiply(int firstValue, int secondValue)
    {
        return firstValue * secondValue;
    }

    static int Maximum(int firstValue, int secondValue)
    {
        return Math.Max(firstValue, secondValue);
    }
}