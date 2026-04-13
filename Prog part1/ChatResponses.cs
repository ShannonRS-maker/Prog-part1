using System;

namespace CybersecurityBot
{
    static class ChatResponses
    {
        public static void RespondToQuestion(string question)
        {
            if (string.IsNullOrWhiteSpace(question))
            {
                Console.WriteLine("You didn't ask anything. Try asking about passwords, phishing, or malware.");
                return;
            }

            string q = question.Trim().ToLowerInvariant();

            if (q.Contains("how are you"))
            {
                Console.WriteLine("I’m just code, but I’m running smoothly!");
            }
            else if (q.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to teach you about cybersecurity and help you stay safe online.");
            }
            else if (q.Contains("what can i ask"))
            {
                Console.WriteLine("You can ask me about passwords, phishing, malware, or general cybersecurity tips.");
            }
            else if (q.Contains("password"))
            {
                Topics.LearnAboutPasswords();
            }
            else if (q.Contains("phish") || q.Contains("email"))
            {
                Topics.LearnAboutPhishing();
            }
            else if (q.Contains("malware") || q.Contains("virus") || q.Contains("ransom"))
            {
                Topics.LearnAboutMalware();
            }
            else if (q.Contains("mfa") || q.Contains("multi-factor") || q.Contains("two-factor"))
            {
                Console.WriteLine("\n--- Multi-Factor Authentication (MFA) ---");
                Console.WriteLine("- MFA adds an extra verification step (e.g., SMS code, authenticator app, hardware key).");
                Console.WriteLine("- It's one of the most effective ways to protect accounts even if a password is compromised.\n");
            }
            else
            {
                Console.WriteLine("I don’t have a detailed answer for that right now. Try asking about passwords, phishing, malware, or MFA.");
            }
        }
    }
}
