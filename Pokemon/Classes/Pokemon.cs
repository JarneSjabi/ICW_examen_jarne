using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTeamBuilder.Classes
{

    public class Pokemon
    {

        // Auto properties
        public string Name { get; set; }
        public Utils.Types Type { get; set; }
        public int Level { get; set; }

        public int Kracht()
        {
            // 1. Determine start values
            int startValue = 0;
            switch (Type)
            {
                case Utils.Types.Fire:
                    startValue = 30;
                    break;
                case Utils.Types.Water:
                    startValue = 25;
                    break;
                case Utils.Types.Grass:
                    startValue = 20;
                    break;
                default:
                    break;
            }

            int totalPower = 0;
            totalPower = startValue + (Level * 2);

            return totalPower;
        }

        public void Info()
        {
            Console.WriteLine($"Naam: {Name}, Type: {Type}, Level: {Level}, Kracht: {Kracht()}");
        }

    }
}
