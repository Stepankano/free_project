using System;
using System.Collections.Generic;
using System.Linq;

class ListOfMatrix
{
    private List<Matrix> ListOfMatr;
    public Matrix this[int index]
    {
        get
        {
            return ListOfMatr[index];
        }
        set
        {
            ListOfMatr[index] = value;
        }
    }
    public ListOfMatrix SortList()
    {
     return (ListOfMatrix)ListOfMatr.OrderBy(x => x.get_determinator() >= x.get_determinator());
    }
    public Matrix FirstOfList()
    {
        return ListOfMatr.First();
    }
    public Matrix EndOfList()
    {
        return ListOfMatr.Last();
    }
    public void AppendToList(Matrix matr)
    {
        ListOfMatr.Append(matr);
    }
    public ListOfMatrix MinMatrix()
    {
        return (ListOfMatrix)ListOfMatr.Select(x => x.get_determinator() <= x.get_determinator());
    }
    public ListOfMatrix MaxMatrix()
    {
        return (ListOfMatrix)ListOfMatr.Select(x => x.get_determinator() >= x.get_determinator());
    }
    public Matrix[] ToArray()
    {
        return ListOfMatr.ToArray();
    }
    public void MatrixPrint()
    {
        foreach (Matrix i in ListOfMatr)
        {
            System.Console.WriteLine($"{i[0, 0]} {i[0, 1]} {i[1, 0]} {i[1, 1]}");
        }
    }
}