using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
static class MatrixLnOut
{
    static public ListOfMatrix EnterMatrix(string path)
    {
        ListOfMatrix ListMatr = new ListOfMatrix();
        try
        {
            string str = new string("");
            using (StreamReader StreamRead = new StreamReader(path))
            {
                while ((str = StreamRead.ReadLine()) != null)
                {
                    ListMatr.AppendToList(Matrix.Parse(str));
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return ListMatr;
    }

    static public void OutMatrix(string path, ListOfMatrix ListMatr)
    {
        try
        {
            string str = new string("");
            using (StreamWriter StreamWrite = new StreamWriter(path))
            {
                foreach (Matrix i in ListMatr.ToArray())
                {
                    StreamWrite.WriteLine($"{i[0, 0]} {i[0, 1]} {i[1, 0]} {i[1, 1]}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}