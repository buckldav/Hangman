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
            if (word.Contains(guess) && guess.Length > 0)
            {
                // Iterate through the word
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
                // Lose a life and print the number of lives remaining
                lives--;
                Console.WriteLine($"You have {lives} lives left");
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
