//Student:  Kyle Dailey
//Date:  07/09/2020
//References:  w3schools, w3resource, Microsoft Visual C# Step by Step

/**************************************************************************************************************************************************************************************
This project contains code for a console application which takes input for an unspecified number of test scores and calculate their average.  
It then reports back a letter grade. 

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace KyleDaileyCalculatingAverages4_07092020
{
    class Program
    {
        private static void Main()
        {
            Console.Write("Provide your test scores to get an overall average and letter grade.\n");
            Console.Write("Input Done to finish.\n");

            int i = 0;
            float num, sum = 0, average;
            string input = "a";
            while (input != "done")
            {
                try
                {
                    Console.Write("Enter Score:");
                    num = float.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        Console.WriteLine("Please enter a number between 0 and 100.");
                        return;
                    }
                    else if (num > 100)
                    {
                        Console.WriteLine("Please enter a number between 0 and 100.");
                        return;
                    }
                    sum += num;
                    i++;
                }
                catch
                {

                    average = sum / i;
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
                    input = "done";

                }
            }
        }
    }

}