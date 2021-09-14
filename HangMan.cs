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
        
        //this will choose a word at random for the player to guess
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

        // this will update which letters were found in the random word from the word bank created.
        public string CorrectLetter(char letter)
        {
            string pick = PlayingWord;
         for(int i = 0; i < PlayingWord.Length; i++)
            {
                if (i == letter)
                {
                    letterSelected[i] = true;
                }
            }
        }
        // this will track if the game should end
        //taking in user input and comparing it to the length of the random word from the word bank
        //if the user still has attempts it wil check the letter with the word
        //if all the letters are guessed, ideally the game will end 
        public bool EndGame()
        {
            int correctAnswer = 0;
            if (Attempts < 1)
                return true;

            for (int i = 0; i <letterSelected.Length; i++)
            {
                if (!letterSelected[i])
                    return false;
                else correctAnswer++;
            }

            if (correctAnswer == PlayingWord.Length)
                return true;
            else
                return false;
        }

    }
}
