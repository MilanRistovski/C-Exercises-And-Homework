using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {


        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            double answer;
            string operation;

            
            Console.WriteLine("Enter the first number");
            firstNumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            secondNumber = Double.Parse(Console.ReadLine());
            
       
            Console.WriteLine("Select an operation you want to execute");
            operation = Console.ReadLine();


            if ((operation != "/") || (operation != "/") || (operation != "/") || (operation != "/"))
            
            {
                Console.WriteLine("Please Enter A Valid Operation");
                Console.ReadLine();
                return;
            }


             if (operation == "+")
            {
                answer = (firstNumber + secondNumber);
                Console.WriteLine("\n" + answer);
                Console.ReadLine();
            }

            if (operation == "-")
            {
                answer = (firstNumber - secondNumber);
                Console.WriteLine("\n" + answer);
                Console.ReadLine();
            }
            if (operation == "*")
            {
                answer = (firstNumber * secondNumber);
                Console.WriteLine("\n" + answer);
                Console.ReadLine();
            }
            if (operation == "/")
            {
                answer = (firstNumber / secondNumber);
                Console.WriteLine("\n" + answer);
                Console.ReadLine();
            }
            
            Console.WriteLine("\n" + "Press any key to exit...");
            Console.ReadKey();
        }
    }
}
