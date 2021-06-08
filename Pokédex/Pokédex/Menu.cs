using System;
using System.Collections.Generic;
using System.Text;

namespace Pokédex
{
    class Menu
    {
        public string Option1 { get; private set; }

        public string Option2 { get; private set; }

        public string Option3 { get; private set; }

        public Menu(string option1, string option2, string option3)
        {
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
        }

        public void DisplayMainMenu()
        {
            Console.WriteLine("Please chooose from the following options: \n1 ) Enter the desired Pokèmon's name \n2 ) Enter the desired Pokèmon's dex number (1-151) " +
                "\n3 ) Enter a type and all Pokèmon of the given type will be displayed sequentially. \n4 ) Display a random entry \n5 ) Press ENTER then ESC to exit application. ");
        }





    }
}
