using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        //Part One Assignment

        string[] details = { "Address of ", "Age of  ", "Email address of ", "Phone number of " };

        Console.WriteLine("What is your name ?");
        string firstName = Console.ReadLine();


        for (int detail = 0; detail < details.Length; detail++)
        // Statement 1: what index of the details array do we start from.
        // Statement 2: for how long do we execute block of code below (four times).
        //Statement 3: increment the detail variable by one. 
        {
            details[detail] = details[detail] + firstName; //changing each item in array by adding the users name at the end.
        }


        foreach (string detail in details)
        {
            Console.WriteLine(detail);
        }

        //Part Two Assignment

        //Code below is an infinite loop as the detail variable is being decremented and will always be less than the length
        //of the array.

        //for (int detail = 0; detail < details.Length; detail--)
        //{

        //    Console.WriteLine("whatever" + detail);

        //}

        //Here is the correction

        Console.WriteLine("What is your last name ?");
        string lastName = Console.ReadLine();

        for (int detail = 0; detail < details.Length; detail++)

        {
            details[detail] = details[detail] + lastName; //changing each item in array by adding the users last name at the end.
        }


        foreach (string detail in details)
        {
            Console.WriteLine(detail);
        }
        //Part Three Assignment

        int[] countDown = { 1, 22, 3, 44, 5, 66, 7, 8, 9, 0 };

        for (int number = 0; number < countDown.Length; number++)
        {

            Console.WriteLine(countDown[number]);
        }

        for (int number2 = 0; number2 <= 4; number2++)
        {
            Console.WriteLine(countDown[number2]);
        }
        //Part Four Assignment

        List<string> horseName = new List<string>() { "Bobby", "Phar Lap", "Black Beauty", "Lightning" };
        Console.WriteLine("Enter the horse's name to check to see if it is in Race 1");
        string name = Console.ReadLine();



        foreach (string horse in horseName)
        {
            if (horse == name)
            {
                Console.WriteLine("That horse is in race 1");

                Console.WriteLine("\nIndex of {0} : {1}", name, horseName.IndexOf(name));
                break;//exit out of this code block.
            }

        }

        if (!horseName.Contains(name))//if horseName doesn't contain the user input name. 
        {
            Console.WriteLine(name + " is NOT in race 1");
        }
        Console.WriteLine("Moving on with the program");

        
        Console.ReadLine();
    }
} 



        //More practice looping

        //Integer Arrays:

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

        //String Arrays:

        //string[] names = { "Vicky", "Sammy", "Billy", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{

        //    Console.WriteLine(names[j]);


        //int[] numberArray = { 300, 75, 420, 380, 225 };//Declare array by defining variable type and then using square brackets. 

        //for (int k = 0; k < numberArray.Length; k++)//statement 1: is executed one time before the execution of the code block (K equals value in index 0)
        //    //statement 2: defines condition for executing code block ()
        //    //statement 3: executes every time after the code block has been executed.
        //{
        //    if(numberArray[k]/2 >=150)
        //    {
        //        Console.WriteLine(numberArray[k] + " divided by 2 is greater than or equal to 150.");
        //    }

        //*List

        //List<int> testScores = new List<int>(); //instantiating new list from list class.
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //score is variable and it represents an item in the list

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
  
        
        
    
        
            
        
        
    

