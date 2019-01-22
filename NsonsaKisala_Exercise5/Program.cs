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
            // Store list of possible options
            List<string> optionsList = new List<string>();
            optionsList.Add("rock");
            optionsList.Add("paper");
            optionsList.Add("scissors");
            optionsList.Add("lizard");
            optionsList.Add("spock");

            // Create Randomizer
            Random rnd = new Random();
            int num = rnd.Next(optionsList.Count());

            // Conditionals

            // Print to console
            Console.Clear();
            Console.WriteLine("You chose - {0} \nThe computer chose - {1}", input, optionsList[num]);
        }
    }
}
