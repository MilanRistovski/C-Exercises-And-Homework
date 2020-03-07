using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Currency You Want To Change from");
            string currFrom = "";
            currFrom = Console.ReadLine();

            Console.WriteLine("Insert Currency You Want To Change to");
            string tocurr = "";
            tocurr = Console.ReadLine();

            // USD <--> EUR
            if ((currFrom == "USD") || (currFrom == "usd") && (tocurr == "EUR") || (tocurr == "eur"))
            {
                Console.WriteLine("Enter the amount you want to change to EUR");
                double amount, usdtoeur;
                amount = Convert.ToDouble(Console.ReadLine());

                usdtoeur = amount * 0.88;

                Console.WriteLine("The Amount In Euros is:" + usdtoeur + "€");
                Console.ReadLine();
            }

            if ((currFrom == "EUR") || (currFrom == "eur") && (tocurr == "USD") || (tocurr == "usd"))
            {
                Console.WriteLine("Enter the amount you want to change to USD:");
                double amount1, eurtousd;
                amount1 = Convert.ToDouble(Console.ReadLine());

                eurtousd = amount1 * 1.13;

                Console.WriteLine("The Amount In Dollars is:" + eurtousd + "$");
                Console.ReadLine();
            }

            // EUR <--> GBP
            if ((currFrom == "EUR") || (currFrom == "eur") && (tocurr == "GBP") || (tocurr == "gbp"))
            {
                Console.WriteLine("Enter the amount you want to change to GBP:");
                double amount2, eurtogbp;
                amount2 = Convert.ToDouble(Console.ReadLine());

                eurtogbp = amount2 * 0.87;

                Console.WriteLine("The Amount In Dollars is:" + eurtogbp + "£");
                Console.ReadLine();
            }
            if ((currFrom == "GBP") || (currFrom == "gbp") && (tocurr == "EUR") || (tocurr == "eur"))
            {
                Console.WriteLine("Enter the amount you want to change to EUR:");
                double amount3, gbptoeur;
                amount3 = Convert.ToDouble(Console.ReadLine());

                gbptoeur = amount3 * 1.15;

                Console.WriteLine("The Amount In Pounds is:" + gbptoeur + "€");
                Console.ReadLine();
            }

            // GBP <--> USD

            if ((currFrom == "GBP") || (currFrom == "gbp") && (tocurr == "USD") || (tocurr == "usd"))
            {
                Console.WriteLine("Enter the amount you want to change to USD:");
                double amount4, gbptousd;
                amount4 = Convert.ToDouble(Console.ReadLine());

                gbptousd = amount4 * 1.30;

                Console.WriteLine("The Amount In Dollars is:" + gbptousd + "$");
                Console.ReadLine();
            }
            if ((currFrom == "USD") || (currFrom == "usd") && (tocurr == "gbp") || (tocurr == "GBP"))
            {
                Console.WriteLine("Enter the amount you want to change to GBP:");
                double amount5, usdtogbp;
                amount5 = Convert.ToDouble(Console.ReadLine());

                usdtogbp = amount5 * 0.77;

                Console.WriteLine("The Amount In Pounds is:" + usdtogbp + "£");
                Console.ReadLine();
            }

            // USD <--> MKD
            if ((currFrom == "USD") || (currFrom == "usd") && (tocurr == "MKD") || (tocurr == "mkd"))
            {
                Console.WriteLine("Enter the amount you want to change to MKD:");
                double amount6, usdtomkd;
                amount6 = Convert.ToDouble(Console.ReadLine());

                usdtomkd = amount6 * 54.33;

                Console.WriteLine("The Amount In Denars is:" + usdtomkd + "MKD");
                Console.ReadLine();
            }

            if ((currFrom == "MKD") || (currFrom == "mkd") && (tocurr == "USD") || (tocurr == "mkd"))
            {
                Console.WriteLine("Enter the amount you want to change to USD:");
                double amount7, mkdtousd;
                amount7 = Convert.ToDouble(Console.ReadLine());

                mkdtousd = amount7 * 0.018;

                Console.WriteLine("The Amount In Dollars is:" + mkdtousd + "$");
                Console.ReadLine();
            }

            // EUR <--> MKD
            if ((currFrom == "EUR") || (currFrom == "eur") && (tocurr == "MKD") || (tocurr == "mkd"))
            {
                Console.WriteLine("Enter the amount you want to change to MKD:");
                double amount8, eurtomkd;
                amount8 = Convert.ToDouble(Console.ReadLine());

                eurtomkd = amount8 * 61.47;

                Console.WriteLine("The Amount In Denars is:" + eurtomkd + "MKD");
                Console.ReadLine();
            }

            if ((currFrom == "MKD") || (currFrom == "mkd") && (tocurr == "EUR") || (tocurr == "eur"))
            {
                Console.WriteLine("Enter the amount you want to change to EUR:");
                double amount9, mkdtoeur;
                amount9 = Convert.ToDouble(Console.ReadLine());

                mkdtoeur = amount9 * 0.016;

                Console.WriteLine("The Amount In Denars is:" + mkdtoeur + "€");
                Console.ReadLine();
            }

            // GBP <--> MKD
            if ((currFrom == "MKD") || (currFrom == "mkd") && (tocurr == "gbp") || (tocurr == "GBP"))
            {
                Console.WriteLine("Enter the amount you want to change to GBP:");
                double amount10, mkdtogbp;
                amount10 = Convert.ToDouble(Console.ReadLine());

                mkdtogbp = amount10 * 0.014;

                Console.WriteLine("The Amount In Pounds is:" + mkdtogbp + "£");
                Console.ReadLine();
            }
            if ((currFrom == "GBP") || (currFrom == "gbp") && (tocurr == "MKD") || (tocurr == "mkd"))
            {
                Console.WriteLine("Enter the amount you want to change to MKD:");
                double amount11, gbptomkd;
                amount11 = Convert.ToDouble(Console.ReadLine());

                gbptomkd = amount11 * 70.73;

                Console.WriteLine("The Amount In Denars is:" + gbptomkd + "MKD");
                Console.ReadLine();
            }
        }
    }
}
