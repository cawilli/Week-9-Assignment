using System;

namespace Hangman_Game
{
    class Program
    {        
        static void Main(string[] args)
        {
            Message.WelcomeMessage();
            HangMan play = new HangMan();
            play.StartGame();
        }
    }
}
