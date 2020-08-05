//Student:  Kyle Dailey
//Date:  07/15/2020

/**************************************************************************************************************************************************************************************
This project contains code for a console application that computes the area and perimeter of a circle.  

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace AreaPerimeterCircle_DaileyKyle07152020
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, perimeter, area;
            Console.Write("Please enter the radius of your circle: ");
            r = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * 3.14 * r;
            area = 3.14 * Math.Pow(r, 2);
            Console.WriteLine("===========================================================");
            Console.WriteLine("The perimeter of your circle: {0}", perimeter);
            Console.WriteLine("The area of your circle: {0}", area);
            Console.ReadKey();
        }
    }
}
