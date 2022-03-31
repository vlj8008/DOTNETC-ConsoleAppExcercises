using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ///Concatenating strings:
             
            string str1 = "Hello";
            string str2 = "Mr/Mrs";
            string str3 = "Smith";

            Console.WriteLine(str1 + " " + str2 + " " + str3);

            //Using Uppercase method: 

            Console.WriteLine("What state are you from");
            string sta = Console.ReadLine();
            string upperSta = sta.ToUpper();
            Console.WriteLine("You are from " + upperSta);

            //Create string builder and build a paragraph of text one sentence at a time. 

            StringBuilder sb = new StringBuilder("It is a lovely day today." ); //creating instance of class StringBuilder
            sb.Append("The sun is shining." );
            sb.Append("The birds are chirping." );
            sb.Append("The squirrels are playing. " );
            sb.Append("And all is well. " );


            Console.WriteLine(sb);


            //Using escape sequence:

            string name = "Vicky";
            string quote = "The man said, \"Hello, who are you? \"" ; //using escape sequence
            Console.WriteLine("Please enter your name here: \n");
            Console.WriteLine(quote);
            Console.WriteLine(name);
            Console.WriteLine("\t Hello on a tab");
            Console.WriteLine("The backslash or \\, is very useful"); //escape sequence for backslash.
            string fileName = "C:\\Users\\Vicky\\cat.jpeg";//another example of escape sequence for backslash.
            string newFilePath = @"C:\Users\Vicky\horse.jpeg";//the 'at' symbol means everything in quotation marks is part of string. 
            Console.WriteLine(fileName);
            Console.WriteLine(newFilePath);
            

            //Using strings with functions:

            bool trueOrFalse = fileName.Contains("s");//output "True"
            trueOrFalse = fileName.EndsWith("s");//re-assigning variable, now output "False"
            Console.WriteLine(trueOrFalse);

            int length = fileName.Length; //fileName.Length is property of fileName
            Console.WriteLine(length);
            fileName = fileName.ToUpper();//example of use is when user inputs a state eg TX.
            Console.WriteLine(fileName);
            

            //STRING IS IMMUTABLE OBJECT (ONCE CREATED CAN'T CHANGE THEM. IT IS ALLOCATED TO MEMORY.
            //WHEN YOU CHANGE THAT STRING A NEW STRING IS CREATED AND ALLOCATED TO MEMORY.
            //Becomes noticeable when changing the string ALOT. Stringbuilder object is solution.

            string pet = "dog";//has a memory allocation
            pet = "horse";//has ANOTHER memory allocation
            Console.WriteLine(pet);


            Console.ReadLine();
        }
    }
}
