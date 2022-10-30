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
        }
    }
}
