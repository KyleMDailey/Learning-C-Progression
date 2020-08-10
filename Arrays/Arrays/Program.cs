//Student:  Kyle Dailey
//Date:  08/10/2020

/**************************************************************************************************************************************************************************************
This project contains code for arrays. 

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trivia about arrays
            //In C# index arrays start with 0.
            //Languages that are not 0 baseds include:  Fortran, Julia, and Smalltalk

            //Declare our fist array.  Array is:
            //int[] evenNums; //integer array
            //string[] cities; //cities

            //int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };

            //This creates an array of city names
            //string[] cities = new string[3] { "Fayetteville", "Broadway", "Sanford" };
            //Console.WriteLine(cities[0]);
            //Console.WriteLine(cities[1]);
            //Console.WriteLine(cities[2]);
            //Console.ReadLine();

            //This creates a number array
            //int[] evenNums = new int[5];
            //evenNums[0] = 2;
            //evenNums[1] = 4;
            //evenNums[6] = 12; 

            //Late initialization.  Adding values after the initial array is created.
            //int[] evenNums = new int[5];
            //evenNums[0] = 2;
            //evenNums[1] = 4;
            //evenNums[4] = 12; //What is the error here? A:  This was initialized above.
            //Console.WriteLine(evenNums[0]);
            //Console.WriteLine(evenNums[1]);
            //Console.WriteLine(evenNums[4]);
            //Console.ReadLine();


            //Practice creating a string array
            //string[] authors = new string[4] { "Aleister Crowley", "Raymond Buckland", "Mark Allan Smith", "Hermes Trismegestus" };
            ////Console.WriteLine(authors[0]);
            ////Console.WriteLine(authors[1]);
            ////Console.WriteLine(authors[2]);
            ////Console.WriteLine(authors[3]);
            ////Console.ReadLine();
            //foreach (var author in authors)
            //    //attempting to get the string to print
            //Console.WriteLine(author);
            //Console.ReadLine();


            //int[] evenNums = { 2, 4, 6, 8, 10 };
            ////Initialize array

            //for(int i = 0; i < evenNums.Length; i++)
            ////For loop to print array
            //Console.WriteLine(evenNums[i]);
            //Console.ReadLine();  


            //Practice
            //int[] evenNums = { 2, 4, 6, 8, 10 };
            //string[] cities = { "Chicago", "Beecher", "Crete " };
            
            //foreach (var item in evenNums)
            //Console.WriteLine(item);

            //foreach (var city in cities)
            //Console.WriteLine(city);
            //Console.ReadLine();
        }
        try
            {
                //Sorting.
                int[] evenNums = { 6, 3, 7, 8, 1 };
                string[] cities = new string[3] { "Fayetteville", "Broadway", "Sanford" };
                Array.Sort(cities);
                Array.Sort(evenNums);
                //Sorting cities alphabetically.
                Console.WriteLine(cities[0]);
                Console.WriteLine(cities[1]);
                Console.WriteLine(cities[2]);
                //Sorting numbers alphanumerically.
                Console.WriteLine(evenNums[0]);
                Console.WriteLine(evenNums[1]);
                Console.WriteLine(evenNums[2]);
                Console.WriteLine(evenNums[3]);
                Console.WriteLine(evenNums[4]);
                Console.ReadLine();
            }
            catch
            {
                //Put your errors here.  Define your exceptions etc.
            }
            finally
            {
                //The code that always executes.
            }
    }
}
 
