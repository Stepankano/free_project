

using System;
using System.Linq;
using System.Collections.Generic;


namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            char answer = '0';
            ListOfMatrix ListMatr = new ListOfMatrix();
            System.Console.WriteLine("Hello");
            while (answer != '7')
            {
                System.Console.WriteLine("Choose need option:");
                System.Console.WriteLine("1. Enter matrix through console");
                System.Console.WriteLine("2. Enter matrix through file");
                System.Console.WriteLine("3. Print matrix through console");
                System.Console.WriteLine("4. Print info");
                System.Console.WriteLine("5. Print all matrix, with certain determinate");
                System.Console.WriteLine("6. Print sort list");
                System.Console.WriteLine("7. Exit");
                answer = (char)System.Console.ReadLine()[0];
                switch (answer)
                {
                    case '1':
                        {
                            if(ListMatr.Count()>0){
                                ListMatr.MatrixPrint();
                            }
                            if (Matrix.TryParse(Console.ReadLine(), out Matrix matr))
                            {
                                ListMatr.AppendToList(matr);
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                        }
                        break;
                    case '2':
                        {
                            Console.WriteLine("Please, enter a path:");
                            ListMatr = MatrixLnOut.EnterMatrix(Console.ReadLine());
                        }
                        break;
                    case '3':
                        {
                            if(ListMatr.Count()!= 0){
                            ListMatr.MatrixPrint();
                        }
                            Console.WriteLine();
                        }
                        break;
                    case '4':
                        {
                           if(ListMatr.Count()!= 0){
                            Console.WriteLine($"Min element:");
                            ListMatr.MatrixPrint(ListMatr.MinMatrix());
                            Console.WriteLine($"Max element:");
                            ListMatr.MatrixPrint(ListMatr.MaxMatrix());
                            Console.WriteLine($"First element:");
                            var f = ListMatr.FirstOfList();
                            Console.WriteLine($"{f[0, 0]} {f[0, 1]} {f[1, 0]} {f[1, 1]}");
                            System.Console.WriteLine();
                            Console.WriteLine($"End element:");
                            var e = ListMatr.EndOfList();
                            Console.WriteLine($"{e[0, 0]} {e[0, 1]} {e[1, 0]} {e[1, 1]}");
                            System.Console.WriteLine();
                            Console.WriteLine($"Count of element:");
                            System.Console.WriteLine(ListMatr.ToArray().Length);
                            }else{
                                System.Console.WriteLine("List is empty");
                            }
                        }
                        break;
                    case '5':
                        {
                            if(ListMatr.Count()!=0){
                            ListOfMatrix ListMatrTMP = ListMatr;
                            System.Console.WriteLine("Enter determinate:");
                            double determinate = Console.Read();
                            ListMatrTMP = (ListOfMatrix)ListMatrTMP.ToArray().Select(x => x.get_determinator() <= determinate);
                            ListMatrTMP.MatrixPrint();
                            }else{
                                System.Console.WriteLine("List is empty");
                            }
                        }
                        break;
                    case '6':
                        {
                            if(ListMatr.Count()!=0){
                            ListOfMatrix ListMatrTMP = ListMatr;
                            ListMatrTMP = ListMatrTMP.SortList();
                            ListMatrTMP.MatrixPrint();
                            }else{
                                System.Console.WriteLine("List is empty");
                            }
                        }
                        break;
                    case '7':
                        break;
                    default:
                        {
                            Console.WriteLine("Wrong number, please, try again");
                        }
                        break;
                }


            }
            System.Console.WriteLine("Goodbye!");
            System.Console.ReadKey();

        }

    }

}
