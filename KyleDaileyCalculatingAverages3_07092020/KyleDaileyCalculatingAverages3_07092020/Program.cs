//Student:  Kyle Dailey
//Date:  07/09/2020
//References:  w3schools, w3resource, Microsoft Visual C# Step by Step

/**************************************************************************************************************************************************************************************
This project contains code for a console application which takes input for a specific number of test scores as defined by the user.  
It then reports back a letter grade. 

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace KyleDaileyCalculatingAverages3_07092020
{
    class Program
    {
        private static void Main()
        {
            Console.Write("Provide a specified number of test scores test scores to see the average and grade:\n");
            Console.Write("Input the specific number test scores:");

            int i, n = Convert.ToInt32(Console.ReadLine());
            float score, sum = 0, average; 
            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter Score {0}:", i);
                score = float.Parse(Console.ReadLine());
                sum = sum + score;

                if (score < 0)
                {
                    Console.WriteLine("Please enter a number between 0 and 100.");
                    return;
                }
                else if (score > 100)
                {
                    Console.WriteLine("Please enter a number between 0 and 100.");
                    return;
                }
            }

            average = sum / (i - 1);
            Console.WriteLine("Average:" + average);

            if (average >= 90 && average <= 100)
                Console.WriteLine("Grade: A");
            else if (average >= 80 && average <= 89)
                Console.WriteLine("Grade: B");
            else if (average >= 70 && average <= 79)
                Console.WriteLine("Grade: C");
            else if (average >= 60 && average <= 69)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
            Console.Read();
        }
    }

}
