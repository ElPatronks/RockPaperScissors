using System;

namespace PracticalProject_Rock_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Papers";
            const string Scissors = "Scissors";

            bool isGameGoing = true;

            int playerPoints = 0;
            int pcPoints = 0;
            int gamePointsPlayer = 0;
            int gamePointsPc     = 0;

            while (isGameGoing)
            {
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                 var playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")        
                {
                    playerMove = Scissors;
                }
                else if (playerMove == "end")
                {
                    Console.WriteLine("End Game");
                    isGameGoing = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again...");
                    return;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);

                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }
                Console.WriteLine($"The computer chose {computerMove}.");
                

                if ((playerMove == Rock && computerMove == Scissors) ||
                    (playerMove == Paper && computerMove == Rock) ||
                    (playerMove == Scissors && computerMove == Paper))
                {
                    Console.WriteLine("You win.");
                    playerPoints++;
                }
                else if ((playerMove == Scissors && computerMove == Rock) ||
                    (playerMove == Rock & computerMove == Paper) ||
                    (playerMove == Paper && computerMove == Scissors))
                {
                    Console.WriteLine("You lose.");
                    pcPoints++;   
                }
                else
                {
                    Console.WriteLine("This game is a draw.");
                }
                Console.WriteLine($"Result PC {pcPoints} - Player {playerPoints}");     

                if ( playerPoints == 3  )
                {
                    if (playerPoints % 3 ==0)
                    {
                        gamePointsPlayer++;
                    }
                    
                    Console.WriteLine($"The player wins! And has won {gamePointsPlayer} set of games!");
                    
                }
                else if ( pcPoints == 3 )
                {
                    if (pcPoints % 3 ==0)
                    {
                        gamePointsPc++;
                    }
                    Console.WriteLine($"The PC wins! And has won {gamePointsPc} set of games");
                }
                Console.WriteLine();
            }
        }
    }
}
