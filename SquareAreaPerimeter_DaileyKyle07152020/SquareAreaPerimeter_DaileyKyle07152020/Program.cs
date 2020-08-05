//Student:  Kyle Dailey
//Date:  07/15/2020

/**************************************************************************************************************************************************************************************
This project contains code for a console application that computes the area and perimeter of a square.  

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace SquareAreaPerimeter_DaileyKyle07152020
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareheight, area, perimeter;
            Console.Write("What is the height of your square?: ");
            squareheight = Convert.ToInt32(Console.ReadLine());
            area = squareheight * squareheight;
            perimeter = 4 * squareheight;
            Console.WriteLine("Area: {0}\nPerimeter: {1}", area, perimeter);
            Console.ReadKey();
         }
    }
}
