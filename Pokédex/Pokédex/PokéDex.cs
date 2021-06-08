using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Pokédex
{
    class PokéDex
    {
        public Dictionary<int, Pokémon> PokéDictionary { get; } = new Dictionary<int, Pokémon>();

        public PokéDex()
        {
            SplitByLine();
        }

        public void SplitByLine()
        {
            StreamReader sr = new StreamReader("PokeData.txt");

            string line;
            // Read and display lines from the file until the end of
            // the file is reached.
            while ((line = sr.ReadLine()) != null)
            {
                SplitAndAdd(line);
            }
        }
        public void SplitAndAdd(string entry)
        {
            string[] entryArray = entry.Split("__");
            string[] informationArray = entryArray[1].Split("_");
            int dexNum = Int32.Parse(entryArray[0]);
            PokéDictionary.Add((dexNum), new Pokémon(dexNum, informationArray[0], informationArray[1], informationArray[2]));
        }

        public void DisplayByName()
        {
            Console.Clear();

            Console.WriteLine("Please Enter the desired Pokèmon's name.");

            string userInput = Console.ReadLine();

            foreach (KeyValuePair<int, Pokémon> pokèmon in PokéDictionary)
            {
                if (userInput.ToLower() == pokèmon.Value.Name.ToLower())
                {
                    Console.Clear();
                    Console.WriteLine($"Entry #{pokèmon.Key}) {pokèmon.Value.Name} \n{pokèmon.Value.Name} is a {pokèmon.Value.Type}-type Pokèmon." +
                        $" Here is an interesting fact! \n\n{pokèmon.Value.Lore}");
                }
            }

        }

        public void DisplayByNumber()
        {
            Console.Clear();

            Console.WriteLine("Please Enter the desired Pokèmon's correlating Pokèdex number. (1-151)");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 1 && userInput <= 151)
            {
                foreach (KeyValuePair<int, Pokémon> pokèmon in PokéDictionary)
                {
                    if (userInput == pokèmon.Key)
                    {
                        Console.Clear();
                        Console.WriteLine($"Entry #{pokèmon.Key}) {pokèmon.Value.Name} \n{pokèmon.Value.Name} is a {pokèmon.Value.Type}-type Pokèmon." +
                            $" Here is an interesting fact! \n\n{pokèmon.Value.Lore}");
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid Pokèdex number.");
            }
        }

        public void DisplayByType()
        {
            Console.Clear();

            Console.WriteLine("Please Enter the desired Pokèmon's Type. All Pokèmeon of the desired type will then be displayed sequentially.");

            string userInput = Console.ReadLine();

            foreach (KeyValuePair<int, Pokémon> pokèmon in PokéDictionary)
            {
                if (pokèmon.Value.Type.ToLower().Contains(userInput.ToLower()))
                {
                    Console.Clear();
                    Console.WriteLine($"Entry #{pokèmon.Key}) {pokèmon.Value.Name} \n{pokèmon.Value.Name} is a {pokèmon.Value.Type}-type Pokèmon." +
                            $" Here is an interesting fact! \n\n{pokèmon.Value.Lore}\n");

                    Console.WriteLine("ENTER for next entry...");
                    Console.ReadLine();
                }
            }
        }

        public void DisplayRandom()
        {

            Random random = new Random();

            Console.WriteLine("\nENTER to generate a new random Pokèmon or any other key to exit.");

            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {    
                Console.Clear();

                Console.WriteLine("Here is your random Pokèmon!\n");

                for (int i = 0; i < 1; ++i)
                {
                    int index = random.Next(PokéDictionary.Count);

                    int key = PokéDictionary.Keys.ElementAt(index);
                    Pokémon value = PokéDictionary.Values.ElementAt(index);

                    Console.WriteLine($"Entry #{key}) {value.Name} \n{value.Name} is a {value.Type}-type Pokèmon." +
                                $" Here is an interesting fact! \n\n{value.Lore}\n");

                    Console.WriteLine("\nENTER to generate a new random Pokèmon or any other key to exit.");
                }
            }
        }
    }
}
