using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Converter
{
    static class ConvertFormat
    {
        static private void JSONtoXML(string NameFile1, string NameFile2)
        {
            FileStream File1 = new FileStream(NameFile1, FileMode.Create);
            FileStream File2 = new FileStream(NameFile2,FileMode.Open);
            StreamReader reader = new StreamReader(File1);
            StreamWriter writer = new StreamWriter(File2);

            reader.Close();
            writer.Close();
        }

        static private void XMLtoJSON(string NameFile1, string NameFile2)
        {
            FileStream File1 = new FileStream(NameFile1, FileMode.Create);
            FileStream File2 = new FileStream(NameFile2,FileMode.Open);
            StreamReader reader = new StreamReader(File1);
            StreamWriter writer = new StreamWriter(File2);


            reader.Close();
            writer.Close();
        }


        static public void DeterminateFormat(string NameFile1, string NameFile2)
        {
            if (NameFile1.Contains(".json") && NameFile2.Contains(".xml"))
            {
                JSONtoXML(NameFile1, NameFile2);
            }
            else if (NameFile2.Contains(".json") && NameFile1.Contains(".xml"))
            {
                XMLtoJSON(NameFile1, NameFile2);
            }
            else
            {
                throw new Exception("Bad format of input file");
            }
        }

    }
}