using System;

namespace Testbed_1
{
    class ProjectLittleRPG
    {
        static void Main(string[] args)
        {
            // vars
            string appName = "Project Little RPG";
            string appVersion = "0.0.2";
            string appAuthor = "Curch7";

            string charClass;

            // Change text colour 
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("{0}, you're about to venture into an unknown world, filled with mystery and adventure...", name);
            string charClass = GetClass(name);

            if (charClass == "mage" || charClass == "rogue" || charClass == "swordfighter")

            {
                switch (charClass)
                {

                    case "mage":
                        Console.WriteLine("Mages are wise.");
                        Console.WriteLine("You've selected {0} as your class", charClass);
                        break;

                    case "rogue":
                        Console.WriteLine("Rogues are sneaky.");
                        Console.WriteLine("You've selected {0} as your class", charClass);
                        break;

                    case "swordfighter":
                        Console.WriteLine("Swordfighters are brave.");
                        Console.WriteLine("You've selected {0} as your class", charClass);
                        break;
                }
            }

            else while (charClass != "mage" || charClass != "rogue" || charClass != "swordfighter")

                GetClass(name);

             
                 
        }
        
        

        private static string GetClass(string name)
        {
            Console.WriteLine("Please tell me {0} - are you a masterful mage, a reticent rogue, or a soulful swordfighter?", name);

            string charClass = Console.ReadLine();
            return charClass;
        }


        //  working on making charClass only apply if the user input is ""mage" , "rogue", or "swordfighter"

    }
}
