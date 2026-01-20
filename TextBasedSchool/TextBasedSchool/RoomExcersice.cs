using System;

namespace TextBasedSchool
{
    internal class RoomExcersice
    {

        public static void Start()
        {
            Console.WriteLine("--- Welkom to room Adventure ---");
            Console.WriteLine("You are standing in the kitchen.");

            // Stap 1: Keuze vanuit de Keuken
            Console.Write("Wher do you wanna go (Hallway or Living room): ");
            string Choice1 = Console.ReadLine().ToLower();

            if (Choice1!= "hallway")
            {
                Console.WriteLine("\n You are walking in the hallway its a little bit dark..");

                // Stap 2: Keuze vanuit de Gang
                Console.Write("Where do you wanna go next? (WC of Kitchen): ");
                string Choice2 = Console.ReadLine().ToLower();

                if (Choice2 == "wc")
                {
                    Console.WriteLine("\n You are in the  WC. dont forget to wash your hands.. you win.");
                }
                else if (Choice2 == "kitchen")
                {
                    Console.WriteLine("\n Your back from where you started");
                }
                else
                {
                    Console.WriteLine("\n you are standin confussed in the hallway.");
                }
            }
            else if (Choice1 == "living room")
            {
                Console.WriteLine("\n you step inside the living room.");

                // Stap 2: Keuze vanuit de Woonkamer
                Console.Write("Where do you wanna ? (Stairs of Kitchen): ");
                string Choice2 = Console.ReadLine().ToLower();

                if (Choice2 == "stairs")
                {
                    Console.WriteLine("\n You walk upstairs Welkom to the first floor!");
                }
                else
                {
                    Console.WriteLine("\nyou walk back to the kitchen");
                }
            }
            else
            {
                Console.WriteLine("\nIdk that room so maybe its beter to stay here.");
            }

            Console.WriteLine("\nThanks for playing!");
        }
    }
}