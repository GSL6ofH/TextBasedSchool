using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedSchool
{
    internal class WeatherApp
    {
       public static void Start()
        {
            Console.WriteLine("Welkom bij wat is het weer bij jouw!!");
            Console.WriteLine("Wat voor weer is het? (Zonnig / Regen / Bewolkt)");
            string weer = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Hoeveel graden is het buiten?");
            string tempInput = Console.ReadLine();
            int temperatuur;
            bool isNummer = int.TryParse(tempInput, out temperatuur);

            if (isNummer)
            {
                // Logica voor de tips
                if (weer == "zonnig")
                {
                    if (temperatuur >= 20)
                    {
                        Console.WriteLine($"Het is {temperatuur}°C en zonnig. Je hebt geen jas nodig, dus geniet er maar lekker van ervan!");
                    }
                    else
                    {
                        Console.WriteLine($"Het is {temperatuur}°C. De zon schijnt, maar trek toch een jas aan voor vandaag!");
                    }
                }
                else if (weer == "regen")
                {
                    if (temperatuur < 10)
                    {
                        Console.WriteLine("Koud en nat! Trek een dikke regenjas aan.");
                    }
                    else
                    {
                        Console.WriteLine("Het regent, maar een lichte regenjas is voldoende.");
                    }
                }
                else if (weer == "bewolkt")
                {
                    if (temperatuur > 15)
                    {
                        Console.WriteLine("Grijs maar zacht. Een trui is genoeg.");
                    }
                    else
                    {
                        Console.WriteLine("Bewolkt en fris. Kleed je warm aan.");
                    }
                }
                else
                {
                    Console.WriteLine("Dat weertype ken ik niet, maar maak er een mooie dag van!");
                }
            }
            else
            {
                Console.WriteLine("Fout: Dat is geen geldig getal voor de temperatuur.");
            }
        }
    }
}
