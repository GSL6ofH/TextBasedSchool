using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedSchool
{
    internal class GiveMeSomeCharacter
    {
        
        public static void Start()
        {
            // 🥉 BRONS: Maak het eerste object aan
            Character speler1 = new Character("Speler1", 5);

            // 🥈 ZILVER: Maak een tweede object aan
            Character speler2 = new Character("PINO", 12);

            Console.WriteLine("--- STATS ---");
            speler1.ShowStats();
            speler2.ShowStats();
        }
    }

    class Character
    {
        public string Name;
        public int Level;
        public Character(string name, int level)
        {
            Name = name;
            Level = level;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Naam: {Name} | Level: {Level}");
        }
    }
}

