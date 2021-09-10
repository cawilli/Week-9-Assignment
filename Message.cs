using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman_Game
{
    public static class Message
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("***Welcome to the Hangman Game.");
            Console.WriteLine("A word will be selected from a list. As the player, you will guess a letter one at a time to get a full word.");
            Console.WriteLine("If you miss six times, you lose. Otherwise you can keep guessing until you win.");
            Console.WriteLine("You will receive hints along the way");
        }
    }
}
