using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Classes_Homework_1
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int Age;

        public void getPersonStats()
        {
            Console.WriteLine($"The name of the person is {firstName} {lastName}. He's {Age} years old");
        }
    }
}
