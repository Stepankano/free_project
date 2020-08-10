using System;
using System.Collections.Generic;

namespace PanDigitalNumber
{
    class PanDigit{
        static public bool PrimeNumber(long number){
            if(number==1 || number == 2 || number ==3 || number%2!=0){
                return true;
            }
            for(long i=3;i<number/3;i+=2){
                if(number%i == 0){
                    return false;
                }
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
            long number = 9876543201;
            for(;number>1;number-=2){
                System.Console.WriteLine($"{number}   {PrimeNumber(number)}   {PanDigital(number)} ");
                if(PrimeNumber(number) && PanDigital(number)){
                    System.Console.WriteLine($"Find the biggest Prime-Pan-Digital Number: {number}");
                    return;
                }
            }
        }
    }
}