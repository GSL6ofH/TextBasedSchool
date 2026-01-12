using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedSchool
{
    internal class JustGuess
    {
        public static void Start()
        {
            Console.WriteLine("--- Welkom to the game Justgeuss(creative right....) ---");
            Console.WriteLine("upto what number may I pick? (for example. 100)");
            string maxInput = Console.ReadLine();
            int maxNumber;

            // Controleer of de input een nummer is
            if (!int.TryParse(maxInput, out maxNumber) || maxNumber < 1)
            {
                Console.WriteLine("Invalid input:( the number wil be between 1 and 10.");
                maxNumber = 10;
            }
            Random random = new Random();
            int SecretNumber = random.Next(1, maxNumber + 1);
            int Guess = 0;

            //de hoeveelheid dat je het geprobeerd hebt
            int Tries = 0;

            Console.WriteLine($"\nI chose a number between 1 and {maxNumber}. Good luck!");

            // De loop gaat door totdat het getal geraden is
            while (Guess != SecretNumber)
            {
                Console.Write("Come on give it a shot..: ");
                string GuessInput = Console.ReadLine();

                //controle for number
                if (int.TryParse(GuessInput, out Guess))
                {
                    Tries++; // optellen van pogingen

                    if (Guess< SecretNumber)
                    {
                        Console.WriteLine("Higher! try again.");
                    }
                    else if (Guess > SecretNumber)
                    {
                        Console.WriteLine("Lower! try again.");
                    }
                    else
                    {
                        // 🥉 BRONS: Win bericht
                        Console.WriteLine($"\nCongratsss! you guessed the Number {SecretNumber}.");
                        Console.WriteLine($"Amount of tries: {Tries}");
                    }
                }
                else
                {
                    Console.WriteLine("beware: Enter a valid number!");
                }
            }
        }
    }
}

