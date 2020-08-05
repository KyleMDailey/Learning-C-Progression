//Class:  ERAU ISTA220 Programming Fundamentals
//Student:  Kyle Dailey
//Date:  07/09/2020
//References:  w3schools, w3resource, Microsoft Visual C# Step by Step

/**************************************************************************************************************************************************************************************
This project contains code for a console application which takes input for 10 numbers and provides the average of those 10 numbers.  It then reports back a letter grade. 

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace KyleDaileyCalculatingAverages2_07092020
//This program was started in the early phases of learning C# more or less from scratch for me.  
{
    class Program
    {
        private static void Main()
        {
            Console.Write("Provide 10 test scores to see the average and grade:\n");
            Console.Write("Input the 10 test scores:\n");

            float score, sum = 0, average = 0; int i;

            for (i = 1; i <= 10; i++)
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
