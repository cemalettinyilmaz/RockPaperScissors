using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int computerScore = 0;
            string exitKey = "";
            while (exitKey != "e")
            {
                Console.Clear();
                Console.WriteLine("Rock - Paper - Scissors");
                Console.WriteLine();
            GetInput:
                Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors or [e]xit.");
                string playerMove = "";
                switch (Console.ReadLine().ToLower())
                {
                    case ("r"):
                        playerMove = "rock";
                        break;
                    case ("p"):
                        playerMove = "paper";
                        break;
                    case ("s"):
                        playerMove = "scissors";
                        break;
                    case ("e"):
                        exitKey = "e";
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input... Try again");
                        goto GetInput;

                }
                Console.WriteLine($"Your choose {playerMove}");
                Random rnd = new Random();
                int random = rnd.Next(3);
                string computerMove = "";

                switch (random)
                {
                    case 0:
                        computerMove = "rock";
                        break;
                    case 1:
                        computerMove = "paper";
                        break;
                    case 2:
                        computerMove = "scissors";
                        break;

                    default:
                        break;
                }
                Console.WriteLine($"The Computer choose {computerMove}");
                if ((playerMove == "rock" && computerMove == "paper") || (playerMove == "paper" && computerMove == "scissors") || (playerMove == "scissors" && computerMove == "rock"))
                {
                    computerScore++;
                }
                else if ((playerMove == "paper" && computerMove == "rock") || (playerMove == "scissors" && computerMove == "paper") || (playerMove == "rock" && computerMove == "scissors"))
                {
                    playerScore++;
                    Console.WriteLine("Computer lose. You win!");
                }
                else
                    Console.WriteLine("This game was a draw.");


                Console.WriteLine($"Computer score  :{computerScore} Player score:{ playerScore}");

                Console.ReadLine();


            }
        }
    }
}
