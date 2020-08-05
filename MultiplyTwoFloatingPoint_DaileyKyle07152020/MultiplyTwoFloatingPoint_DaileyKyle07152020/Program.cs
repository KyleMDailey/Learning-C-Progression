//Student:  Kyle Dailey
//Date:  07/15/2020

/**************************************************************************************************************************************************************************************
This project contains code for a console application that multiplies two floating numbers.  

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace MultiplyTwoFloatingPoint_DaileyKyle07152020
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, product;
            number1 = 12.45f;
            number2 = 10.74f;

            product = number1 * number2;

            Console.WriteLine("{0} * {1} = {2}", number1, number2, product);
            Console.ReadLine();
        }
    }
}
