using System;

namespace Hangman_Game
{
    class Program
    {        
        static void Main(string[] args)
        {
            Message.WelcomeMessage();
            int attempts = 6;
            while (attempts > 0)
            {
                var hangMan = new HangMan();
                var options = new WordBank();
                string word = options.GetWord();
                
                char guess = char.Parse(Console.ReadLine());
                Console.WriteLine();

                foreach (var letter in word)
                {
                    if (guess == letter)
                    {
                        hangMan.PayingWord = guess.ToString();
                    }
                    Console.WriteLine();
                }

            }
            
        }
    }
}
