using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTeamBuilder.Classes
{
    public class Trainer
    {
        public string Name { get; set; }

        public void ToonWelkom()
        {
            Console.WriteLine($"Trainer {Name} is klaar voor het avontuur.");
        }

    }
}
