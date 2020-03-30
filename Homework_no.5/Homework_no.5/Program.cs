using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_no._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE NUMBER 1 ------>> STRING IN REVERSE

            string str;
            int length = 0;

            Console.WriteLine("Enter the string : ");
            str = Console.ReadLine();

            length = str.Length - 1;
            Console.WriteLine("The characters of the string in reverse are : \n");
            while (length >= 0)
            {
                Console.WriteLine("{0} ", str[length]);
                length--;
            }
            Console.ReadLine();

            //EXERCISE NUMBER 2 ----->>> MAXIMUM CHARACTERS IN STRING

            //int x = 0, myWord = 1;
            //Console.WriteLine("Please enter your word/sentence");
            //string str = Console.ReadLine();
            //while (x <= str.Length - 1)
            //{
            //    if (str[x] == ' ')
            //    {
            //        myWord++;
            //    }
            //    a++;
            //}
            //Console.WriteLine("Number of words in the string = {0} ", myWord);
            //Console.ReadLine();


            //EXERCISE NUMBER 3
            //Console.WriteLine("Enter the sentence to count the most appearing characters");
            //string counterSentence = Console.ReadLine();

            //int[] charCount = new int[256];

            //int sentenceLength = counterSentence.Length;
            //for (int i = 0; i < sentenceLength; i++)
            //{
            //    charCount[counterSentence[i]]++;
            //}
            //int maxCount = -1;
            //char character = ' ';
            //for (int i = 0; i < sentenceLength; i++)
            //{
            //    if (maxCount < charCount[counterSentence[i]])
            //    {
            //        maxCount = charCount[counterSentence[i]];
            //        character = counterSentence[i];
            //    }
            //}
            //Console.WriteLine($"The string is: {counterSentence}");
            //Console.ReadLine();
            //Console.WriteLine($"The highest occurring character in the above string is: {character}");
            //Console.ReadLine();
            //Console.WriteLine($"Number of times this character occurs: {maxCount}");

            // EXERCISE NUMBER 4

            //string str = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";
            //int start = 32;
            //string finalString = str.Split(',')[1];
            //Console.WriteLine(finalString);
            //Console.ReadLine();

            // EXERCISE NUMBER 5 

            //var today = DateTime.Now;

            //int year = today.Year;
            //Console.WriteLine($"Year: {year}");

            //int month = today.Month;
            //Console.WriteLine($"Month: {month}");

            //int day = today.Day;
            //Console.WriteLine($"Day:{day}");

            //int hour = today.Hour;
            //Console.WriteLine($"Hour: {hour}");

            //int minute = today.Minute;
            //Console.WriteLine($"Minute: {minute}");

            //int second = today.Second;
            //Console.WriteLine($"Second: {second}");

            //Console.ReadLine();
        }
    }
}
