using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06_Task_02
{
    class FirstCourse { 
    public FirstCourse()
    {

    }
    public FirstCourse(string courseName)
    {
        CourseName = courseName;
    }
    public FirstCourse(string courseName, bool yesOrNo)
    {
        CourseName = courseName;
        YesOrNo = yesOrNo;
    }

        public string CourseName;
        public bool YesOrNo;

        public bool isPassed()
        {
            if (YesOrNo == true) {
                Console.WriteLine($"\n It is {YesOrNo}, you have passed {CourseName}");
                return true;
            }

            if (YesOrNo == false)
            {
                Console.WriteLine($"\n It is {YesOrNo}, you have not passed {CourseName}");
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
