using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            // EXERCISE 01
            string variable1;
            string variable2;

            variable1 = "Zdravo!";

            variable2 = "Kako Ste Denes?";

            Console.WriteLine(variable1 + variable2);
            Console.ReadLine();

            string variable3;
            string variable4;

            variable3 = "9";
            variable4 = "3";

            Console.WriteLine(variable3 + variable4);
            Console.ReadLine();

            //// EXERCISE 02

            int number1;
            string variable5;

            number1 = 47;
            variable5 = "Kolku godini imate? -";

            Console.WriteLine(variable5 + number1 + ", gospodine");
            Console.ReadLine();

            // EXERCISE 03

            double n, m, result;

            n = 102;
            m = 5;

            result = n / m;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
