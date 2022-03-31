using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {

        string[] address = { "Street: 9012 Corran Ferry Drive", "City: Austin", "State:Texas" };
        Console.WriteLine("Please select 1 for street, 2 for city, and 3 for State.");
        int ans = Convert.ToInt32(Console.ReadLine());
        //bool status = true;

        if (ans == 1)
            Console.WriteLine("The street is  " + address[0]);

        if (ans == 2)
            Console.WriteLine("The city is   " + address[1]);

        if (ans == 3)
            Console.WriteLine("The state is " + address[2]);

        else if (ans > 3)
            Console.WriteLine("Please select number between 1 and 3");
        Console.ReadLine();

    }
}
        
       

        //    // ARRAY is data structure that stores multiple values in a single variable, instead 
        //    //of declaring separate variables for each value. Used when working with fixed quantity that
        //    //isn't going to change. Also use arrays if storing large quantity of something. 
            


        //    //ARRAYS are an object and we must create a new object of it.

        //    int[] numArray = new int[5];//Must give data type of array. Must define length of it (5)
        //    numArray[0] = 5;
        //    numArray[1] = 2;
        //    numArray[2] = 10;
        //    numArray[3] = 200;
        //    numArray[4] = 5000;

        //    Console.WriteLine(numArray[3]);


        ////Faster way of making an array

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //more flexible because length not set. 
        //Console.WriteLine(numArray1[3]);

        ////Even faster way of making an array
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 }; //cSharp figures out this is new instance of an array
        //Console.WriteLine(numArray2[0]);

        ////Changing value in an array

        //numArray2[0] = 200;
        //Console.WriteLine(numArray2[0]);

        ////LIST - much more adaptable and more methods connected to them. 

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //Console.WriteLine(intList[1]);
        //intList.Remove(4);
        //Console.WriteLine(intList[0]);

        




    
        

