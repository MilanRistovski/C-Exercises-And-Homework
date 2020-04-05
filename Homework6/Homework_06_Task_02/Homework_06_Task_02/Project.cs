using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06_Task_02
{
    public class Project
    {
            public Project(bool firstCourse, bool secondCourse, bool thirdCourse, bool fourthCourse)
            {
                FirstCourse = firstCourse;
                SecondCourse = secondCourse;
                ThirdCourse = thirdCourse;
                FourthCourse = fourthCourse;
            }

            bool FirstCourse;
            bool SecondCourse;
            bool ThirdCourse;
            bool FourthCourse;

            public void isPassed()
            {
                bool[] arrayOfCourses = { FirstCourse, SecondCourse, ThirdCourse, FourthCourse };
                int totalCourses = 0;

                foreach (var item in arrayOfCourses)
                {
                    if (item == true)
                    {
                    totalCourses++;
                    }
                }
                if (totalCourses >= 3)
                {
                    Console.WriteLine($"\n {totalCourses} courses are passed. The student passed the project! "); ;
                }
                else
                {
                    Console.WriteLine($"\n {totalCourses} courses are passed.You failed to pass the course"); ;
                }
            }
    }

}
