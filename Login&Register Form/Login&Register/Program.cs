using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrayOfUsers = new string[] { "admin@admindomain.com", "Ad#mi8$s@!" };
            string[] arrayOfUsers1 = new string[] { "stojanche@blabla.com", "qwertyuio1" };
            string[] arrayOfUsers2 = new string[] { "tralala@blabla.com", "asdfghjk12" };


        Start:
            Console.WriteLine("Please Login to our software. If you aren't logged in, please register. (Choose your option: login/register)");
            string loginOrRegister = Console.ReadLine();

            //LOGIN LOGIN LOGIN

            while (loginOrRegister == "login")
            {
                Console.WriteLine("Please enter your username");
                string loginUsername = Console.ReadLine();

                if (loginUsername.StartsWith("1") || (loginUsername.StartsWith("2")) || (loginUsername.StartsWith("3")) || (loginUsername.StartsWith("4")) || (loginUsername.StartsWith("5")) || (loginUsername.StartsWith("6")) || (loginUsername.StartsWith("7")) || (loginUsername.StartsWith("8")) || (loginUsername.StartsWith("9")) || (loginUsername.StartsWith("0")))
                {
                    Console.WriteLine("Username can't start with a number, please try again");
                    Console.ReadLine();
                }
                if (loginUsername.Contains("@") && loginUsername.Contains("."))
                {
                    Console.WriteLine("\n" + "The username you entered is valid");
                    Console.ReadLine();
                }
                string loginUsernameValue = loginUsername.Length.ToString();
                int usernameLength = Convert.ToInt32(loginUsernameValue);
                if (loginUsernameValue.Length > 30)
                {
                    Console.WriteLine("Your username has over 30 characters. Try again");
                    Console.ReadLine();
                }

                Console.WriteLine("Please enter your passowrd");
                string loginPass = Console.ReadLine();

                string loginPassValue = loginPass.Length.ToString(loginPass);
                int loginvalue = Convert.ToInt32(loginPassValue);

                if (loginvalue >= 10)
                {
                    Console.WriteLine("Congratulations, you have successfully registered");
                    Console.ReadLine();
                }
                if (loginvalue < 10)
                {
                    Console.WriteLine("Your password must include at least 10 characters");
                }

                // ADMIN ADMIN ADMIN ADMIN ADMIN ADMIN 
                while (loginUsername == "admin@admindomain.com" && loginPass == "Ad#mi8$s@!")
                {
                    Console.WriteLine("Admin login successful. Please select 1 for showing all users and 2 for deleting all users");
                    string adminAccount = Console.ReadLine();

                    if (adminAccount == "1")
                    {
                        Console.WriteLine("Here are the registered users: " +
                            "\n" + "Username 1:" + arrayOfUsers[0] + "\n" + "Password 1: " + arrayOfUsers[1] +
                            "\n" + "Username 2:" + arrayOfUsers1[0] + "\n" + "Password 2: " + arrayOfUsers1[1] +
                            "\n" + "Username 3:" + arrayOfUsers2[0] + "\n" + "Password 3: " + arrayOfUsers2[1]);
                        Console.ReadLine();
                    }

                    if (adminAccount == "2")
                    {
                        Console.WriteLine("Please provide another existing email");
                        string existingUser = Console.ReadLine();

                        Console.WriteLine("Please provide the user's email");
                        string existingUserPass = Console.ReadLine();

                        if ((existingUser == "stojanche@blabla.com" && existingUserPass == "qwertyuio1") || (existingUser == "tralala@blabla.com" && existingUserPass == "asdfghjk12")) {

                            Array.Clear(arrayOfUsers1, 0, arrayOfUsers1.Length);
                            Array.Clear(arrayOfUsers2, 0, arrayOfUsers2.Length);

                            Console.WriteLine(arrayOfUsers[0]);
                            Console.WriteLine(arrayOfUsers1[0]);
                            Console.WriteLine(arrayOfUsers2[0]);
                            Console.ReadLine();
                        }
                    }

                    // LOGOUT LOGOUT LOGOUT --------------------------> HERE IS A PROBLEM

                    else if (adminAccount == "3")
                    {
                        Console.WriteLine("You have successfully logged out");
                        Console.ReadLine();
                        goto Start;
                    }

                    if ((loginUsername == "stojanche@blabla.com" && loginPass == "qwertyuio") || (loginUsername == "tralala@blabla.com" && loginPass == "asdfghjk"))
                    {
                        Console.WriteLine("Login is successful. Please select 1 if you want to see the other users:");
                        string otherAccountProperties = Console.ReadLine();

                        if (otherAccountProperties == "1")
                        {
                            Console.WriteLine("Here are the registered users: " +
                                "\n" + "Username 1:" + arrayOfUsers[0] + "\n" + "Password 1: " + arrayOfUsers[1] +
                                "\n" + "Username 2:" + arrayOfUsers1[0] + "\n" + "Password 2: " + arrayOfUsers1[1] +
                                "\n" + "Username 3:" + arrayOfUsers2[0] + "\n" + "Password 3: " + arrayOfUsers2[1]);
                            Console.ReadLine();
                        }
                    }
                }

            }

            // REGISTER REGISTER REGISTER REGISTER

            while (loginOrRegister == "register") {
                {
                    Console.WriteLine("Please enter your first name");
                    string registerName = Console.ReadLine();

                    Console.WriteLine("Please enter your last name");
                    string registerLastName = Console.ReadLine();

                    Console.WriteLine("\n" + "Please enter your phone number");
                    string registerPhone = Console.ReadLine();

                    Console.WriteLine("Please enter your email adress");
                    string registerEmail = Console.ReadLine();

                    if (registerEmail.StartsWith("1") || (registerEmail.StartsWith("2")) || (registerEmail.StartsWith("3")) || (registerEmail.StartsWith("4")) || (registerEmail.StartsWith("5")) || (registerEmail.StartsWith("6")) || (registerEmail.StartsWith("7")) || (registerEmail.StartsWith("8")) || (registerEmail.StartsWith("9")) || (registerEmail.StartsWith("0")))
                    {
                        Console.WriteLine("Username can't start with a number, please try again");
                        Console.ReadLine();
                        return;
                    }

                    if (registerEmail.Contains("@") && registerEmail.Contains("."))
                    {
                        Console.WriteLine("\n" + "The email you entered is valid");
                        Console.ReadLine();
                    }

                    string registerEmailValue = registerEmail.Length.ToString();
                    int val = Convert.ToInt32(registerEmailValue);
                    if (registerEmailValue.Length > 30)
                    {
                        Console.WriteLine("Your email has over 30 characters. Try again");
                        Console.ReadLine();
                    }

                    Console.WriteLine("\n" + "Please enter your password (must include a special character)");
                    string registerPass = Console.ReadLine();

                    string registerPassValue = registerPass.Length.ToString(registerPass);
                    int regValue = Convert.ToInt32(registerPassValue);

                    if (regValue >= 10)
                    {
                        Console.WriteLine("Congratulations, you have successfully registered");
                        Console.ReadLine();
                    }

                    else if (regValue <= 10)
                    {
                        Console.WriteLine("Your password must include at least 10 characters");
                        Console.ReadLine();
                    }

                    else if (loginOrRegister != "login" || loginOrRegister != "register")
                {
                    Console.WriteLine("Please enter a valid option");
                    Console.ReadLine();
                 }
        }
    }
}
