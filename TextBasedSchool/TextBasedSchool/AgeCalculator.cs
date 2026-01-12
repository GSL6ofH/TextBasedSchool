using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextBasedSchool
{
    internal class AgeCalculator
    {
        public static void Start()
            {
                Console.WriteLine("--- Leeftijd & Stemrecht Controle ---");
                Console.WriteLine("Voer je geboortedatum in (dd-mm-jjjj):");
                string input = Console.ReadLine();

                DateTime geboortedatum;
            //checkt of de datum die is ingeboerd geldig is
                if (DateTime.TryParse(input, out geboortedatum))
                {
                // weet bereken niet meer in het engels
                    int leeftijd = BerekenAge(geboortedatum);
                    Console.WriteLine($"\nJe bent {leeftijd} jaar oud.(dat je het zolang al gered hebt...)");
                    bool magStemmen = Is18Plus(leeftijd);

                    if (magStemmen)
                    {
                        Console.WriteLine("Je bent 18+ en mag dus stemmen (mag wel moet niet)");
                       
                        FunOutPut(leeftijd);
                    }
                    else
                    {
                        Console.WriteLine("Je mag helaas nog niet stemmen ach of jouw stem het verschil maakt");
                    }
                }
                else
                {
                    Console.WriteLine("Dat is geen geldige datum. Gebruik het formaat dd-mm-jjjj.");
                }
            }

            static int BerekenAge(DateTime geboorte)
            {
                DateTime vandaag = DateTime.Today;
                int leeftijd = vandaag.Year - geboorte.Year;

            // kijkt of de verjaardag al geweest is dit jaar
                if (geboorte.Date > vandaag.AddYears(-leeftijd))
                {
                    leeftijd--;
                }

                return leeftijd;
            }
            static bool Is18Plus(int leeftijd)
            {
                return leeftijd >= 18;
            }

        static void FunOutPut (int leeftijd)
            {
                
                if (leeftijd >= 18 && leeftijd < 30)
                {
                    Console.WriteLine("Categorie: Jongvolwassene. Geniet van je studententijd of eerste baan!(of blijf thuis en rot langzaam weg in je kamer)");
                }
                else if (leeftijd >= 30 && leeftijd < 50)
                {
                    Console.WriteLine("Categorie: De bloei van je leven.  tussen de 30 en de 49 is het nieuwe twintig!(maar dan met meer knie pijn..)");
                }
                else if (leeftijd >= 50)
                {
                    Console.WriteLine("Categorie: Ervaren expert. Je bent als een goede wijn, je wordt beter met de jaren... en dan open je hem verkeerd en zit er kurk in je glas");
                }
            }
        }
    }
    

