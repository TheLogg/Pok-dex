using System;
using System.Collections.Generic;

namespace Pokédex
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu("option1", "option2", "option3");

            PokéDex myPokédex = new PokéDex();

            Console.WriteLine("Welcome to the Pokèdex. Please press any key to continue...");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();

                mainMenu.DisplayMainMenu();

                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    myPokédex.DisplayByName();
                }
                else if (userInput == "2")
                {
                    myPokédex.DisplayByNumber();
                }
                else if (userInput == "3")
                {
                    myPokédex.DisplayByType();
                }
                else if (userInput == "4")
                {
                    myPokédex.DisplayRandom();
                }
                else
                {
                    Console.WriteLine("\nPlease try again and enter a valid menu option...");

                }
            }
        }    
    }
}
