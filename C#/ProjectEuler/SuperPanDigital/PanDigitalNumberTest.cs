using System;

namespace PanDigitalNumber
{
    class PanDigitalNumberTest
    {
        static public void GeneralTest()
        {
            PrimeNumberTest();
            PanDigitTest();
        }
        static private void PrimeNumberTest()
        {
            bool Check = true;
            Check = Check && PanDigit.DivSubstring(1406357289).Equals(true);
            System.Console.WriteLine($"Division Substring Test:  {(Check == true ? "done" : "errur")}");
        }
        static private void PanDigitTest()
        {
            bool Check = true;
            Check = Check && PanDigit.PanDigital(1).Equals(true);
            Check = Check && PanDigit.PanDigital(2).Equals(true);
            Check = Check && PanDigit.PanDigital(3).Equals(true);
            Check = Check && PanDigit.PanDigital(103).Equals(true);
            Check = Check && PanDigit.PanDigital(11).Equals(false);
            Check = Check && PanDigit.PanDigital(17).Equals(true);
            Check = Check && PanDigit.PanDigital(191).Equals(false);
            Check = Check && PanDigit.PanDigital(3113).Equals(false);
            Check = Check && PanDigit.PanDigital(1234567890).Equals(true);
            System.Console.WriteLine($"Pan Number Test:  {(Check == true ? "done" : "errur")}");
        }
    }
}