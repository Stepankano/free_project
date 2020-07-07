

using System;
using System.Linq;
using System.Collections.Generic;


namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
Test_HW_1.Test_Cens();
Test_HW_1.Test_FGN();
Test_HW_1.Test_FMI();
Test_HW_1.Test_FV();
        }

    }

    class HW_1
    {
        static public string Censor(string str, string[] old_word, string[] new_word) //capybara -> copypast
        {
            for(int i = 0;i<new_word.Length;i++){
               str =  str.Replace(old_word[i],new_word[i]);
            }
            return str;
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
    class Test_HW_1
    {
        static public void Test_Cens()
        {
            string[] old_word = new string[]{"capybara","to capybara","from capybara"};
            string[] new_word = new string[]{"copypast","to copypast","from copypast"};
            string test_Cens_1 = new string("I hear noise from capybara at forest");
            string test_Cens_2 = new string("Where is my capybara-backpack for that capybara?");
            Console.WriteLine(HW_1.Censor(test_Cens_1, old_word, new_word));
            Console.WriteLine(HW_1.Censor(test_Cens_2, old_word, new_word));
        }
        static public void Test_FGN()
        {
            int[] test_FGN_1 = new int[] { 6, 1, 2, 3, 4, 5, 6 }; //-1
            int[] test_FGN_2 = new int[] { 1, 4, 4, 4, 4, 5, 6 }; //4
            int[] test_FGN_3 = new int[] { 0, 0, 0, 0, 0, 0, 0 }; //0
            int[] test_FGN_4 = new int[] { 1 };                   //1
            Console.WriteLine(HW_1.FindGuideNumber(test_FGN_1));
            Console.WriteLine(HW_1.FindGuideNumber(test_FGN_2));
            Console.WriteLine(HW_1.FindGuideNumber(test_FGN_3));
            Console.WriteLine(HW_1.FindGuideNumber(test_FGN_4));
        }
        static public void Test_FMI()
        {
            int[] test_FMI_1 = new int[] { -4, -4, -4, 4, -4, -4, -4 }; //2,3,4
            int[] test_FMI_2 = new int[] { 3, -4, -2, 0, -3 };//3
            Console.WriteLine(HW_1.FindMainIndexes(test_FMI_1));
            Console.WriteLine(HW_1.FindMainIndexes(test_FMI_2));
        }
        static public void Test_FV()
        {
            int[] test_FV_1 = new int[] { 2, 1, 2, 1, 2, 1, 2 }; //3
            int[] test_FV_2 = new int[] { 1, 5, 1, 3, 1, 2, 1, 4 }; //12
            Console.WriteLine(HW_1.FindVolume(test_FV_1));
            Console.WriteLine(HW_1.FindVolume(test_FV_2));
        }
    }
    class Matrix
    {
        static private int rank = 2;
        static private double[,] matrix = new double[rank, rank];
        //  00 01
        //  10 11
        static private double determinator;

        public double get_determinator()
        {
            Determinate();
            return determinator;
        }
        static public void Determinate()
        {
            determinator = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        public double this[int x, int y]
        {
            get
            {
                return matrix[x, y];
            }
            set
            {
                matrix[x, y] = value;
            }
        }
        public Matrix FindReverseMatrix()
        {
            Matrix reverse = new Matrix();
            Determinate();
            reverse[0, 0] = matrix[1, 1] / determinator;
            reverse[0, 1] = -matrix[0, 1] / determinator;
            reverse[1, 0] = -matrix[1, 0] / determinator;
            reverse[1, 1] = matrix[0, 0] / determinator;
            return reverse;
        }
        static public Matrix operator +(Matrix one, Matrix two)
        {
            Matrix sum = new Matrix();
            sum[0, 0] = one[0, 0] + two[0, 0];
            sum[1, 0] = one[1, 0] + two[1, 0];
            sum[0, 1] = one[0, 1] + two[0, 1];
            sum[1, 1] = one[1, 1] + two[1, 1];
            return sum;
        }
        static public bool operator <(Matrix one, Matrix two)
        {
            return one.get_determinator() < two.get_determinator() ? true : false;
        }
        static public bool operator >(Matrix one, Matrix two)
        {
            return one.get_determinator() > two.get_determinator() ? true : false;
        }
        static public bool operator ==(Matrix one, Matrix two)
        {
            return one[0, 0] == two[0, 0] && one[0, 1] == two[0, 1] && one[1, 0] == two[1, 0] && one[1, 1] == two[1, 1];
        }
        static public bool operator !=(Matrix one, Matrix two)
        {
            return !(one[0, 0] == two[0, 0] && one[0, 1] == two[0, 1] && one[1, 0] == two[1, 0] && one[1, 1] == two[1, 1]);
        }
        static public Matrix operator *(Matrix one, Matrix two)
        {
            Matrix result = new Matrix();
            result[0, 0] = one[0, 0] * two[0, 0] + one[0, 1] * two[1, 0];
            result[0, 1] = one[0, 0] * two[0, 1] + one[0, 1] * two[1, 1];
            result[1, 0] = one[1, 0] * two[0, 0] + one[1, 1] * two[1, 0];
            result[1, 1] = one[1, 0] * two[0, 1] + one[1, 1] * two[1, 1];
            return result;
        }

        static public double operator /(Matrix one, Matrix two)
        {
            return one.get_determinator() / two.get_determinator();
        }
        public void Parse(string str)
        {
            // 00 01 10 11
            string[] str_array = str.Split(" ", 4);
            matrix[0, 0] = double.Parse(str_array[0]);
            matrix[0, 1] = double.Parse(str_array[1]);
            matrix[1, 0] = double.Parse(str_array[2]);
            matrix[1, 1] = double.Parse(str_array[3]);
        }
        public bool TryParse(string str, out Matrix matr)
        {
            string[] str_array = str.Split(" ", 4);
            byte result = 0;
            double number;
            Matrix tmp = new Matrix();

            if (double.TryParse(str_array[0], out number))
            {
                result++;
                tmp[0, 0] = number;
            }
            if (double.TryParse(str_array[1], out number))
            {
                result++;
                tmp[0, 1] = number;
            }
            if (double.TryParse(str_array[2], out number))
            {
                result++;
                tmp[1, 0] = number;
            }
            if (double.TryParse(str_array[3], out number))
            {
                result++;
                tmp[1, 1] = number;
            }
            if (result == 4)
            {
                matr = tmp;
                return true;
            }
            else
            {
                tmp[0,0]=tmp[0,1]=tmp[1,0]=tmp[1,1]=0;
                matr = tmp;
                return false;
            }
        }
    }
}
