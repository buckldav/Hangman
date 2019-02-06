using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new game object
            Game game = null;
            // Game loop
            while (true)
            {
                // Print the display word
                Console.WriteLine(game.GetDisplayWord());
                // TODO: Write your own code for the game
            }
        }
    }
}
