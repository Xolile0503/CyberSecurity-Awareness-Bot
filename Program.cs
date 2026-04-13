using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE
{
    internal class Program
    {

        private static void Main()
        {
            AudioPlayer.PlayGreeting();
            UIHelper.ShowLogo();

            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty. Enter your name: ");
                name = Console.ReadLine();
            }

            Console.Clear();
            UIHelper.ShowLogo();

            Bot chatbot = new Bot(name);
            chatbot.Start();
        }
    }
}
    

