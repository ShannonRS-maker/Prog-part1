using System;

namespace CybersecurityBot
{
    static class Topics
    {
        public static void LearnAboutPasswords()
        {
            Console.WriteLine("\n--- Passwords ---");
            Console.WriteLine("- Use long passphrases (12+ characters) combining words, numbers, and symbols.");
            Console.WriteLine("- Avoid reusing passwords across sites.");
            Console.WriteLine("- Use a reputable password manager to generate and store unique passwords.");
            Console.WriteLine("- Enable multi-factor authentication (MFA) where available.\n");
        }

        public static void LearnAboutPhishing()
        {
            Console.WriteLine("\n--- Phishing ---");
            Console.WriteLine("- Phishing is an attempt to trick you into giving sensitive info (passwords, credit cards).");
            Console.WriteLine("- Check sender addresses, hover over links to see targets, and be suspicious of urgent requests.");
            Console.WriteLine("- Never enter credentials on a site reached via an unexpected link; type the site URL yourself.");
            Console.WriteLine("- Report suspicious messages to your IT/security team.\n");
        }

        public static void LearnAboutMalware()
        {
            Console.WriteLine("\n--- Malware ---");
            Console.WriteLine("- Malware is software designed to harm or exploit devices and data.");
            Console.WriteLine("- Keep your OS and software up to date, and run a reputable antivirus/endpoint solution.");
            Console.WriteLine("- Do not run unknown attachments or installers, and avoid pirated software.");
            Console.WriteLine("- Regularly back up important data and verify backups.\n");
        }
    }
}