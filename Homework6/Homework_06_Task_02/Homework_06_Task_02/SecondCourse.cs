using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06_Task_02
{
    class SecondCourse
    {

        public SecondCourse()
        {

        }
        public SecondCourse(string courseName, int grade)
        {
            CourseName = courseName;
            Grade = grade;
        }

        public string CourseName;
        public int Grade;

        public int i = 0;
        
        public bool isPassed()
        {
            if (Grade > 5 && Grade <= 10)
            {
               Console.WriteLine($"You have passed {CourseName} with {Grade}");
                return true;
            }

            if (Grade == 5)
            {
                Console.WriteLine("You have FAILED!");
                return false;
            }

            if (Grade < 5 || Grade > 10)
            {
                Console.WriteLine("Please enter a valid grade");
                return false;
            }

            else
            {
                return false;
            }
        }
    }
}

