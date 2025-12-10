using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace PokeTeamBuilder.Classes
{
    public class Utils
    {
        public enum Types { Fire, Water, Grass }; // Enum for type
        public static string ConvertTypeToString(Types type)
        {
            return type.ToString();
        }

        public static Types ConvertStringToType(string str)
        {
            if(str == "Fire")
            {
                return Types.Fire;
            }
            else if(str == "Water")
            {
                return Types.Water;
            }
            else
            {
                return Types.Grass;
            }
        }

        public static void PrintAllPossibleTypes()
        {
            Console.WriteLine("Kies uit:");
            Console.WriteLine($"1) {ConvertTypeToString(Types.Fire)}");
            Console.WriteLine($"2) {ConvertTypeToString(Types.Water)}");
            Console.WriteLine($"3) {ConvertTypeToString(Types.Grass)}");
        }
    }
}