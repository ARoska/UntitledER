using System;

namespace UntitledER
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            PlayGame game = new PlayGame();

            while (play == true)
            {
                play = game.Title();
                Console.Clear();
            }

            Console.WriteLine("Bye!  Thanks for playing!");
            System.Threading.Thread.Sleep(1500);
        }
    }
}
