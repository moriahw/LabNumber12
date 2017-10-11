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
            bool playAgain = true;

            Human RealPlayer = new Human();
            RandomPlayer Opponent = new RandomPlayer();

            Console.WriteLine("Welcome to Rock, Paper, Scissors! Please enter your name.");
            string userName = Console.ReadLine();

            while (playAgain == true)
            {
                string playerOne = RealPlayer.generateRoshambo();
                string playerTwo = Opponent.generateRoshambo();

                if (playerOne == playerTwo)
                {
                    Console.WriteLine("Your opponent chose " + playerTwo);
                    Console.WriteLine("Tie!");
                }
                else if (playerOne == "rock" && playerTwo == "paper" || playerOne == "paper" && playerTwo == "scissors" || playerOne == "scissors" && playerTwo == "rock")
                {
                    Console.WriteLine("Your opponent chose " + playerTwo);
                    Console.WriteLine("Player Two wins!");
                }
                else
                {
                    Console.WriteLine("Your opponent chose " + playerTwo);
                    Console.WriteLine("Congrats " + userName + " you win!");
                }

                Console.WriteLine("Would you like to play again?");
                string response = Console.ReadLine();

                if (response == "y" || response == "yes")
                {
                    playAgain = true;
                    Console.WriteLine("Great! Lets go again!");
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing!");
                }
            }

            playAgain = false;

        }
    }
}
