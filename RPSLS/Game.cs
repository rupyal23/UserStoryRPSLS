using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Member variables
        Player player1;
        Player player2;
        public int round = 0;
        public int playerNumber;
        
        

        //Constructor
        public Game()
        {
            Console.WriteLine("GAME of ROCK, PAPER, SCISSORS, LIZARD, SPOCK");
            Console.WriteLine("RULES OF THE GAME:");
            Console.WriteLine("ROCK beats SCISSORS/LIZARD");
            Console.WriteLine("PAPER beats ROCK/SPOCK");
            Console.WriteLine("SCISSORS beats PAPER/LIZARD");
            Console.WriteLine("LIZARD beats SPOCK/PAPER");
            Console.WriteLine("SPOCK beats SCISSORS/ROCK");
            Console.WriteLine("PLAY 3 ROUNDS. WINNER WILL BE THE BEST OF 3.");

        }

        //Member Methods


        public void createPlayers()
        {
            Console.WriteLine("How many players do you want to start with?");
            playerNumber = int.Parse(Console.ReadLine());
            if(playerNumber == 1)
            {
                player1 = new Player1();
                player2 = new AI();
                player1.setName();
                player2.setName();
            }
            else if (playerNumber == 2)
            {
                player1 = new Player1();
                player2 = new Player1();
                player1.setName();
                player2.setName();
            }
            else
            {
                Console.WriteLine("No more than 2 players");
                createPlayers();
            }


        }

        public void runMyGame()
        {
            createPlayers();
            do
            {
                round++;
                Console.WriteLine("Begin Round "+round+" :");
                gameLogic();
            }
            while (round < 3);
            bestOf3();
            

        }

        public void setGestures()
        {


        }
     


        public void gameLogic()
        {
            string player1Gesture = player1.createGesture();
            string player2Gesture = player2.createGesture();
            switch (player1Gesture.ToLower())
            {
                case "rock":
                    if(player2Gesture.ToLower() == "scissors" || player2Gesture.ToLower() == "lizard")
                    {
                        Console.WriteLine(player1.name + "wins this Round");
                        player1.winnings++;
                    }
                    else if(player1Gesture.ToLower() == player2Gesture.ToLower())
                    {
                        Console.WriteLine("It's a Tie !!. Press Enter to Restart.");
                        round = 0;
                    }
                    else if(player2Gesture.ToLower() == "paper" || player2Gesture.ToLower() == "spock")
                    {
                        Console.WriteLine(player2.name +" wins this Round");
                        player2.winnings++;
                    }
                    else
                    {
                        Console.WriteLine("Not a Valid gesture");
                        player2Gesture = player2.createGesture();
                    }
                    break;

                case "paper":
                    if (player2Gesture.ToLower() == "rock" || player2Gesture.ToLower() == "spock")
                    {
                        Console.WriteLine(player1.name +" wins this Round");
                        player1.winnings++;
                    }
                    else if (player1Gesture.ToLower() == player2Gesture.ToLower())
                    {
                        Console.WriteLine("It's a Tie !!. Press Enter to Restart.");
                        round = 0;
                    }
                    else if(player2Gesture.ToLower() == "scissors" || player2Gesture.ToLower() == "lizard")
                    {
                        Console.WriteLine(player2.name + " wins this Round");
                        player2.winnings++;
                    }
                    else
                    {
                        Console.WriteLine("Not a Valid gesture");
                        gameLogic();
                    }
                    break;

                case "scissors":
                    if (player2Gesture.ToLower() == "paper" || player2Gesture.ToLower() == "lizard")
                    {
                        Console.WriteLine(player1.name + " wins this Round");
                        player1.winnings++;
                    }
                    else if (player1Gesture.ToLower() == player2Gesture.ToLower())
                    {
                        Console.WriteLine("It's a Tie !!. Press Enter to Restart.");
                        round = 0;
                    }
                    else if(player2Gesture.ToLower() == "spock" || player2Gesture.ToLower() == "rock")
                    {
                        Console.WriteLine(player2.name + " wins this Round");
                        player2.winnings++;
                    }
                    else
                    {
                        Console.WriteLine("Not a Valid gesture");
                    }
                    break;

                case "lizard":
                    if (player2Gesture.ToLower() == "spock" || player2Gesture.ToLower() == "paper")
                    {
                        Console.WriteLine(player1.name + " wins this Round");
                        player1.winnings++;
                    }
                    else if (player1Gesture.ToLower() == player2Gesture.ToLower())
                    {
                        Console.WriteLine("It's a Tie !!. Press Enter to Restart.");
                        round = 0;
                    }
                    else if(player2Gesture.ToLower() == "scissors" || player2Gesture.ToLower() == "rock")
                    {
                        Console.WriteLine(player2.name + " wins this Round");
                        player2.winnings++;
                    }
                    else
                    {
                        Console.WriteLine("Not a Valid gesture");
                    }
                    break;

                case "spock":
                    if (player2Gesture.ToLower() == "scissors" || player2Gesture.ToLower() == "rock")
                    {
                        Console.WriteLine(player1.name + " wins this Round");
                        player1.winnings++;
                    }
                    else if (player1Gesture.ToLower() == player2Gesture.ToLower())
                    {
                        Console.WriteLine("It's a Tie !!. Press Enter to Restart.");
                        round = 0;
                    }
                    else if(player2Gesture.ToLower() == "lizard" || player2Gesture.ToLower() == "paper")
                    {
                        Console.WriteLine(player2.name + " wins this Round");
                        player2.winnings++;
                    }
                    else
                    {
                        Console.WriteLine("Not a Valid gesture");
                    }
                    break;
                default:
                    Console.WriteLine("Not a Valid gesture");
                    break;
            }
         
        }

        public void gestureValidation()
        {
            
        }

        public void startRound(int round)
        {
            if (round < 3)
            {
                round++;
                Console.WriteLine("Begin Round " + round + ":");
            }
            else
            {
                round = 0;
                bestOf3();
            }

        }

        public void displayWinnerEveryRound(int winnings)
        {
            
        }

        public void bestOf3()
        {
            if(player1.winnings > player2.winnings)
            {
                Console.WriteLine(player1.name+" is the WINNER");
            }
            else
            {
                Console.WriteLine(player2.name + " is the WINNER");
            }
        }
     
    }
}
