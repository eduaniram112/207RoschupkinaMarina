using System;

public class Field
{
    private int[][] matrix;

    public Field(int[][] matrix)
    {
        this.matrix = new int[matrix.Length][];
        for (int i = 0; i < matrix.Length; i++)
        {
            this.matrix[i] = new int[matrix.Length];
        }
    }

    public void LTR()
    {
        /*for (int i = 0; i < matrix[0].Length; i++)
        {
            matrix[0][i] = i + 1;
        }*/

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = i + j + 1;
            }
        }

    }

    public void RTL()
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = i + j + 1;
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            Array.Reverse(matrix[i]);
        }

    }

    public void FillIn(string fillType)
    {
        if (fillType == "left to right")
        {
            LTR();
        }
        else if (fillType == "right to left")
        {
            RTL();
        }
        else throw new ArgumentException("Incorrect input");
    }

    public override string ToString()
    {
        string str = "";

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                str += matrix[i][j] + " ";
            }
            str += "\n";
        }
        return str;
    }
}