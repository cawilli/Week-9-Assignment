using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman_Game
{
    public class HangMan
    {
        //setting the initial variables for game 
        //player will only get 6 attempts to play game
        public bool[] letterSelected;
        public string PlayingWord;
        char letter;
        public char Guess { get; set; }
        public string Misses { get; set; }
        public int Attempts = 6;
        
        public void Game()
        {
            WordBank RandomWord = new WordBank();
            PlayingWord = RandomWord.GetWord();
            letterSelected = new bool[RandomWord.WordCount];
        }
        //track completion of the word 
        public void ShowLetter()
        {
            for(int i = 0; i <PlayingWord.Length; i++)
            {
                if (letterSelected[i])
                {
                    Console.WriteLine(letterSelected[i]);
                }
                else
                {
                    Console.WriteLine("_");
                }
            }
        }
        public string CorrectLetter()
        {
         for(int i = 0; i < PlayingWord.Length; i++)
            {
                if (i == letter)
                {
                    letterSelected[i] = true;
                }
            }
        }

    }
}
