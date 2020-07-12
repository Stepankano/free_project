using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Matrix
{
    static private int rank = 2;
    static private double[,] matrix = new double[rank, rank];
    //  00 01
    //  10 11
    static private double determinator;

    public double get_determinator()
    {
        Determinate();
        return determinator;
    }
    public void Determinate()
    {
        determinator = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }
    public double this[int x, int y]
    {

        get
        {
            try
            {
                double example = matrix[x, y];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return matrix[x, y];
        }
        set
        {
            try
            {
                double example = matrix[x, y];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            matrix[x, y] = value;
        }


    }
    public Matrix FindReverseMatrix()
    {
        Matrix reverse = new Matrix();
        Determinate();
        try
        {
            reverse[0, 0] = matrix[1, 1] / determinator;
            reverse[0, 1] = -matrix[0, 1] / determinator;
            reverse[1, 0] = -matrix[1, 0] / determinator;
            reverse[1, 1] = matrix[0, 0] / determinator;
        }
        catch (DivideByZeroException zer)
        {
            Console.WriteLine(zer.Message);
        }
        return reverse;
    }
    static public Matrix operator +(Matrix one, Matrix two)
    {
        Matrix sum = new Matrix();
        sum[0, 0] = one[0, 0] + two[0, 0];
        sum[1, 0] = one[1, 0] + two[1, 0];
        sum[0, 1] = one[0, 1] + two[0, 1];
        sum[1, 1] = one[1, 1] + two[1, 1];
        return sum;
    }
    static public bool operator <(Matrix one, Matrix two)
    {
        return one.get_determinator() < two.get_determinator() ? true : false;
    }
    static public bool operator >(Matrix one, Matrix two)
    {
        return one.get_determinator() > two.get_determinator() ? true : false;
    }
    static public bool operator ==(Matrix one, Matrix two)
    {
        return one[0, 0] == two[0, 0] && one[0, 1] == two[0, 1] && one[1, 0] == two[1, 0] && one[1, 1] == two[1, 1];
    }
    static public bool operator !=(Matrix one, Matrix two)
    {
        return !(one[0, 0] == two[0, 0] && one[0, 1] == two[0, 1] && one[1, 0] == two[1, 0] && one[1, 1] == two[1, 1]);
    }
    static public Matrix operator *(Matrix one, Matrix two)
    {
        Matrix result = new Matrix();
        result[0, 0] = one[0, 0] * two[0, 0] + one[0, 1] * two[1, 0];
        result[0, 1] = one[0, 0] * two[0, 1] + one[0, 1] * two[1, 1];
        result[1, 0] = one[1, 0] * two[0, 0] + one[1, 1] * two[1, 0];
        result[1, 1] = one[1, 0] * two[0, 1] + one[1, 1] * two[1, 1];
        return result;
    }

    static public double operator /(Matrix one, Matrix two)
    {
        return one.get_determinator() / two.get_determinator();
    }
    static public Matrix Parse(string str)
    {
        // 00 01 10 11
        string[] str_array = str.Split(" ", 4);
        Matrix matr = new Matrix();
        matr[0, 0] = double.Parse(str_array[0]);
        matr[0, 1] = double.Parse(str_array[1]);
        matr[1, 0] = double.Parse(str_array[2]);
        matr[1, 1] = double.Parse(str_array[3]);
        return matr;
    }
    static public bool TryParse(string str, out Matrix matr)
    {
        try{
        string[] str_array = str.Split(" ", 4);
        byte result = 0;
        double number;
        Matrix tmp = new Matrix();

        if (double.TryParse(str_array[0], out number))
        {
            result++;
            tmp[0, 0] = number;
        }
        if (double.TryParse(str_array[1], out number))
        {
            result++;
            tmp[0, 1] = number;
        }
        if (double.TryParse(str_array[2], out number))
        {
            result++;
            tmp[1, 0] = number;
        }
        if (double.TryParse(str_array[3], out number))
        {
            result++;
            tmp[1, 1] = number;
        }
        if (result == 4)
        {
            matr = tmp;
            return true;
        }
        else
        {
            tmp[0, 0] = tmp[0, 1] = tmp[1, 0] = tmp[1, 1] = 0;
            matr = tmp;
            return false;
        }
        }
        catch(ArgumentOutOfRangeException ex){
            System.Console.WriteLine(ex.Message);
        }
        matr = null;
        return false;
    }
}



