//Student:  Kyle Dailey
//Date:  07/22/2020

/**************************************************************************************************************************************************************************************
This project contains code for a console application which asks user's the dimensions for a rectangle and calculates the area and displays it to the console.  

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace RectangleArea_DaileyKyle07222020
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length of your triangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of your triangle: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine("The area of the rectangle is {0}", area);
        }
    }
}
