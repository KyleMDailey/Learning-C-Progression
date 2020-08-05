//Student:  Kyle Dailey
//Date:  07/15/2020

/**************************************************************************************************************************************************************************************
This project contains code for a console application that adds two integers.  

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace AddIntegers_DaileyKyle07152020
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            Console.WriteLine("Calculate the sum of two numbers: ");
            Console.Write("Input number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.Write("Result: " + sum);

            Console.ReadKey();
        }
    }
}
