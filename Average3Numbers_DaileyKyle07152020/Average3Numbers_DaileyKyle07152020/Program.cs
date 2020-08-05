//Student:  Kyle Dailey
//Date:  07/15/2020

/**************************************************************************************************************************************************************************************
This project contains code for a console application that finds the average of 3 numbers.  

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace Average3Numbers_DaileyKyle07152020
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, average;

            Console.Write("Enter first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            average = (number1 + number2 + number3) / 3;

            Console.Write("Average of three numbers is {0}", average);

            Console.ReadKey();
        }
    }
}
