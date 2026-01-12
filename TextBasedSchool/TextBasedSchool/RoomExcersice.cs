using System;

namespace TextBasedSchool
{
    internal class RoomExcersice
    {
        public static void Start()
        {
            Console.WriteLine("Welcome to Clean with ehm you!");
            string playerName;


            while (true)
            {
                Console.WriteLine("What is your name???");
                playerName = Console.ReadLine().Trim();

                bool hasNumber = false;

                foreach (char c in playerName)
                {
                    if (char.IsDigit(c))
                    {
                        hasNumber = true;
                        break;
                    }
                }

                if (playerName.Length == 0)
                {
                    Console.WriteLine("Come on just make one up....\n");
                }
                else if (hasNumber)
                {
                    Console.WriteLine("You are not the child of Elon Musk so no Numbers\n");
                }
                else
                {
                    playerName = char.ToUpper(playerName[0]) + playerName.Substring(1);
                    break; //bij een naam die de regels voldoet dan word ie blij😂
                }
            }

            Console.Clear();

            Console.Clear();
            Console.WriteLine($"Hello {playerName} your goal is to  clean your house pretty normal huh.");
            Console.WriteLine("Because this is a textbased adventure you need to type your name and all the other things");
            Console.WriteLine("This is also the reason why you need to type clean to clean..");
            Console.WriteLine("If this game is to hard for you somehow you can quit by writing stop");
            Console.WriteLine("So if its clear and I really hope it is press ENTER");
            Console.ReadLine();
            Console.Clear();


            bool[] cleanedRooms = { false, false, false, false, false };
            string[] roomNames =
            {
                "livingroom",
                "hallway",
                "bedroom",
                "kitchen",
                "garage"
            };
            string[] roomDescriptions =
            {
                "You are in the Living Room there is a big sofa in the middel of the living room",
                "You are in the Hallway as you look around you see a plant",
                "You are in the Bedroom the blanket is on the ground",
                "You are in the Kitchen. in the kitchen the sink is full of nasty dishes",
                "You are in the Garage you notice oil on the ground"
            };

            // Verbindingen per kamer
            int[,] RoomInCode=
            {
                // living room
                { 1, -1, -1, -1 },
                // hallway
                { 0,  2, 3, -1 },
                //bedroom
                {1,-1,-1,-1 },
                // kitchen
                { 1,  4, -1, -1 },
                // garage
                { 3, -1, -1, -1 }
            };

            int currentRoom = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(roomDescriptions[currentRoom]);
                if (!cleanedRooms[currentRoom])
                    Console.WriteLine("This room is a mess");
                else
                    Console.WriteLine("This room is clean");

                    Console.Write("You can go to: ");
                for (int i = 0; i < RoomInCode.GetLength(1); i++)
                {
                    int room = RoomInCode[currentRoom, i];
                    if (room != -1)
                        Console.Write(roomNames[room] + " ");
                }

                Console.WriteLine();
                Console.Write("Where do you want to go? ");

                string input = Console.ReadLine().ToLower();

                if (input == "stop")
                    break;
                if(input == "clean")
                {
                    if (!cleanedRooms[currentRoom])
                    {
                        cleanedRooms[currentRoom] = true;
                        Console.WriteLine("You cleaned this room noice");
                    }
                    else
                    {
                        Console.WriteLine("This room is a mess you should clean it");
                    }
                    continue;
                }

                int targetRoom = -1;

                // Zoek kamernaam
                for (int i = 0; i < roomNames.Length; i++)
                {
                    if (roomNames[i] == input)
                    {
                        targetRoom = i;
                        break;
                    }
                }
                if (targetRoom == -1)
                {
                    Console.WriteLine("That room does not exist.");
                    continue;
                }
                bool canGo = false;
                for (int i = 0; i < RoomInCode.GetLength(1); i++)
                {
                    if (RoomInCode[currentRoom, i] == targetRoom)
                    {
                        canGo = true;
                        break;
                    }
                }
                if (canGo)
                {
                    currentRoom = targetRoom;
                }
                else
                {
                    Console.WriteLine("You can't go there from here.");
                }
                bool allClean = true;

                for(int i = 0; i <cleanedRooms.Length; i++)
                {
                    if (!cleanedRooms[i])
                    {
                        allClean = false;
                        break;
                    }
                }
                if (allClean)
                {
                    Console.WriteLine("You cleaned al the rooms congrats you win");
                    break;
                }
            }
        }
    }
}
