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

            // Keep track of scores
            int userScore = 0;
            int computerScore = 0;

            while (menuIsRunning)
            {




                // Print to console

                //string results = "\nYou chose - " + userInput + "\nThe computer chose - " + optionsList[key];

                
                // Store list of possible options

                List<string> optionsList = new List<string>();
                optionsList.Add("rock");
                optionsList.Add("paper");
                optionsList.Add("scissors");
                optionsList.Add("lizard");
                optionsList.Add("spock");

                while (menuIsRunning)
                {
                   
                    
                    // Menu Method Call
                    Menu();
                    
                    //Prompt user for input
                    string userInput = Console.ReadLine().ToLower();

                    // Create Randomizer
                    Random rnd = new Random();
                    int key = rnd.Next(optionsList.Count());

                    int userChoiceValue = ChoiceValueNums(userInput);
                    int compChoiceValue = ChoiceValueNums(optionsList[key]);

                    // Gather results
                    string results = "\nYou chose - " + userInput + "\nThe computer chose - " + optionsList[key];

                    //Check if input was left blank
                    while (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("Can't leave this part blank. Choose one of the options from the menu.");
                        userInput = Console.ReadLine().ToLower();
                    }

                    if (userInput == "rock")
                    {
                        Console.WriteLine(results);
                    }
                    else if (userInput == "paper")
                    {
                        Console.WriteLine(results);
                    }
                    else if (userInput == "scissors")
                    {
                        Console.WriteLine(results);
                    }
                    else if (userInput == "lizard")
                    {
                        Console.WriteLine(results);
                    }
                    else if (userInput == "spock")
                    {
                        Console.WriteLine(results);
                    }
                    else if (userInput == "rules")
                    {
                        Rules();
                    }
                    else if (userInput == "score")
                    {
                        Console.WriteLine("--------------------");
                        //Scores(userScore, computerScore);
                        // Print Score
                        Console.WriteLine("You : {0} \nComputer : {1}", userScore, computerScore);
                        Console.WriteLine("--------------------");
                        break;
                    }
                    else if (userInput == "exit")
                    {
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
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input. Choose one of the options from the menu.");
                    }

                    // Conditionals
                    if (((compChoiceValue + 1) % 5) == userChoiceValue)
                    {
                        Console.WriteLine("You Win\n");
                        userScore++;
                    }
                    else if (((compChoiceValue + 2) % 5) == userChoiceValue)
                    {
                        Console.WriteLine("You Win\n");
                        userScore++;
                    }
                    else if (compChoiceValue == userChoiceValue)
                    {
                        Console.WriteLine("It's a draw \nNo points given\n");
                    }
                    else if (((compChoiceValue + 1) % 5) != userChoiceValue)
                    {
                        Console.WriteLine("You Lose\n");
                        computerScore++;
                    }
                    else if (((compChoiceValue + 2) % 5) != userChoiceValue)
                    {
                        Console.WriteLine("You Lose\n");
                        computerScore++;
                    }
                }
            }
        }

        // METHODS --------------------------------------------------
        // Method returns string menu
        public static void Menu()
        {
            string menu = 
                "Which do you choose: \n" +
                "Rock \n" +
                "Paper \n" +
                "Scissors \n" +
                "Lizard \n" +
                "Spock \n-------------------------\n";

            Console.WriteLine(menu);
        }

        // Method returns string rules
        public static void Rules()
        {
            Console.WriteLine("**********Reminder********** \nIf you don't know how to play, type \"rules\" anytime during the game.");
            Console.WriteLine("If you wan't to know the score, type \"score\".\n");

            string rules =
                "Rock > Scissors \n" +
                "Scissors > Paper \n" +
                "Paper > Rock \n" +
                "Rock > Lizard \n" +
                "Lizard > Spock \n" +
                "Spock > Scissors \n" +
                "Scissors > Lizard \n" +
                "Lizard > Paper \n" +
                "Paper > Spock \n" +
                "Spock > Rock \n";
            
            Console.WriteLine(rules);
            
        }

        // Method returns int value foreach possible string choice
        public static int ChoiceValueNums(string choice)
        {
            if (choice == "rock")
            {
                return 0;
            }
            if (choice == "paper")
            {
                return 1;
            }
            if (choice == "scissors")
            {
                return 2;
            }
            if (choice == "lizard")
            {
                return 3;
            }
            if (choice == "spock")
            {
                return 4;
            }
            else
            {
                return -1;
            }
        }
        
        // Method returns scores
        public static string Scores(int uScore, int cScore)
        {
            string scoreboard =
                ("-------------------------" +
                "\nYou : " + uScore +
                "\nComputer : "+ cScore);
            Console.WriteLine(scoreboard);
            return scoreboard;
        }
    }
}
