using System;
using System.Collections.Generic;
using System.Collections;

namespace Generics_DaileyKyle09152020
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Cast - this is an implicit cast. Changing the datatype myInt to myDouble, smaller to larger type. 
            //int myInt = 91;
            //double myDouble = myInt;

            ////Explicit casting, converting larger to smaller type
            ////double > float > long > int
            ////This may cause data loss as you are changing a value capable of holding more information to one that is only capable of smaller amounts of information.  Example: double to int

            //double myDouble2 = 98.95;
            //int myInt2 = (int)myDouble2;



            ////Boxing and Unboxing
            ////Boxing is changing a value type to a reference type. Unboxing is the opposite.

            ////Boxing
            //int num = 2020;
            //object obj = num;
            //num = 100;

            //Console.WriteLine("Value - type value of num is: {0}", num);
            //Console.WriteLine("Object - type of obj is: {0}", obj);


            ////Unboxing
            //int num3 = 23;
            //object obj3 = num3;
            //int i = (int)obj3;

            //Console.WriteLine("Value - type value of object is: " + obj3);
            //Console.WriteLine("Object i is: " + i);
            //Console.ReadLine();


            ////Collections
            ////List, generic collection List<T>
            //List<int> myList = new List<int>();

            //for (int j = 5; j < 10; j++)
            //{
            //    myList.Add(j * 3);
            //}

            //foreach (int items in myList)
            //{
            //    Console.WriteLine(items);
            //}


            //ArrayLists, Hashtable, Queue, and Stack
            //Queue, creating a queue
            Queue myQueue = new Queue();

            myQueue.Enqueue("Oculus Rift");
            myQueue.Enqueue("Oculus RiftS");
            myQueue.Enqueue("Oculus Go");
            myQueue.Enqueue("Oculus Quest");
            myQueue.Enqueue("Oculus Quest 2");

            Console.WriteLine(myQueue.Count);
            Console.WriteLine("Beginning item is: " + myQueue.Peek());
        }
    }
}
