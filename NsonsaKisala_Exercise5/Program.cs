using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsonsaKisala_Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to R.P.S.L.S.");
            Console.WriteLine("**********If you don't know how to play, type \"rules\"");
            Console.WriteLine("**********If you wan't to know the score, type \"score\"");
            bool menuIsRunning = true;

            while (menuIsRunning)
            {
                // Menu Method Call
                
                Menu();

                //Prompt user for input
                string userInput = Console.ReadLine().ToLower();

                //Check if input was left blank
                while (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Can't leave this part blank. Choose one of the options from the menu.");
                    userInput = Console.ReadLine().ToLower();
                }

                // Case switch user input
                switch (userInput)
                {
                    case "rock":
                        //rock
                        Matchup(userInput);
                        break;
                    case "paper":
                        //paper
                        Matchup(userInput);
                        break;
                    case "scissors":
                        //scissors
                        Matchup(userInput);
                        break;
                    case "lizard":
                        //lizard
                        Matchup(userInput);
                        break;
                    case "spock":
                        //spock
                        Matchup(userInput);
                        break;
                    case "rules":
                        Rules();
                        break;
                    case "score":
                        
                        break;
                    case "exit":
                        
                        Console.Clear();

                        bool exitMenuIsRunning = true;

                        //Check if user really wants to exit or keep playing
                        Console.WriteLine("Done already? Are you sure? \n");
                        while (exitMenuIsRunning)
                        {
                            
                            Console.Write("Type 'Y' for yes OR 'N' for no: ");

                            string ynInput = Console.ReadLine().ToLower();
                            while (string.IsNullOrWhiteSpace(ynInput))
                            {
                                Console.WriteLine("...Lets try that again \n" +
                                    "'Y' for YES \n" +
                                    "'N' for NO");
                                Console.Write("Which do you choose :");
                                ynInput = Console.ReadLine().ToLower();
                            }
                            switch (ynInput)
                            {
                                case "y":
                                    // exit
                                    menuIsRunning = false;
                                    exitMenuIsRunning = false;
                                    break;
                                case "n":
                                    // keep playing
                                    Console.WriteLine("Awesome!");
                                    exitMenuIsRunning = false;
                                    break;
                                default:
                                    Console.WriteLine("Sorry. Was that a yes or a no?");
                                    break;
                            }
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Not a valid input. Choose one of the options from the menu.");
                        break;
                }
            }
        }
        // Method for the menu
        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Which do you choose: \n" +
                    "Rock \n" +
                    "Paper \n" +
                    "Scissors \n" +
                    "Lizard \n" +
                    "Spock");
            Console.WriteLine("-------------------------");
        }

        // Method for the rules
        public static void Rules()
        {
            Console.WriteLine("" +
                "Rock > Scissors \n" +
                "Scissors > Paper \n" +
                "Paper > Rock \n" +
                "Rock > Lizard \n" +
                "Lizard > Spock \n" +
                "Spock > Scissors \n" +
                "Scissors > Lizard \n" +
                "Lizard > Paper \n" +
                "Paper > Spock \n" +
                "Spock > Rock \n"); 
        }

        public static void Matchup(string input)
        {
            // Keep track of scores
            //int rounds = 0;
            int userScore = 0;
            int computerScore = 0;
            int userTotal = 0;
            //int computerTotal = 0;

            // Store list of possible options
            List<string> optionsList = new List<string>();
            optionsList.Add("rock");
            optionsList.Add("paper");
            optionsList.Add("scissors");
            optionsList.Add("lizard");
            optionsList.Add("spock");

            // Create Randomizer
            Random rnd = new Random();
            int key = rnd.Next(optionsList.Count());

            //bool scenario1 

            // Print to console
            Console.Clear();
            Console.WriteLine("You chose - {0} \nThe computer chose - {1}", input, optionsList[key]);

            // Dictionary of scenarios
            Dictionary<string, string> scenarios = new Dictionary<string, string>();
            scenarios.Add(input, optionsList[0]);

            // Conditionals

            // If Draw
            if (input == optionsList[key])
            {
                Console.WriteLine("Draw \nNo points given");
            }
            // Rock Block --------------------------------------------------------------------------------
            if ((input == "rock") && (optionsList[key] == "paper"  || optionsList[key] == "spock" ))
            {
                Console.WriteLine("You Lose");
                computerScore++;
            }
            if((input == "rock") && (optionsList[key] == "lizard" || optionsList[key] == "scissors"))
            {
                Console.WriteLine("You Win");
                userScore++;
            }
            // Paper Block --------------------------------------------------------------------------------
            if ((input == "paper") && (optionsList[key] == "scissors" || optionsList[key] == "lizard"))
            {
                Console.WriteLine("You Lose");
                computerScore++;
            }
            if ((input == "paper") && (optionsList[key] == "rock" || optionsList[key] == "spock"))
            {
                Console.WriteLine("You Win");
                userScore++;
            }

            // Scissors Block --------------------------------------------------------------------------------
            if ((input == "scissors") && (optionsList[key] == "rock" || optionsList[key] == "spock"))
            {
                Console.WriteLine("You Lose");
                computerScore++;
            }
            if ((input == "scissors") && (optionsList[key] == "paper" || optionsList[key] == "lizard"))
            {
                Console.WriteLine("You Win");
                userScore++;
            }

            //Lizard Block --------------------------------------------------------------------------------
            if ((input == "lizard") && (optionsList[key] == "scissors" || optionsList[key] == "rock"))
            {
                Console.WriteLine("You Lose");
                computerScore++;
            }
            if ((input == "lizard") && (optionsList[key] == "spock" || optionsList[key] == "paper"))
            {
                Console.WriteLine("You Win");
                userScore++;
            }

            //Spock Block --------------------------------------------------------------------------------
            if ((input == "spock") && (optionsList[key] == "lizard" || optionsList[key] == "paper"))
            {
                Console.WriteLine("You Lose");
                computerScore++;
            }
            if ((input == "spock") && (optionsList[key] == "rock" || optionsList[key] == "scissors"))
            {
                Console.WriteLine("You Win");
                userScore++;
            }

            PrintScore(userScore, computerScore);
        }

        public static void PrintScore(int uScore, int cScore)
        {
            int userTotal = uScore++;
            int computerTotal = cScore++;

            Console.WriteLine();
            if (uScore > cScore)
            {
                Console.WriteLine("You're Ahead!!!");
            }
            if (uScore < cScore)
            {
                Console.WriteLine("Uh oh, you're behind :(");
            }
            else
            {
                Console.WriteLine("Don't stop, it's a tied game!");
            }

            Console.WriteLine("You : {0} \nComputer : {1}", userTotal, computerTotal);
        }
    }
}
