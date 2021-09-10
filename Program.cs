using System;

namespace Hangman_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var hangMan = new HangMan();
            var options = new WordBank();
            string word = options.GetWord();

            Message.WelcomeMessage();
            char guess = char.Parse(Console.ReadLine());
            Console.WriteLine("Hint: the word has 11 letters.");
        }
    }
}
