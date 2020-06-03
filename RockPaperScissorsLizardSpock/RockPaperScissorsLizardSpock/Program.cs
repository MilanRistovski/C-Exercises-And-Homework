using System;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputComputer;
            int randomInt;

            int scorePlayer = 0;
            int scoreCPU = 0;
            bool again = true;

            while (again)
            {

                while (scorePlayer < 5 && scoreCPU < 5)
                {

                    Console.WriteLine("Choose your option: Rock, Paper, Scissors, Lizard or Spock");

                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();


                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 5);

                    switch (randomInt)
                    {
                        case 1:
                            inputComputer = "Rock";
                            Console.WriteLine("Computer chose Rock");

                            if (inputPlayer == "Rock" || inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.WriteLine("This is a draw");
                            }

                            else if (inputPlayer == "Paper" || inputPlayer == "PAPER" || inputPlayer == "paper")
                            {
                                Console.WriteLine("Player Wins 1 point");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "Scissors" || inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.WriteLine("Computer Wins 1 point");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "Spock" || inputPlayer == "Spock" || inputPlayer == "spock")
                            {
                                Console.WriteLine("Player wins 1 point");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "Lizard" || inputPlayer == "LIZARD" || inputPlayer == "lizard")
                            {
                                Console.WriteLine("Computer Wins 1 point");
                                scoreCPU++;
                            }

                            break;
                        case 2:
                            inputComputer = "Paper";
                            Console.WriteLine("Computer chose Paper");

                            if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("This is a draw");
                            }

                            else if (inputPlayer == "Scissors" || inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.WriteLine("Player Wins 1 point");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "Rock" || inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.WriteLine("Computer Wins 1 point");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "Lizard" || inputPlayer == "LIZARD" || inputPlayer == "lizard")
                            {
                                Console.WriteLine("Player Wins 1 point");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "Spock" || inputPlayer == "SPOCK" || inputPlayer == "spock")
                            {
                                Console.WriteLine("Computer Wins 1 point");
                                scoreCPU++;
                            }
                            break;

                        case 3:
                            inputComputer = "Scissors";
                            Console.WriteLine("Computer chose Scissors");

                            if (inputPlayer == "Scissors" || inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.WriteLine("This is a draw");
                            }

                            else if (inputPlayer == "Rock" || inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.WriteLine("Player wins 1 point");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "Paper" || inputPlayer == "PAPER" || inputPlayer == "paper")
                            {
                                Console.WriteLine("Computer wins 1 point");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "Spock" || inputPlayer == "SPOCK" || inputPlayer == "spock")
                            {
                                Console.WriteLine("Player wins 1 point");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Lizard" || inputPlayer == "lizard" || inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("Computer wins 1 point");
                                scoreCPU++;
                            }
                            break;

                        case 4:
                            inputComputer = "Spock";
                            Console.WriteLine("Computer chose Spock");

                            if (inputPlayer == "Spock" || inputPlayer == "SPOCK" || inputPlayer == "spock")
                            {
                                Console.WriteLine("This is a draw");

                            }

                            else if (inputPlayer == "Scissors" || inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.WriteLine("Computer wins 1 point");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "Rock" || inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.WriteLine("Computer wins 1 point");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "Paper" || inputPlayer == "PAPER" || inputPlayer == "paper")
                            {
                                Console.WriteLine("Player wins 1 point");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "Lizard" || inputPlayer == "lizard" || inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("Player wins 1 point");
                                scorePlayer++;
                            }
                            break;

                        case 5:
                            inputComputer = "Lizard";
                            Console.WriteLine("Computer chose Lizard");

                            if (inputPlayer == "Lizard" || inputPlayer == "lizard" || inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("This is a draw");
                            }

                            else if (inputPlayer == "Paper" || inputPlayer == "PAPER" || inputPlayer == "paper")
                            {
                                Console.WriteLine("Computer wins 1 point");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "Spock" || inputPlayer == "SPOCK" || inputPlayer == "spock")
                            {
                                Console.WriteLine("Computer wins 1 point");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "Scissors" || inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.WriteLine("Player wins 1 point");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "Rock" || inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.WriteLine("Player wins 1 point");
                                scorePlayer++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry, please try again!");
                            break;
                    }

                    Console.WriteLine("\n\n SCORE: \tPLAYER:\t{0}\tComputer:\t{1}", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 5)
                {
                    Console.WriteLine("Player Wins!");
                }
                else if (scoreCPU == 5)
                {
                    Console.WriteLine("The Computer is superior and won!");
                }
                Console.WriteLine("Play Again?");

                string randomLoop = Console.ReadLine();
                if (randomLoop == "y")
                {
                    again = true;
                }
                else if (randomLoop == "n")
                {
                    again = false;
                }
            }
        }
    }
}
