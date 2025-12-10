using System;
using System.Collections.Generic;
using System.Text;
using PokeTeamBuilder.Classes;

namespace PokeTeamBuilder
{
    internal class Program
    {
        public static string CreateStringQuestion(string question, string fallbackValue = "")
        {
            Console.WriteLine($"Vraag beantwoorden: {question}");
            return Console.ReadLine() ?? fallbackValue ?? "";
        }

        public static int CreateIntegerQuestion(string question, int fallbackValue = 0)
        {
            Console.WriteLine($"Vraag beantwoorden: {question}");
            return Convert.ToInt32(Console.ReadLine() ?? "");
        }

        static void Main()
        {
            Console.WriteLine("== POKEMON ==");

            // 1. Create Trainer
            string name = CreateStringQuestion("Kies een naam voor je trainer: ");

            Trainer trainer = new Trainer();
            trainer.Name = name;
            trainer.ToonWelkom();

            // 2. Create Pokemon objects
            int pokemonCount = 3;

            Pokemon[] pokes = new Pokemon[pokemonCount];

            for (int i = 0; i < pokemonCount; i++)
            {
                Pokemon poke = new Pokemon();

                poke.Name = CreateStringQuestion($"Kies een naam voor je {i+1}e Pokemon!");
                Utils.PrintAllPossibleTypes();
                poke.Type = Utils.ConvertStringToType(CreateStringQuestion($"Kies een type voor je {i+1}e Pokemon (hoofdlettergevoelig)"));
                poke.Level = CreateIntegerQuestion($"Kies een level voor je {i+1}e Pokemon:");
   
                pokes[i] = poke;
            }

            Console.WriteLine("== Overzicht ==");

            // 3. Show overview of all Pokemon objects
            for (int i = 0; i < pokes.Length; i++)
            {
                Pokemon poke = pokes[i];
                poke.Info();
            }

            // 4. Extra: Show sum of all team powers
            int sum = 0;
            for (int i = 0; i < pokes.Length; i++)
            {
                Pokemon poke = pokes[i];
                sum += poke.Kracht();
            }

            Console.WriteLine($"De totale teamkracht bedraagt: {sum}");

        }
    }
}
