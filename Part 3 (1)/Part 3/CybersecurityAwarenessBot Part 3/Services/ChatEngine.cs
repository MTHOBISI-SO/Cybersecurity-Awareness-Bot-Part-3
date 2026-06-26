using System.Collections.Generic;

namespace CybersecurityAwarenessBotPart3.Services
{
    public class ChatEngine
    {
        private Dictionary<string, string> responses = new Dictionary<string, string>()
        {
            { "hello", "Hello! Welcome to the Cybersecurity Awareness Bot." },
            { "password", "Use strong passwords with symbols, numbers, and uppercase letters." },
            { "phishing", "Phishing is when scammers trick you into revealing sensitive data." },
            { "malware", "Malware is harmful software designed to damage systems." },
            { "privacy", "Always protect your personal information online." }
        };

        public string GetResponse(string input)
        {
            input = input.ToLower();

            foreach (var response in responses)
            {
                if (input.Contains(response.Key))
                    return response.Value;
            }

            return "I don't understand. Ask me about cybersecurity topics.";
        }
    }
}