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

            string name;

            // Change text colour 
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("What is your name?");

            name = Console.ReadLine();

            Console.WriteLine("{0}, you're about to venture into an unknown world, filled with mystery and adventure...", name);

            Console.WriteLine("Please tell me - are you a mage, a rogue, or a swordfighter, or something else entirely?");
            /*
            Console.ReadLine();
            

            if (Console.ReadLine().Equals("mage") || Console.ReadLine().Equals("rogue") || Console.ReadLine().Equals("swordfighter"))

                switch (Console.ReadLine())

                {
                    case "mage":
                        {
                            Console.WriteLine("Mages are wise. You will be able to use spells to aid you in your travels.");
                            Console.WriteLine("You've selected mage as your class.");
                            string charClass = "mage";
                        }
                        break;

                    case "rogue":
                        {
                            Console.WriteLine("Rogues are sneaky. If there's ever an opportunity to get into somewhere you shouldn't be, you'll be able to capitalize on it.");
                            Console.WriteLine("You've selected rogue as your class.");
                            string charClass = "rogue";
                        }
                        break;

                    case "swordfighter":
                        {
                            Console.WriteLine("Swordfighters are strong. During your travels, you may come across interesting ways to use this strength.");
                            Console.WriteLine("You've selected swordfighter as your class.");
                            string charClass = "swordfighter";
                        }
                        break;
                }

            

                
                

                    // need to make a loop, so that if mage, rogue or swordfighter aren't the string inputted, we ask again over and over until one of those 3 options are asked. 




 */
        }
        
        

       

    }
}
