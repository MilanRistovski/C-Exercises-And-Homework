using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //EXERCISE #1 (a) - from 1 to given number

            int n;
            Console.WriteLine("Number :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            // EXERCISE #1 (b) - from given number to 1
            int m;
            Console.WriteLine("Number :");
            m = Convert.ToInt32(Console.ReadLine());

            for (int i = m; i >= 1; i = i - 1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            #endregion

            #region
            //EXERCISE #2 (a) even numbers from 2 to given numben

            int x;
            //Console.WriteLine("Find out all even numbers from 2 to :");
            x = Convert.ToInt32(Console.ReadLine());


            bool evenNumbersParse = int.TryParse(Console.ReadLine(), out int numbersEven);

            for (int i = 1; i <= numbersEven /* x */; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "");
                }
            }
            Console.ReadLine();


            // EXERCISE #2 (b) all even numbers from given number to 2

            int y;
            Console.WriteLine("Find out all even numbers to 2: ");
            //y = Convert.ToInt32(Console.ReadLine());


            bool parseEvenNumbers = int.TryParse(Console.ReadLine(), out int evenNumbers);
            for (int i = evenNumbers; i >= 2 /* x */; i = i - 1)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "");
                }
            }
            Console.ReadLine();


            //EXERCISE #2 (c) - all odd numbers from 1 to given number


            Console.WriteLine("Find out all odd numbers from 1 to :");

            bool parseOdd = int.TryParse(Console.ReadLine(), out int oddNumbers);
            for (int i = 1; i <= oddNumbers; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + "");
                }
            }
            Console.ReadLine();

            #endregion

            #region


            //EXERCISE #3 - SOLUTION 1

            int newIndex = 0;
            string[] namesArray = new string[100];
            Console.WriteLine("Enter a name:");
            Console.WriteLine("Do you want to enter another name? Y/N");
            while (true)
            {
                string input = Console.ReadLine();

                if (input.Length > 1)
                {
                    namesArray[newIndex] = input;
                    newIndex++;
                }

                if (input == "Y" || input == "y")
                {
                    continue;
                }
                else if (input == "N" || input == "n")
                {
                    foreach (var name in namesArray)
                    {
                        Console.WriteLine(name);
                    }
                }
            }

            //EXERCISE #3 - SOLUTION 2

            string[] names = new string[10];
            bool moreNames;
            int arrayCount = -1;
            int xy = 0;
            char doAgain;

            do
            {
                arrayCount++;
                Console.WriteLine("Please enter a name to add onto the array");
                names[arrayCount] = Console.ReadLine();

                Console.WriteLine("Do you want to add another name? (y/n)");
                doAgain = Convert.ToChar(Console.ReadLine());

                if ((doAgain == 'y') || (doAgain == 'Y'))
                {
                    moreNames = true;
                }
                else
                {
                    moreNames = false;
                }
            } while (moreNames == true);

            while (xy <= names.GetLength(0))
            {
                for (int i = 0; xy < names.GetLength(0) - 1; xy++)
                {
                    Console.WriteLine(names[xy]);
                }
            }
            #endregion
        }
    }
}

