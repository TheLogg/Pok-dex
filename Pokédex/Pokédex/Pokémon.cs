using System;
using System.Collections.Generic;
using System.Text;

namespace Pokédex
{
    public class Pokémon
    {
        public string Name { get; }

        public int Number { get; }

        public string Type { get; }

        public string Lore { get; }

        public Pokémon(int number, string name, string type, string lore)
        {
            Name = name;
            Number = number;
            Type = type;
            Lore = lore;
        }
    }
}
