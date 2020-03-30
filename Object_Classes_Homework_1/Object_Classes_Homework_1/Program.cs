using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Classes_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();

            //Console.WriteLine("Please enter your name");
            //person.firstName = Console.ReadLine();

            //Console.WriteLine("Please enter your surname");
            //person.lastName = Console.ReadLine();

            //Console.WriteLine("Specify your Age:");
            //person.Age = Convert.ToInt32(Console.ReadLine());

            //person.getPersonStats();
            //Console.ReadLine();


            Dog myDog = new Dog();

            Console.WriteLine("Please enter the dog's name");
            myDog.Name = Console.ReadLine();

            Console.WriteLine("Please specify the dog's race");
            myDog.Race = Console.ReadLine();

            Console.WriteLine("Please specify the dog's color");
            myDog.Color = Console.ReadLine();

            Console.WriteLine("Please tell us what the dog is doing currently:");
            string dogActivity = Console.ReadLine();


            Console.WriteLine($"The name is {myDog.Name}. This is a {myDog.Race}, and is {myDog.Color} by color.");
            Console.ReadLine();

            if (dogActivity == "eating")
            {
                myDog.Eat();
            }

            if (dogActivity == "playing")
            {
                myDog.Play();
            }

            if(dogActivity == "chase tail")
            {
                myDog.ChasingTail();
            }
            Console.ReadLine();
        }
    }
}

