using System;

namespace ProjectEuler
{
    class ChamperConstTest
    {
        static public bool FuncTest()
        {
            bool Check = true;
            Check = Check && ChamperConst.ChamperConstFunc(new int[] { 4 }).Equals(4);
            Check = Check && ChamperConst.ChamperConstFunc(new int[] { 2, 3 }).Equals(6);
            Check = Check && ChamperConst.ChamperConstFunc(new int[] { 10, 11 }).Equals(0);
            Check = Check && ChamperConst.ChamperConstFunc(new int[] { 10, 12, 13 }).Equals(1);
            Check = Check && ChamperConst.ChamperConstFunc(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).Equals(362880);
            return Check;
        }
        static public bool CurrentNumberTest()
        {
            bool Check = true;
            Check = Check && (ChamperConst.CurrentNumber(1) == 1);
            Check = Check && (ChamperConst.CurrentNumber(9) == 9);
            Check = Check && (ChamperConst.CurrentNumber(10) == 1);
            Check = Check && (ChamperConst.CurrentNumber(11) == 0);
            Check = Check && (ChamperConst.CurrentNumber(12) == 1);
            Check = Check && (ChamperConst.CurrentNumber(13) == 1);
            Check = Check && (ChamperConst.CurrentNumber(14) == 1);
            Check = Check && (ChamperConst.CurrentNumber(15) == 2);
            return Check;
        }
        
            //TODO: improve writing of tests
    }
}

