using System;
using System.Collections.Generic;
using System.Linq;

namespace PanDigitalNumber
{
    class PanDigit{
        static public bool DivSubstring(long number){
            if(((number/1000000)%2==0)&& ((number/100000)%1000)%3==0 && ((number/10000))%1000%5==0 && (number/1000)%1000%7==0 && (number/100)%1000%11==0 && (number/10)%1000%13==0 && number%1000%17==0){
                return true;
            }
            return false;
        }
        static public bool PanDigital(long number){
            Dictionary<char,int> DigitAtNum = new Dictionary<char,int>();
            string num = number.ToString();
            foreach(char i in num){
                if(DigitAtNum.ContainsKey(i)){
                    return false;
                }
                DigitAtNum.Add(i,1);
            }
            return true;
        }
        static public void SearchNumber(){ //main function of task 
            long number = 1000000000;
            List<long> Array = new List<long>();
            for(;number<9876543210;number++){
                if(number%100000000==0){
                    System.Console.Write($"\n{(int)((number/100000000-10)*1.136363)}% ");
                }
                if(DivSubstring(number) && PanDigital(number)){
                    Array.Add(number);
                    System.Console.Write($"{number} ");
                    //System.Console.WriteLine($"{number}   {DivSubstring(number)}   {PanDigital(number)} ");
                   // return;
                  //  System.Console.WriteLine($"Find Strange-Pan-Digital Number: {number}");
                   // return;
                }
            }
            
            System.Console.WriteLine($"Sum of Strange-Pan-Digital Numbers: {Array.Sum()}");
        }
    }
}