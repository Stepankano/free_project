using System;
using System.Collections.Generic;
using System.Linq;

class ListOfMatrix
{
    static private List<Matrix> ListOfMatr = new List<Matrix>();
    private Matrix this[int index]
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
    public int Count(){
        if(ListOfMatr==null){
            return 0;
        }
        return ListOfMatr.Count();
    }
   
    public void AppendToList(Matrix matr)
    {
        ListOfMatr.Add(matr);
    }
    public List<Matrix> MinMatrix()
    {
        return (List<Matrix>)ListOfMatr.Where(x => x.get_determinator() <= x.get_determinator()).ToList();
    }
    public List<Matrix> MaxMatrix()
    {
        return (List<Matrix>)ListOfMatr.Where(x => x.get_determinator() >= x.get_determinator()).ToList();
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
    public void MatrixPrint(List<Matrix> matr)
    {
        foreach (Matrix i in matr)
        {
            System.Console.WriteLine($"{i[0, 0]} {i[0, 1]} {i[1, 0]} {i[1, 1]}");
        }
    }
}