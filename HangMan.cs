using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman_Game
{
    public class HangMan
    {
        public string PayingWord { get; set; }
        public char Guess { get; set; }
        public string Misses { get; set; }
        public int Attempts { get; set; }
    }
}
