using System;
using System.Media;
using System.Media;


namespace PROG_POE
{
    internal class AudioPlayer
    {
     
        public static void PlayGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav.wav");

                SoundPlayer player = new SoundPlayer("greeting.wav.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Voice greeting failed.");
            }
        }
    }
}

