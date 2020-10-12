partial class Program
{
    private static bool Validate(string input, out int num)
    {
        bool x = int.TryParse(input, out num);
        if (x == false || num < 0) return false;
        return true;

    }

    private static int RecurrentFunction(int n)
    {
        if (n == 0) return 3;
        else return 2 * RecurrentFunction(n - 1) + 2;

    }

}