using System;
using System.IO;

namespace PokerHands
{
    class Program
    {
        static void Main()
        {
            string Path = new string(@"C:\Users\Praetor\Labs\Free Projects\C#\ProjectEuler\PokerHands\poker.txt");
            int One = 0;
            FileStream File = new FileStream(Path,FileMode.Open);
            StreamReader Stream = new StreamReader(File);
            string Str = new string("");
            Str = Stream.ReadLine();
            while( Str != null){
            string[] TwoHand = Str.Split(' ',10);
            Str = Stream.ReadLine();
            }
        }
    }
}
