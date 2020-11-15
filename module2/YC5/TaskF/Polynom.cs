using System;

class Polynom
{

    public static bool TryParsePolynom(string line, out int[] arr)
    {
        string[] str = line.Split();
        arr = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            bool x = int.TryParse(str[i], out arr[i]);
            if (!x) return false;
        }
        return true;
    }

    public static int[] Sum(int[] a, int[] b)
    {
        int[] c1 = new int[a.Length + b.Length];
        int[] c2 = new int[a.Length + b.Length];
        for (int i = 0; i < a.Length;i++)
        {
            c1[i] = a[i];
        }
        for (int i = 0; i < b.Length;i++)
        {
            c2[i] = b[i];
        }

        for (int i = 0; i < c2.Length; i++)
        {
            c2[i] += c1[i];
        }
        return c2;
    }

    public static int[] Dif(int[] a, int[] b)
    {
        int[] c1 = new int[a.Length + b.Length];
        int[] c2 = new int[a.Length + b.Length];
        for (int i = 0; i < a.Length; i++)
        {
            c1[i] = a[i];
        }
        for (int i = 0; i < b.Length; i++)
        {
            c2[i] = b[i];
        }

        for (int i = 0; i < c1.Length; i++)
        {
            c1[i] -= c2[i];
        }
        return c1;
    }

    public static int[] MultiplyByNumber(int[] a, int n)
    {
        int[] c = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            c[i] = a[i] * n;
        }
        return c;
    }

    public static int[] MultiplyByPolynom(int[] a, int[] b)
    {
        int[] c;
        if (a.Length == 1 && a[0] == 0 || b.Length == 1 && b[0] == 0)
        {
            c = new int[1];
            c[0] = 0;

        }
        else
        {
            c = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j < b.Length; ++j)
                {
                    c[i + j] += a[i] * b[j];
                }
            }
        }
        return c;
    }
    public static bool IsEmpty(int[] polynom)
    {
        for (int i = 0; i < polynom.Length; i++)
        {
            if (polynom[i] != 0) return false;
        }
        return true;
    }
    public static string PolynomToString(int[] polynom)
    {
        string str = "";
        if (IsEmpty(polynom) && polynom[0] == 0)
        {
            str = "0";
        }
        else
        {
            
            for (int i = polynom.Length - 1; i > 1; i--)
            {
                if (polynom[i] == 1)
                {
                    str += "x" + i + " + ";
                }
                else if (polynom[i] == -1)
                {
                    str += "-" + "x" + i + " + ";
                }
                else if (polynom[i] != 0)
                {
                    str += polynom[i] + "x" + i + " + ";
                }
            }
            if (polynom.Length >= 2)
            { if (polynom[1] != 0) str += polynom[1] + "x" + " + "; }


            if (polynom[0] != 0)
            {
                str += polynom[0];
            }
            else
            {
                if (str.Length > 2) str = str.Remove(str.Length - 2);
            }
        }
        return str;
    }
}
