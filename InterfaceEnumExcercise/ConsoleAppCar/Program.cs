using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCar
{

    interface IAnimal
    {

        void animalSound();

        void sleep();
        
    }

    class Pig : IAnimal
    {
        public string name = "piggy wiggy";
        public void animalSound()
        {
            Console.WriteLine("The pig says wee wee");
        }

        public void sleep()
        {
            Console.WriteLine("pig says zzzzzz");
        }
    }

    class Dog : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says bow bow");
        }

        public void sleep()
        {
            Console.WriteLine("dog says zzzzzz");
        }
    }

    enum Level
    {
        Low,Medium,High
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Pig pig1 = new Pig();
            Console.WriteLine(pig1.name);
            pig1.animalSound();
            pig1.sleep();
            Dog dog1 = new Dog();
            dog1.animalSound();
            dog1.sleep();

            Level myVar = Level.Medium;
            Console.WriteLine(myVar);





            Console.ReadKey();

        }
    }
   
        
        
        
}






