using System;

namespace CybersecurityBot
{
    static class Welcome
    {
        public static void DisplayWelcome()
        {
            Console.WriteLine(@"
    _____ _ _           
   / ____| | | | |          
  | | __ __ _ _ __ ___ | |__ __ _ ___ ___ | | __ _ ___ 
  | | |_ |/ _` | '_ ` _ \ | '_ \ / _` / __/ _ \| |/ _` / __|
  | |__| | (_| | | | | | || | | | (_| | (_| (_) | | (_| \__ \
   \_____| \__,_|_| |_| |_|_| |_|\__,_|\___\___/|_|\__,_|___/
");
            Console.WriteLine("Welcome to Shanbot!\n");
            Console.WriteLine("This interactive program will help you learn basic cybersecurity topics.");
        }
    }
}
