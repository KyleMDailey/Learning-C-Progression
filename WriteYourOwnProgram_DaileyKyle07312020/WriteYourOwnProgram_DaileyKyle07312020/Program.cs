//Student:  Kyle Dailey
//Date:  07/31/2020

/**************************************************************************************************************************************************************************************
This project contains code for three console applications:  One that calculates tuition, one that converts feet to inches, and one that finds the greater of two numbers entered
by the user.  

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace WriteYourOwnProgram_DaileyKyle07312020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program 1.  A console application that calculates tuition over a five year period with a 2% increase each year.
            double year2, year3, year4, year5;
            double yearlyTuition = 60000;
            double percentIncrease = .02;
            try
            {
                Console.WriteLine("We will determine the tuition costs over the next five years.  Tuition is $60,000 the first year with a 2% increase each following year");
                Console.WriteLine($"The tuition for the first year is {yearlyTuition}.");
                year2 = (yearlyTuition * percentIncrease) + yearlyTuition;
                Console.WriteLine($"The tuition for the second year is {year2}.");
                year3 = (year2 * percentIncrease) + yearlyTuition;
                Console.WriteLine($"The tuition for the second year is {year3}.");
                year4 = (year3 * percentIncrease) + yearlyTuition;
                Console.WriteLine($"The tuition for the second year is {year4}.");
                year5 = (year4 * percentIncrease) + yearlyTuition;
                year5 = Math.Round(year5, 2);
                Console.WriteLine($"The tuition for the second year is {year5}.");
                Console.ReadLine();

            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("This program is finished.");
            }


            //Program 2.  A console application that converts feet to inches based on user entry.
            int i = 12;
            int f = 0;
            int convertedLength;

            try
            {
                Console.WriteLine("We are going to determine the number of feet in inches that you tell me.");
                Console.WriteLine("How many feet of bubblegum would you like?  I will let you know how many inches of bubblegum that is.");
                f = int.Parse(Console.ReadLine());
                convertedLength = f * i;
                Console.WriteLine($"{f} feet is {convertedLength} inches.");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("This program is finished.");
            }


            //Program 3.  A console application which finds the greater of two numbers entered by the user.
            double a;
            double b;
            try
            {
                Console.WriteLine("Please enter two numbers and I will determine which is greater.");
                Console.WriteLine("Please enter a number: ");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter another number: ");
                b = double.Parse(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine($"{a} is greater than {b}.");
                    Console.ReadLine();
                }
                else if (b > a)
                {
                    Console.WriteLine($"{b} is greater than {a}.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You did something wrong.");
                    Console.ReadLine();
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("This program is finished.");
            }
        }
    }
}
