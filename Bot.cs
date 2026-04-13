// added chatbot logic and user interaction
//implemented input validation and default response

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROG_POE
{
    internal class Bot
    {

        private string userName;

        public Bot(string name)
        {
            userName = name;
        }

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nHello, {userName}! Ask me about cybersecurity.\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{userName}: ");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    DefaultResponse();
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe 👋");
                    break;
                }

                Respond(input);
                Thread.Sleep(500);
            }
        }

        private void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            if (input.Contains("how are you"))
                Console.WriteLine("Bot: I'm here to help you stay safe online!");
            else if (input.Contains("purpose"))
                Console.WriteLine("Bot: I educate users about cybersecurity.");
            else if (input.Contains("password"))
                Console.WriteLine("Bot: Use strong passwords with symbols and numbers.");
            else if (input.Contains("phishing"))
                Console.WriteLine("Bot: Be careful of fake emails asking for personal info.");
            else if (input.Contains("safe browsing"))
                Console.WriteLine("Bot: Only visit secure websites (https).");
            else
                DefaultResponse();
        }

        private void DefaultResponse()
        {
            Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
        }
    }
}
added logic and user interaction
implemented input validation and default response
