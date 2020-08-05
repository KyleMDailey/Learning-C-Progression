//Student:  Kyle Dailey
//Date:  07/09/2020
//References:  w3schools, w3resource, Microsoft Visual C# Step by Step

/**************************************************************************************************************************************************************************************
This project contains code for a console application which takes input for 10 numbers and provides the sum.  

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace KyleDaileyCalculatingAverages1_07092020
{
    class Program
    {
        public static void Main()
        {
            int i, n, sum = 0;

            Console.Write("\n\n");
            Console.Write("Enter 10 numbers between 0 and 100 to see their sum:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 10 numbers : \n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;

                if (n > 0 && n > 100)
                {
                    Console.WriteLine("Please enter a number between 0 and 100.");
                    return;
                }
            }
            Console.Write("The sum of the ten numbers is: {0}", sum);
        }
    }
}
