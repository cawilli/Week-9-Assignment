using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman_Game
{
    public class WordBank
    {
        public List<string> Words = new List<string>()
        {
            "Programming",
            "Engineering",
            "Technicians",
        };
        public int WordCount { get; set; }

        public string GetWord()
        {            
            Random random = new Random();
            int randomIndex = random.Next(0, Words.Count);            
            return Words[randomIndex];            
        }
        
    }
}
