﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Game
    {
        private string word;
        private string displayWord;
        private int lives;

        public Game()
        {
            // TODO: Initialize all of the fields
            word = "guess";
            displayWord = "-----";
            lives = 7;
        }

        /*
         * This method takes the user input (guess), checks if the word contains it,
         * then replaces the hyphens of the displayWord with the guessed letters.
         * If the guessed letters are not contained in the word, lose a life and print
         * the number of lives left for the user to see. 
         * 
         * No need to edit this method
         */
        public void GuessLetter(string guess)
        {
            if (word.Contains(guess) && guess.Length > 0)
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

        /*
         * TODO: Get the displayWord
         */
        public string GetDisplayWord()
        {
            return null;
        }

        /*
         * TODO: Return true if the game is solved, otherwise false 
         */
        public bool Solved()
        {
            return false;
        }

        /*
         * TODO: Return true if there are no lives left, otherwise false
         */
        public bool Dead()
        {
            return false;
        }
    }
}