//Student:  Kyle Dailey
//Date:  07/15/2020

/**************************************************************************************************************************************************************************************
This project contains code for a console application that computes the area of a rectangle.  

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace CalculateRectangleArea_DaileyKyle07152020
{
    class Program
    {
        static void Main(string[] args)
        {
            int area, length, width;
            Console.Write("Please enter the length of your rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the width of your rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());
            area = length * width;
            Console.WriteLine("The area of the rectangle: {0}", area);
            Console.ReadKey();
        }
    }
}
