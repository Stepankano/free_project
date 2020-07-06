

using System;
using System.Linq;
using System.Collections.Generic;


namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] test_FGN_1 = new int[] { 6, 1, 2, 3, 4, 5, 6 }; //-1
            int[] test_FGN_2 = new int[] { 1, 4, 4, 4, 4, 5, 6 }; //4
            int[] test_FGN_3 = new int[] { 0, 0, 0, 0, 0, 0, 0 }; //0
            int[] test_FGN_4 = new int[] { 1 };                   //1
            Console.WriteLine(HW_1.FindGuideNumber(test_FGN_1));
            Console.WriteLine(HW_1.FindGuideNumber(test_FGN_2));
            Console.WriteLine(HW_1.FindGuideNumber(test_FGN_3));
            Console.WriteLine(HW_1.FindGuideNumber(test_FGN_4));



            int[] test_FMI_1 = new int[] { -4, -4, -4, 4, -4, -4, -4 }; //2,3,4
            int[] test_FMI_2 = new int[] { 3, -4, -2, 0, -3 };//3
            Console.WriteLine(HW_1.FindMainIndexes(test_FMI_1));
            Console.WriteLine(HW_1.FindMainIndexes(test_FMI_2));



            int[] test_FV_1 = new int[] { 2, 1, 2, 1, 2, 1, 2 }; //3
            int[] test_FV_2 = new int[] { 1, 5, 1, 3, 1, 2, 1, 4 }; //12
            Console.WriteLine(HW_1.FindVolume(test_FV_1));
            Console.WriteLine(HW_1.FindVolume(test_FV_2));


            string old_word = new string("capybara");
            string new_word = new string("time-traveler");
            string test_Cens_1 = new string("I see a capybara at forest");
            string test_Cens_2 = new string("Where is my capybara-backpack for that capybara?");
            Console.WriteLine(HW_1.Censor(test_Cens_1, old_word,new_word));
            Console.WriteLine(HW_1.Censor(test_Cens_2, old_word,new_word));
        }

    }

    class HW_1
    {
        static public string Censor(string str, string old_word, string new_word) //capybara -> copypast
        {
            string new_str = new string("");
            int ending=0;
            for (int i = 0; i < str.Length-old_word.Length; i++)
            {
                if (str[i..(old_word.Length + i)].Equals(old_word))
                {
                    new_str += new_word;
                    i += old_word.Length;
                }
                new_str += str[i];
                ending = i+1;
            }
            for(int i = ending;i<str.Length;i++){
                new_str+=str[i];
            }

            return new_str;
        }
        static public int FindGuideNumber(int[] list)
        {
            var list_new = (list.OrderBy(x => x)).ToList();

            int local_max = 1;
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (list_new[i] == list_new[i + 1])
                {
                    local_max += 1;
                }
                else
                {
                    if (local_max > list.Length / 2)
                    {
                        return list[i];
                    }
                    local_max = 1;
                }
            }
            return local_max > list.Length / 2 ? list_new[list.Length - 1] : -1;
        }

        static public int[] FindMainIndexes(int[] list)
        {

            int[] index = new int[0];
            for (int x = 0; x < list.Length; x++)
            {
                if (list[0..(x + 1)].Sum() == list[x..list.Length].Sum())
                {
                    index.Append(x);
                };
            }
            return index;

        }
        static public int FindVolume(int[] list) //FAANG
        {
            int volume = 0;
            for (int i = 1; i <= list.Max(); i++)
            {
                int left_bord = 0, right_bord = 0;
                for (int k = 0; k < list.Length; k++)
                {
                    if (list[k] >= i)
                    {
                        left_bord = k;
                        break;
                    }
                }
                for (int k = list.Length - 1; k >= 0; k--)
                {
                    if (list[k] >= i)
                    {
                        right_bord = k;
                        break;
                    }
                }
                for (int k = left_bord + 1; k < right_bord; k++)
                {
                    volume += list[k] >= i ? 0 : 1;
                }
            }

            return volume;
        }
    }
}
