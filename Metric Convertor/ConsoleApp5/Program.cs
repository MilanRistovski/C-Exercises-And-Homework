using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the measurement you want to convert from:");
            string measurefrom = "";
            measurefrom = Console.ReadLine();

            Console.WriteLine("Enter the measurement you want to convert to:");
            string measureto = "";
            measureto = Console.ReadLine();


            // cm <--> inches
            if ((measurefrom == "cm") || (measurefrom == "CM") || (measurefrom == "centimeters") && (measureto == "inches") || (measureto == "INCHES") || (measureto == "Inches"))
            {
                double cm, cmtoinch;

                Console.WriteLine("Input the value in CM you want to covnert : ");
                cm = Convert.ToDouble(Console.ReadLine());

                cmtoinch = 0.393701 * cm;

                Console.WriteLine("The value in inches is" + cmtoinch + " inches");
                Console.ReadLine();
            }

            if ((measurefrom == "inches") || (measurefrom == "INCHES") || (measurefrom == "Inches") && (measureto == "centimeters") || (measureto == "CM") || (measureto == "cm"))
            {
                double inches, inchestocm;

                Console.WriteLine("Input the value in inches you want to covnert : ");
                inches = Convert.ToDouble(Console.ReadLine());

                inchestocm = 2.54 * inches;

                Console.WriteLine("The value in centimeters is " + inchestocm + " cm");
                Console.ReadLine();
               }

            // Kilometers per hour <--> Miles per hour
            if ((measurefrom == "kmh") || (measurefrom == "KMH") || (measurefrom == "kilometers per hour") || (measurefrom == "km/h") && (measureto == "mph") || (measureto == "MPH") || (measureto == "miles per hour") || (measureto == "m/h"))
            {
                double kmh, kmhtomph;

                Console.WriteLine("Input the value in km/h you want to covnert : ");
                kmh = Convert.ToDouble(Console.ReadLine());

                kmhtomph = 0.621371 * kmh;

                Console.WriteLine("The value in in mph is" + kmhtomph + " miles per hour");
                Console.ReadLine();
            }

            if ((measurefrom == "mph") || (measurefrom == "MPH") || (measurefrom == "miles per hour") || (measurefrom == "m/h") && (measureto == "kilometers per hour") || (measureto == "kmh") || (measureto == "KMH") || (measureto == "km/h"))
            {
                double mph, mphtokmh;

                Console.WriteLine("Input the value in mph you want to covnert : ");
                mph = Convert.ToDouble(Console.ReadLine());

                mphtokmh = 1.60934 * mph;

                Console.WriteLine("The value in in km/h is" + mphtokmh + " kilometers per hour");
                Console.ReadLine();
            }


            // Fahrenheit <--> celsius
            if ((measurefrom == "F") || (measurefrom == "Fahrenheit") || (measurefrom == "fahrenheit") && (measureto == "C") || (measureto == "Celsius") || (measureto == "celsius"))
            {
                double fahr, fahrtocels;

                Console.WriteLine("Input the value in Fahrenheit you want to covnert : ");
                fahr = Convert.ToDouble(Console.ReadLine());

                fahrtocels = (fahr - 32) * 5 / 9;
                
                Console.WriteLine("The converted temperature is" + fahrtocels + " F");
                Console.ReadLine();
            }

            if ((measurefrom == "C") || (measurefrom == "Celsius") || (measurefrom == "celsius") && (measureto == "F") || (measureto == "Fahrenheit") || (measureto == "fahrenheit"))
            {
                double cels, celstofahr;

                Console.WriteLine("Input the value in Celsius you want to covnert : ");
                cels = Convert.ToDouble(Console.ReadLine());

                celstofahr = (cels * 9 / 5) + 32;

                Console.WriteLine("The converted temperature is" + celstofahr + " C");
                Console.ReadLine();
            }

            // Pounds <--> Kilograms
            if ((measurefrom == "pounds") || (measurefrom == "Pounds") || (measurefrom == "lb") || (measurefrom == "lbs") && (measureto == "kilograms") || (measureto == "kg") || (measureto == "KG"))
            {
                double pounds, poundstokgs;
                Console.WriteLine("Input the value in lbs you want to change to kg: ");
                pounds = Convert.ToDouble(Console.ReadLine());

                poundstokgs = pounds * 0.453592;

                Console.WriteLine("The converted amount is: " + poundstokgs + "kg");
                Console.ReadLine();
            }

            if ((measurefrom == "kilograms") || (measurefrom == "kg") || (measurefrom == "KG") || (measureto == "lbs") && (measureto == "lb") || (measureto == "Pounds") || (measureto == "pounds"))
            {
                double kgs, kilstopounds;
                Console.WriteLine("Input the value in kilograms you want to change to lbs: ");
                kgs = Convert.ToDouble(Console.ReadLine());

                kilstopounds = kgs * 2.20462;

                Console.WriteLine("The converted amount is: " + kilstopounds + "lbs");
                Console.ReadLine();
            }
        }
    }
}
