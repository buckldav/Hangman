using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Game
    {
        // *** FIELDS ***
        // The word to be guessed
        private string word;
        // The word the users can see (initialized as '---')
        private string displayWord;
        // The lives remaining
        private int lives;

        // *** CONSTRUCTOR ***
        public Game()
        {
            // TODO: Initialize all of the fields
        }

        // *** METHODS ***

        // Used for checking a user's guess
        // No need to edit this method
        public void GuessLetter(string guess)
        {
            if (guess.Length == 1)
            {
                if (word.Contains(guess))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guess[0])
                        {
                            // Change the letters in the display word that equal the guessed letter
                            displayWord = displayWord.Remove(i, 1).Insert(i, guess);
                        }
                    }
                }
                else
                {
                    lives--;
                    Console.WriteLine($"You have {lives} lives left");
                }
            }
            else
            {
                Console.WriteLine("Invalid guess, guess one letter at a time.");
            }
        }

        // TODO: Get the displayWord
        public string GetDisplayWord()
        {
            return null;
        }

        // TODO: Return true if the game is solved, otherwise false 
        public bool Solved()
        {
            return false;
        }

        // TODO: Return true if there are no lives left, otherwise false
        public bool Dead()
        {
            return false;
        }
    }
}
