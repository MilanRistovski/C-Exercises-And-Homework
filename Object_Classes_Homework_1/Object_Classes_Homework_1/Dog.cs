using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Classes_Homework_1
{
    class Dog
    {
        public string Name;
        public string Race;
        public string Color;

        public void Eat()
        {
            Console.WriteLine("The dog is now eating");
        }

        public void Play()
        {
            Console.WriteLine("The dog is now playing");
        }

        public void ChasingTail()
        {
            Console.WriteLine("The dog is chasing its tail");
        }
    }
}

