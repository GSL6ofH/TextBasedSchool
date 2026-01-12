using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedSchool
{
    internal class Gambling
    {
        public static void Start()
        {
            // Maak een generator aan voor willekeurige getallen
            Random dice = new Random();

            // Genereer een getal tussen 1 en 6
            // de zeven telt niet mee, dus hij kiest 1 tm 6
            int worp = dice.Next(1, 7);

            Console.WriteLine("--- Gambling Simulator (dice)---");
            Console.WriteLine($"You threw a {worp}!");
        }
    }
}
