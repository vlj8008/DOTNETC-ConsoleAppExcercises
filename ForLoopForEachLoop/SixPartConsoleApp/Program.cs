using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        //Iterating through string array using For Loop and Foreach Loop:

        //For Loop:

        string[] details = { "Address of ", "Age of  ", "Email address of ", "Phone number of " }; //created an array of strings

        Console.WriteLine("What is your name ?"); //ask user for their name. 
        string firstName = Console.ReadLine(); //store user name in variable called firstName 


        for (int detail = 0; detail < details.Length; detail++)
        // Statement 1: what index of the details array do we start from.
        // Statement 2: for how long do we execute block of code below (four times).
        // Statement 3: increment the detail variable by one. 
        {
            details[detail] = details[detail] + firstName; //changing each item in array by adding the users name at the end.
        }

        //Foreach Loop:

        foreach (string detail in details)
        {
            Console.WriteLine(detail); //writing the new array (with the user name added) to the console.
        }

        

        //Infinite Loop:
        //
        //Code below is an infinite loop as the detail variable is being decremented and will always be less than the length
        //of the array.
        //for (int detail = 0; detail < details.Length; detail--)
        //{

        //    Console.WriteLine(detail);

        //}

        //Here is the correction

        Console.WriteLine("What is your last name ?");
        string lastName = Console.ReadLine();

        //the loop below is not an infinite loop as the detail will eventually be more than the details length.
        for (int detail = 0; detail < details.Length; detail++)

        {
            details[detail] = details[detail] + lastName; //changing each item in array by adding the users last name at the end.
        }


        foreach (string detail in details)
        {
            Console.WriteLine(detail);
        }

        //Iterating through integer array using For Loop

        int[] countDown = { 1, 22, 3, 44, 5, 66, 7, 8, 9, 0 };

        for (int number = 0; number < countDown.Length; number++)
        {

            Console.WriteLine(countDown[number]);
        }

        for (int number2 = 0; number2 <= 4; number2++)
        {
            Console.WriteLine(countDown[number2]);
        }
        
        //Iterating through list using Foreach Loop.

        List<string> raceOneHorses = new List<string>() { "Bobby", "Phar Lap", "Black Beauty", "Lightning" };
        Console.WriteLine("Enter the horse's name to check to see if it is in Race 1");
        string name = Console.ReadLine();


        foreach (string horse in raceOneHorses)
        {
            if (horse == name)
            {
                Console.WriteLine("That horse is in race 1");

                Console.WriteLine("\nIndex of {0} : {1}", name, raceOneHorses.IndexOf(name)); //using IndexOf method to find index of value
                break;//exit out of this code block.
            }

        }

        if (!raceOneHorses.Contains(name))//if horseName doesn't contain the user input name. 
        {
            Console.WriteLine(name + " is NOT in race 1");
        }
        Console.WriteLine("Moving on with the program");


        List<string> numList = new List<string>() { "one", "two", "one", "three", "four", "five", "four" };
        Console.WriteLine("Please enter the number you would like to search for to see if it is on the list?");
        string name1 = Console.ReadLine();

        bool found = false; //making a varaiable called found to be used in for loop. 

        for (int i = 0; i < numList.Count; i++) 

        {
            if (numList[i]== name1)
            {
                Console.WriteLine("Your number was found at index: {0}", i);
                found = true;
            }
             
        }

        if (!found)
        {
            Console.WriteLine("Your number is not in the list");
        }

        Console.WriteLine("Moving on with the program");

        //Console App Part Six Assignment

        List<string> colors = new List<string>() { "black", "purple", "black", "green", "purple", "yellow", "blue" };
        List<string> colorsList2 = new List<string>(); //making new list that is empty. 

        Console.WriteLine("Pick a color you think may be in the list..");
        string ans = Console.ReadLine();
        colorsList2.Add(ans);

        foreach (string color in colors) //for each of the colors in the list above do the following:
        {

            if (colorsList2.Contains(color))
            {
                Console.WriteLine(" This color has already been seen before. The color is " + color);

            }
            else
            {
                Console.WriteLine("This color has not been seen. The color is " + color);
                colorsList2.Add(color);

            }   
        }

       

        Console.WriteLine("We have come to the end of the program.");

        Console.ReadLine();

       
    }
}



//More practise:

//Integer Array

//int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };//instantiating array the easy way

//for (int i = 0; i<testScores.Length; i ++)//first condition is starting point. Second: how long do for loop ?
//                                          //third after for loop add i. 
//{
//    if (testScores[i]>85)
//    {
//        Console.WriteLine("Passing test score: " + testScores[i]);

//    }
//}
//Console.ReadLine();

//String Array:

//string[] names = { "Vicky", "Sammy", "Billy", "Adam" };

//for (int j = 0; j < names.Length; j++)
//{

//    Console.WriteLine(names[j]);


//Int Array:

//int[] numberArray = { 300, 75, 420, 380, 225 };//Declare array by defining variable type and then using square brackets. 

//for (int k = 0; k < numberArray.Length; k++)//statement 1: is executed one time before the execution of the code block (K equals value in index 0)
//    //statement 2: defines condition for executing code block ()
//    //statement 3: executes every time after the code block has been executed.
//{
//    if(numberArray[k]/2 >=150)
//    {
//        Console.WriteLine(numberArray[k] + " divided by 2 is greater than or equal to 150.");
//    }

//List:

//List<int> testScores = new List<int>(); //instantiating new list from list class.
//testScores.Add(98);
//testScores.Add(99);
//testScores.Add(81);
//testScores.Add(72);
//testScores.Add(70);

////score is variable and it represents an item in the list

//foreach (int score in testScores)
//    {
//    if (score > 85)
//    {
//        Console.WriteLine("Passing test score:" + score);
//    }

//List<string> names = new List<string>() { "Jesse", "Adam", "Eric", "Daniel" }; //instantiating list immediately

//foreach (string name in names)
//{
//    if (name == "Jesse")
//    {
//        Console.WriteLine(name);
//    }

//List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
//List<int> passingScores = new List<int>(); //blank list with nothing inside

//foreach (int score in testScores)
//{
//if (score > 85)
//    {
//        passingScores.Add(score);
//    }
//}
//Console.WriteLine(passingScores.Count);
//Console.ReadLine();










