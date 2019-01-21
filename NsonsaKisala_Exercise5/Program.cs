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
                    case "paper":
                        //paper
                        break;
                    case "rock":
                        //rock
                        break;
                    case "scissors":
                        //scissors
                        break;
                    case "lizard":
                        //lizard
                        break;
                    case "spock":
                        //spock
                        break;
                    case "exit":
                        //exit
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

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Which do you choose: \n" +
                    "Paper \n" +
                    "Rock \n" +
                    "Scissors \n" +
                    "Lizard \n" +
                    "Spock");
            Console.WriteLine("-------------------------");
        }
    }
}
