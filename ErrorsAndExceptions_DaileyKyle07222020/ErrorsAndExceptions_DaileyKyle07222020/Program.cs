//Student:  Kyle Dailey
//Date:  07/23/2020

/**************************************************************************************************************************************************************************************
This project contains code for a console application capable of solving several math equations and contains variables to handle errors and exceptions.

Revisions:  Updating this application to contain the error and exception handling blocks.

Revision Date:  08/01/2020

Revised By:  Kyle Dailey

***************************************************************************************************************************************************************************************/

using System;
using System.IO;

namespace ErrorsAndExceptions_DaileyKyle07222020
{
    class Program
    {
        static void Main()
        {
            //This code creates a main method/entry point as a main menu to choose with equation to do.
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }
        static bool MainMenu()
        //This block is the code for the menu and exit function.
        {
            Console.Clear();
            Console.WriteLine("Choose a math function:");
            Console.WriteLine("For the area of a circle press 1.");
            Console.WriteLine("For the volume of a hemisphere press 2.");
            Console.WriteLine("For the area of a triangle press 3.");
            Console.WriteLine("For a quadratic equation press 4.");
            Console.WriteLine("To exit press 5.");
            string result = Console.ReadLine();
            //Below is a try, catch, finally block which implements the menu and chooses the function to perform.
            try
            {
                if (result == "1")
                {
                    Circle();
                    return true;
                }
                else if (result == "2")
                {
                    Hemisphere();
                    return true;
                }
                else if (result == "3")
                {
                    Triangle();
                    return true;
                }
                else if (result == "4")
                {
                    Quadratic();
                    return true;
                }
                else if (result == "5")
                {
                    Exit();
                    return false;
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                    Console.ReadLine();
                    return true;
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.WriteLine("Press any key to return to the Main Menu.");
                Console.ReadLine();
                return true;
            }
            finally
            {
                Console.WriteLine("This program has finally terminated.");
            }
        }

        static bool Exit()
        {
            Console.ReadLine();
            return false;
        }

        //Basic Difficulty - Determine the area of a circle, volume of a hemisphere, and area of a triangle
        static void Circle()
        {
            //Area of a circle
            circleStart:
            //I don't like using the goto method, but I want users to stay withing each created method and try again if they enter an incorrect value type.
            Console.WriteLine("Determine the area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            try
            {
                if (radius < 0)
                {
                    Console.WriteLine("Please enter a number greater than 0. Press Enter to continue.");
                    Console.ReadLine();
                    goto circleStart;
                }
                else
                {
                    double area = checked(Math.PI * Math.Pow(radius, 2));
                    Console.WriteLine($"The area of the circle is {area}");
                    Console.ReadLine();
                }
            }
            catch (FormatException fEx)
            //I chose a format exception to catch any unknown errors.
            {
                Console.WriteLine(fEx.Message);
            }
            finally
            {
                Console.WriteLine("This is a circle.");
            }
        }


        static void Hemisphere()
        {
            //Volume of a hemisphere
            hemStart:
            Console.WriteLine("\nDetermine the volume of a hemisphere.");
            Console.Write("Enter an number for the radius: ");
            double hemradius = double.Parse(Console.ReadLine());
            try
            {
                if (hemradius <= 0)
                {
                    Console.WriteLine("Please enter a number greater than 0. Press Enter to continue.");
                    Console.ReadLine();
                    goto hemStart;
                }
                else if (hemradius > 0)
                { 
                    double volume = checked(4.0 / 3) * Math.PI * hemradius * hemradius * hemradius;
                    Console.WriteLine("The volume of the hemisphere is {0}.", volume);
                    Console.ReadLine();
                }
                
            }
            catch (FormatException fEx)
            //I chose a format exception to catch any unknown errors.
            {
                Console.WriteLine(fEx.Message);
            }
            finally
            {
                Console.WriteLine("This is a hemisphere.");
            }
        }

        static void Triangle()
        {
            //Area of a triangle
            triStart:
            Console.WriteLine("\nDetermine the area of a triangle.");
            try
            {
                double bottom = 1;
                double height = 1;

                if (bottom <= 0 || height <=0)
                {
                    Console.WriteLine("Please enter a number greater than 0. Press Enter to continue.");
                    Console.ReadLine();
                    goto triStart;
                }
                else if (bottom > 0 || height > 0)
                {
                    Console.WriteLine("Enter a number for base of your triangle:  ");
                    bottom = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a number for height of your triangle:  ");
                    height = double.Parse(Console.ReadLine());
                    double trianglearea = (bottom * height) / 2;
                    Console.WriteLine($"The area of the triangle is {trianglearea}.");
                    Console.ReadLine();
                } 
            }
            catch (FormatException fEx)
            //I chose a format exception to catch any unknown errors.
            {
                Console.WriteLine(fEx.Message);
            }
            finally
            {
                Console.WriteLine("This is a triangle.");
            }
        }

        public static void Quadratic()
        {
        //Quadratic Equation
        quadStart:
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            //double number1, number2, number3;
            try
            {
                double number1 = 1;
                double number2 = 1;
                double number3 = 1;

                if (number1 <= 0 || number2 <= 0 || number3 <= 0)
                {
                    Console.WriteLine("Please enter a number greater than 0. Press Enter to continue.");
                    Console.ReadLine();
                    goto quadStart;
                }
                else if (number1 > 0 || number2 > 0 || number3 > 0)
                {
                    Console.WriteLine("Enter a non-negative integer:  ");
                    number1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second non-negative integer:  ");
                    number2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a third non-negative integer:  ");
                    number3 = double.Parse(Console.ReadLine());
                    double positive_num = (-1 * number2) - (Math.Sqrt((number2 * number2) - (4 * number1 * number3)));
                    double negative_num = (-1 * number2) + (Math.Sqrt((number2 * number2) - (4 * number1 * number3)));

                    if ((number2 * number2) - (4 * number1 * number3) < 0)
                    //This if statement will prevent the Math.Sqrt function from attempting the square root of a negative number.
                    {
                        Console.WriteLine("We are not using imaginary numbers in this program.  Press Enter to continue.");
                        Console.ReadLine();
                        goto quadStart;
                    }
                    else
                    //If the Math.Sqrt function receives a positive value the program continues here.
                    {
                        double denominator = 2 * number1;
                        Console.WriteLine($"The positive solution is {positive_num / denominator}");
                        Console.WriteLine($"The negative solution is {negative_num / denominator}");
                        Console.ReadLine();
                    }
                }
            }
            catch (FormatException fEx)
            //I chose a format exception to catch any unknown errors.
            {
                Console.WriteLine(fEx.Message);
            }
            finally
            {
                Console.WriteLine("This is your quadratic equation.");
            }
        }
    }
}