using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {


        //Member Variabes (HAS A)
        public Player Player1;
        public Player Player2;


        int scorePlayer1 = 0;
        int scorePlayer2 = 0;
        int scoreJarvis = 0;

        //Constructor
        public Game()
        {
            scorePlayer1 = 0;
            scorePlayer2 = 0;
            scoreJarvis = 0;
        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");



            List<string> rules = new List<string>
        {
         "1. Select the number of players playing.",
         "2. First player to win 3 rounds wins the game.",
         "3. If a round ends in a draw no player will be awarded points and the game will continue until someone wins.",
         "4. To win you must best your opponents selection, they are as follows.",
         "Paper beats rock",
         "Rock beats scissors",
         "Scissors beats paper",
         "Rock crushes Lizard",
         "Lizard poisons Spock",
         "Spock smashes scissors",
         "Scissors decapitates Lizard",
         "Lizard eats paper",
         "Paper disproves Spock",
         "Spock vaporizes Rock"
        };
            foreach (string rule in rules)
            {
                Console.WriteLine(rule);
            }
            for (int i = 0; i < rules.Count; i++)
            {

                Console.WriteLine(rules[i]);
            }
        }


        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("Enter the number of players:");
            string input =
                Console.ReadLine();

            int result;


            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid number. Please enter a valid number:");
                input = Console.ReadLine();
            }
            return Int32.Parse(input);
        }


        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            string inputPlayer1, inputPlayer2, inputJarvis;
            int randomInt;
            bool playAgain = true;

                while (playAgain)
                     {
                        if (numberOfHumanPlayers == 1)
                        {
                            Player1 = new Player();
                            Player2 new ComputerPlayer();
                        }
                        else if (numberOfHumanPlayers == 2)
                        {
                            Player1 = new Player();
                            Player2 = new Player();
                        }
                        else
                        {
                        int scorePlayer1 = 0;
                        int scorePlayer2 = 0;
                        int scoreJarvis = 0;

                   
        }
        public void CompareGestures()
        {
                     while (scorePlayer1 < 3 && scoreJarvis < 3 && scorePlayer2 < 3)
                        {
                            Console.WriteLine("choose between ROCK, PAPER, SCISSORS, LIZARD,and SPOCK");
                        inputPlayer1 = Console.ReadLine();
                        inputPlayer2 = Console.ReadLine();
                        inputPlayer1 = inputPlayer1.ToUpper();
                        inputPlayer2 = inputPlayer2.ToUpper();


                        Random rnd = new Random();
                        randomInt = rnd.Next(1, 5);
                        switch (randomInt)
                        {

                            case 1:
                                inputJarvis = "ROCK";
                                Console.WriteLine("Jarvis chose ROCK");
                                if (inputPlayer1 == "ROCK" && inputPlayer2 == "ROCK")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer1 == "PAPER" && inputPlayer2 == "LIZARD")
                                {
                                    Console.WriteLine("PAPER COVERS ROCK, ROCK CRUSHES LIZARD!! PLAYER 1 WINS!!\n\n");
                                    scorePlayer1++;
                                }
                                else if (inputPlayer1 == "SCISSORS" && inputPlayer2 == "LIZARD")
                                {
                                    Console.WriteLine("ROCK BREAKS SCISSORS, ROCK CRUSHES LIZARD!! JARVIS WINS!!\n\n");
                                    scoreJarvis++;
                                }
                                else if (inputPlayer1 == "LIZARD" && inputPlayer2 == "SPOCK")
                                {
                                    Console.WriteLine("SPOCK VAPORIZES ROCK, ROCK CRUSHES LIZARD!! PLAYER 2 Wins!!\n\n");
                                    scorePlayer2++;
                                }
                                else if (inputPlayer1 == "SPOCK" && inputPlayer2 == "SCISSORS")
                                {
                                    Console.WriteLine("SPOCK VAPORIZES ROCK, ROCK CRUSHES SCISSORS!! PLAYER WINS!!\n\n");
                                    scorePlayer1++;
                                }
                                break;
                            case 2:
                                inputJarvis = "PAPER";
                                Console.WriteLine("Jarvis chose PAPER");
                                if (inputPlayer1 == "PAPER" && inputPlayer2 == "PAPER")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer1 == "ROCK" && inputPlayer2 == "SPOCK")
                                {
                                    Console.WriteLine("PAPER COVERS ROCK, PAPER DISPROVES SPOCK!! Jarvis WINS!!\n\n");
                                    scoreJarvis++;
                                }
                                else if (inputPlayer1 == "SCISSORS" && inputPlayer2 == "ROCK")
                                {
                                    Console.WriteLine("SCISSORS CUTS PAPER, PAPER COVERS ROCK!! PLAYER WINS!!\n\n");
                                    scorePlayer1++;
                                }
                                else if (inputPlayer1 == "SPOCK" && inputPlayer2 == "LIZARD")
                                {
                                    Console.WriteLine("PAPER DISPROVES SPOCK, LIZARD EATS PAPER!! PLAYER WINS!!\n\n");
                                    scorePlayer2++;
                                }
                                else if (inputPlayer1 == "SPOCK" && inputPlayer2 == "SCISSORS")
                                {
                                    Console.WriteLine("PAPER DISPROVES SPOCK, SCISSORS CUTS PAPER!! Jarvis WINS!!\n\n");
                                    scorePlayer2++;
                                }
                                break;
                            case 3:
                                inputJarvis = "SCISSORS";
                                Console.WriteLine("Jarvis chose SCISSORS");
                                if (inputPlayer1 == "SCISSORS" && inputPlayer2 == "SCISSORS")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer1 == "ROCK" && inputPlayer2 == "PAPER")
                                {
                                    Console.WriteLine("ROCK BREAKS SCISSORS, SCISSORS CUT PAPER!! PLAYER WINS!!\n\n");
                                    scorePlayer1++;
                                }
                                else if (inputPlayer1 == "PAPER" && inputPlayer2 == "LIZARD")
                                {
                                    Console.WriteLine("SCISSORS CUTS PAPER, SCISSORS DECAPITATES LIZARD!! Jarvis WINS!\n\n");
                                    scoreJarvis++;
                                }
                                else if (inputPlayer1 == "LIZARD" && inputPlayer2 == "SPOCK")
                                {
                                    Console.WriteLine("SCISSORS DECAPITATES LIZARD, SPOCK SMASHES SCISSORS!! Player 2 WINS!!\n\n");
                                    scorePlayer2++;
                                }
                                else if (inputPlayer1 == "SPOCK" && inputPlayer2 == "PAPER")
                                {
                                    Console.WriteLine("SPOCK SMASHES SCISSORS, SCISSORS CUTS PAPER !! PLAYER 1 WINS!!\n\n");
                                    scorePlayer1++;
                                }
                                break;
                            case 4:
                                inputJarvis = "LIZARD";
                                Console.WriteLine("Jarvis chose LIZARD");
                                if (inputPlayer1 == "LIZARD" && inputPlayer2 == "LIZARD")
                                {
                                    Console.WriteLine("DRAW!\n\n");
                                }
                                else if (inputPlayer1 == "ROCK" && inputPlayer2 == "PAPER")
                                {
                                    Console.WriteLine("ROCK CRUSHES LIZARD, LIZARD EATS PAPER!! PLAYER 1 WINS!!\n\n");
                                    scorePlayer1++;
                                }
                                else if (inputPlayer1 == "PAPER" && inputPlayer2 == "SPOCK")
                                {
                                    Console.WriteLine("LIZARD EATS PAPER, LIZARD POISONS SPOCK!! Jarvis WINS!!\n\n");
                                    scoreJarvis++;
                                }
                                else if (inputPlayer1 == "SPOCK" && inputPlayer2 == "SCISSORS")
                                {
                                    Console.WriteLine("LIZARD POISONS SPOCK, SCISSORS DECAPITATES LIZARD!! PLAYER 2 WINS!!\n\n");
                                    scorePlayer2++;
                                }
                                else if (inputPlayer1 == "SCISSORS" && inputPlayer2 == "ROCK")
                                {
                                    Console.WriteLine("SCISSORS DECAPITATES LIZARD, ROCK CRUSHES LIZARD AND SCISSORS!! PLAYER 2 WINS!!\n\n");
                                    scorePlayer2++;
                                }
                                break;
                            case 5:
                                inputJarvis = "SPOCK";
                                Console.WriteLine("Jarvis choses SPOCK");
                                if (inputPlayer1 == "SPOCK" && inputPlayer2 == "SPOCK")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer1 == "ROCK" && inputPlayer2 == "SCISSORS")
                                {
                                    Console.WriteLine("SPOCK VAPORIZES ROCK, SPOCK SMASHES SCISSORS!!Jarvis WINS!!\n\n");
                                    scoreJarvis++;
                                }
                                else if (inputPlayer1 == "SCISSORS" && inputPlayer2 == "LIZARD")
                                {
                                    Console.WriteLine("SPOCK SMASHES SCISSORS, LIZARD POISONS SPOCK!! PLAYER 2 WINS!!\n\n");
                                    scorePlayer2++;
                                }
                                else if (inputPlayer1 == "PAPER" && inputPlayer2 == "ROCK")
                                {
                                    Console.WriteLine("PAPER DISPROVES SPOCK, SPOCK VAPORIZES ROCK!! PLAYER 1 WINS!!\n\n");
                                    scorePlayer1++;
                                }
                                else if (inputPlayer1 == "LIZARD" && inputPlayer2 == "SCISSORS")

                                {
                                    Console.WriteLine("LIZARD POISONS SPOCK, SPOCK SMASHES SCISSORS!! PLAYER 1 WINS!!\n\n");
                                    scorePlayer1++;
                                }
                                break;

                     default:
                         Console.WriteLine("Invalid entry!");
                         break;


                }
                        




        }
        public void DisplayGameWinner()
        {

                Console.WriteLine("\n\nSCORES:\tPlayer1:\t{0}\tJarvis:\t{1}\tPlayer2:\t{2}", scorePlayer1, scoreJarvis, scorePlayer2);
                    }
                    if (scorePlayer1 == 3)
                    {
                        Console.WriteLine("Player1 WON!");
                    }
                    else if (scoreJarvis == 3)
                    {
                        Console.WriteLine("Jarvis WON!");
                    }
                    else if (scorePlayer2 == 3)
                    {
                        Console.WriteLine("Player2 Won!");
                    }
                    else

                    {
                    }
                    Console.WriteLine("Do you want to play again? (y/n)");
                    string loop = Console.ReadLine();
                    if (loop == "y")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else if (loop == "n")
                    {
                        playAgain = false;
                    }
                    else
                    { 
        }
        public void RunGame()
        {
            WelcomeMessage();

                        while (scorePlayer1 < 3 && scorePlayer2 < 3)
                        {

                            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
                            int player1Gesture = CreatePlayerObjects(numberOfHumanPlayers);
                            int player2Gesture = CreatePlayerObjects(numberOfHumanPlayers);
                            CompareGestures(player1Gesture, player2Gesture);

                            Console.WriteLine($"Player one score:  {scorePlayer1}");
                            Console.WriteLine($"Player two score:  {scorePlayer2}");
                            Console.ReadLine();
                        }

                    }
                }
            }
        }
    }
}
                    
                
            
        
    




















