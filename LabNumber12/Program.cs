using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Human RealPlayer = new Human();
            RandomPlayer Opponent = new RandomPlayer();

            string playerOne = RealPlayer.generateRoshambo();
            string playerTwo = Opponent.generateRoshambo();

            if (playerOne == playerTwo)
            {
                Console.WriteLine("Tie!");
            }
            else if (playerOne == "Rock" && playerTwo == "Paper" || playerOne == "Paper" && playerTwo == "Scissors" || playerOne == "Scissors" && playerTwo == "Rock")
            {
                Console.WriteLine("Player Two wins!");
            }
            else
            {
                Console.WriteLine("Player One wins!");
            }

        }
    }
}
