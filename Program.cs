using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_8__METHODS__RECURSIVE_
{
    class Program
    {
        const int theContractSum = 700;
        public int debt = 700;
       public double res = default(double);
        //---------------------------------------------------------------------------


        // Additional Task

        public static string Calculate(int param1, int param2, int param3)
        {
            int divider = 5;
            return $"First:\t{param1 / divider}\n" +
                $"Second:\t{param2 / divider}\n" +
                $"Third:\t{param3 / divider}\n";
        }
        //---------------------------------------------------------------------------


        // Task 2

        public void TheDebtIsAbsent()
        {
            if(debt == 0)
                Console.WriteLine("The debt is absent!");
            else
                Console.WriteLine("The sum of debt\t" + debt);
        }
        //---------------------------------------------------------------------------

        public void OverPay()
        {
            if(debt <= 0)
                Console.WriteLine("The sum of overpay\t" + debt);
            else
                Console.WriteLine("Overpay is absent!");
        }
        //---------------------------------------------------------------------------

        public void PayOffTheDebtor(ref int debt)
        {
            Console.WriteLine("Enter the sum of money to pay ->");
            int payTheDebt = int.Parse(Console.ReadLine());

            if (payTheDebt != 0)
            {
                this.debt -= payTheDebt;
                Console.WriteLine("The sum of debt left:\t" + this.debt);
                TheDebtIsAbsent();
            }
        }
        //---------------------------------------------------------------------------

        public static void ShowStatus()
        {
            
            new Program().PayOffTheDebtor(ref new Program().debt);
            new Program().OverPay(); 
        }
        //---------------------------------------------------------------------------

        public static void CheckADebtor(int sumToCheck)
        {
            if(sumToCheck == theContractSum)
            {
                ShowStatus();
            }
            else
                Console.WriteLine("No anyone who is a debtor!"); 
        }
        //---------------------------------------------------------------------------


        // Task 3

        public static void CountTheWaysOfShipping(ref int n)
        {
            if(n != 0)
            {
                --n;
                Console.WriteLine($"The ways of shipping:\t {n}");
                CountTheWaysOfShipping(ref n);
            }
            else
                Console.WriteLine("Unfortunately but no one way wasn't founded!");
        }
        //---------------------------------------------------------------------------


        // Task 4

        public void DivisionByModule(double value1, double value2)
        {
            if (value1 == 0 && value2 == 0)
                return;
            else
            {
                this.res = value1 % value2;
                Console.WriteLine($"The digit of division by module:\t{this.res}");
            }
        
        }
        //---------------------------------------------------------------------------

        public void Exponatiation(double value1, double value2)
        {
            this.res = Math.Pow(value1, value2);
            Console.WriteLine($"The result of power of two:\t{this.res}");
        }
        //---------------------------------------------------------------------------

        public void Concatenation(double value1, double value2)
        {
            string str1 = $"The first value: {value1}";
            string str2 = $"The second value: {value2}";
            Console.WriteLine("The result of concatenation:\t" + str1 + str2);
        }
        //---------------------------------------------------------------------------

        public void Division(double value1, double value2)
        {
            this.res = value1 / value2;
            Console.WriteLine($"The result of division:\t{this.res}");
        }
        //---------------------------------------------------------------------------

        public void ControllerOfAriphmeticOperations()
        {
            string str = default(string);

            Console.Write("Enter first value ->");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Enter first value ->");
            int value2 = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Choose the operation ->\t");
                str = Console.ReadLine();

                switch (str)
                {
                    case "bymodule":
                        DivisionByModule(value1, value2);
                        break;
                    case "exponent":
                        Exponatiation(value1, value2);
                        break;
                    case "concat":
                        Concatenation(value1, value2);
                        break;
                    case "div":
                        Division(value1, value2);
                        break;
                    default:
                        Console.WriteLine("Try again! Wrong command!");
                        break;
                }
            }  while (str != "exit");  
        }
        //---------------------------------------------------------------------------

        public static void Main()
        {
            // Additional Task

            //---------------------------------------------------------

            //Console.WriteLine(Calculate(10, 20, 30));

            //---------------------------------------------------------


            // Task 2

            //---------------------------------------------------------

            //CheckADebtor(700);

            //---------------------------------------------------------


            // Task 3

            //---------------------------------------------------------

            //int factorial = 10;
            //CountTheWaysOfShipping(ref factorial);

            //---------------------------------------------------------


            // Task 4

            new Program().ControllerOfAriphmeticOperations();
        }
    }
}
