using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstSubject = new FirstCourse()
            {
                CourseName = "C Sharp",
                YesOrNo = true
            };

            FirstSubject.isPassed();
            Console.ReadLine();

            var FirstSubject1 = new FirstCourse()
            {
                CourseName = "PHP",
                YesOrNo = false
            };

            FirstSubject1.isPassed();
            Console.ReadLine();


            var SecondSubject = new SecondCourse()
            {
                CourseName = "Javascript",
                Grade = 10
            };

            SecondSubject.isPassed();
            Console.ReadLine();

            var SecondSubject1 = new SecondCourse()
            {
                CourseName = "CSS",
                Grade = 6
            };

            SecondSubject1.isPassed();
            Console.ReadLine();


            Console.WriteLine("\nNow, Let us see the results of the project");
            Console.ReadLine();

            var CourseOne1 = new FirstCourse("HTML", true);
            var CourseOne2 = new FirstCourse("CSS", true);

            var CourseTwo1 = new SecondCourse("Javascript", 6);
            var CourseTwo2 = new SecondCourse("C#", 8);

            Project Proekt = new Project(CourseOne1.isPassed(), CourseOne2.isPassed(), CourseTwo1.isPassed(), CourseTwo2.isPassed());
            Proekt.isPassed();

            Console.ReadLine();   
        }
        
    }
}

