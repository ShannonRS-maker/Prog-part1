using System;

namespace CybersecurityBot
{
    static class Welcome
    {
        public static void DisplayWelcome()
        {
            Console.WriteLine(@"
 _____ _     _ _______ _______  ______  ______
|_____| |     |    |    |______  |_____] |_____]
|     | |_____|    |    |______ |_____] |______
");
            Console.WriteLine("Welcome to ShanBot!");
            Console.WriteLine("This interactive program will help you learn basic cybersecurity topics.");
        }
    }
}