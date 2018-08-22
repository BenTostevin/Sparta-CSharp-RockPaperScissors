using System;
namespace RockPaperScissors
{
    public class RPSMove
    {

        public string humanMove;
        public bool moveIsValid;
        public int computerRandChoice;
        public string computerMove;
        public bool someoneHasWon;


        public RPSMove()
        {

            someoneHasWon = false;

            while (someoneHasWon == false)
            {

                HumanSelectsMove();
                CheckValidMove();
                ComputerSelectsMove();

                if (humanMove == computerMove)
                {
                    Console.WriteLine("Draw");
                }
                else
                {

                    if ((humanMove == "rock" && computerMove == "scissors") ||
                        (humanMove == "paper" && computerMove == "rock") ||
                        (humanMove == "scissors" && computerMove == "paper"))
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose");
                    }

                    someoneHasWon = true;
                }
            }
        }


        public void HumanSelectsMove()
        {
            moveIsValid = false;

            while (moveIsValid == false)
            {
                Console.WriteLine("Make your move: ");
                humanMove = Console.ReadLine();

                CheckValidMove();
            }
        }


        public void CheckValidMove()
        {
            if (humanMove == "rock" || humanMove == "paper" || humanMove == "scissors")
            {
                moveIsValid = true;
            }
            else
            {
                Console.WriteLine("Not a valid move");
            }
        }

        public void ComputerSelectsMove()
        {

            Random rnd = new Random();
            computerRandChoice = rnd.Next(0, 3);

            switch (computerRandChoice)
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
            }

            Console.WriteLine("Your opponent chooses " + computerMove);

        }



    }
}
