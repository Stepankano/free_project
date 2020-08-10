using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine($"Test of subfunction: {(ChamperConstTest.CurrentNumberTest()==true?"done":"error")}");
            System.Console.WriteLine($"Test of main func: {(ChamperConstTest.FuncTest()==true?"done":"error")}");
            int result = ChamperConst.ChamperConstFunc(new int[]{1,10,100,1000,10000,100000,1000000});
            System.Console.WriteLine($"Result of site`s task: {result}");
        }
    }
}
