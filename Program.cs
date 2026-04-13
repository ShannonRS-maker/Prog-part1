using System;

namespace CybersecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play greeting audio
            AudioManager.PlayGreeting();

            Welcome.DisplayWelcome();

            Console.Write("Please enter your name: ");
            string userName = (Console.ReadLine() ?? "").Trim();

            if (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Name cannot be empty. Defaulting to 'User'.");
                userName = "User";
            }

            Console.WriteLine($"\nHello, {userName}! Let's learn about cybersecurity.");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Learn about Passwords");
                Console.WriteLine("2. Learn about Phishing");
                Console.WriteLine("3. Learn about Malware");
                Console.WriteLine("4. Ask a question");
                Console.WriteLine("5. Exit");

                string choice = (Console.ReadLine() ?? "").Trim();

                if (string.IsNullOrWhiteSpace(choice))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case "1":
                        Topics.LearnAboutPasswords();
                        break;
                    case "2":
                        Topics.LearnAboutPhishing();
                        break;
                    case "3":
                        Topics.LearnAboutMalware();
                        break;
                    case "4":
                        Console.Write("Ask me something: ");
                        string question = (Console.ReadLine() ?? "").Trim();
                        ChatResponses.RespondToQuestion(question);
                        break;
                    case "5":
                        Console.WriteLine("Exiting. Stay safe!");
                        return;
                    default:
                        Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                        break;
                }
            }
        }
    }
}