using System;

namespace ProjectEuler
{
    class ChamperConst
    {
        static public int ChamperConstFunc(int[] Numbers) //main func
        {
            int result = 1;
            foreach (int i in Numbers)
            {
                result *= CurrentNumber(i);
            }
            return result;
        }
        static public int CurrentNumber(int Position) //subfunction (if that word exist)
        {
            int NewPosition = Position;
            for (int i = 1; i <= Position; i++)
            {
                if (NewPosition - i.ToString().Length > 0)
                {
                    NewPosition -= i.ToString().Length;
                    continue;
                }
                return (int)(i.ToString()[NewPosition - 1])-48;
            }
            Exception WrongNum = new Exception("Wrong number");
            throw WrongNum;
        }
    }
}