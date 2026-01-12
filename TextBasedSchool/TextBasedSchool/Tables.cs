using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedSchool
{
    internal class Tables
    {
        public static void Start()
        {
               //een tot tien 
                Console.WriteLine("--- Brons: Getallen 1 t/m 10 ---");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("\n-------------------------------\n");

                // tafel van 5
                Console.WriteLine("--- Zilver: Tafel van 5 ---");
                int tafel = 5;
                for (int i = 1; i <= 10; i++)
                {
                    int resultaat = i * tafel;
                    Console.WriteLine($"{i} x {tafel} = {resultaat}");
                }
            }
        }
    }
