using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedSchool
{
    internal class WeaponsJippie
    {
        public static void Start()
        {
                Weapon wapen1 = new Weapon("Goude prikker", 10);
                Weapon wapen2 = new Weapon("Shotgun", 25);
                Weapon wapen3 = new Weapon("Katana", 15);

                Console.WriteLine("--- Current Weapins ---");
                wapen1.ShowStats();
                wapen2.ShowStats();
                wapen3.ShowStats();


                Console.WriteLine("\n--- Upgrades are being  processed... ---");
                wapen1.UpgradeItem(5);   
                wapen2.UpgradeItem(10);
                wapen3.UpgradeItem(3);  

                Console.WriteLine("\n--- new stats ---");
                wapen1.ShowStats();
                wapen2.ShowStats();
                wapen3.ShowStats();
            }
        }
        class Weapon
        {
  
            public string Name;
            public int Damage;

           
            public Weapon(string name, int damage)
            {
                Name = name;
                Damage = damage;
            }
            public void ShowStats()
            {
                Console.WriteLine($"{Name} does {Damage} damage.");
            }

            
            public void UpgradeItem(int damageToAdd)
            {
                Damage += damageToAdd; 
                Console.WriteLine($"{Name} weapon is upgraded to +{damageToAdd} damage!");
            }
        }
    }
    

