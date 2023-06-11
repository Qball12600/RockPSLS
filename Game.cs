using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player player1;
        public Player player2;
        Random rnd;
        //Constructor
        public Game()
        {
            int scorePlayer1 = 0;
            int scorePlayer2 = 0;
            int scoreJarvis = 0;

            rnd = new Random();

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
         "Paper desolves Spock",
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

            if (numberOfHumanPlayers == 1)
            {
                player1 = new Player();
                player2 new ComputerPlayer();
            }
            else if (numberOfHumanPlayers == 2)
            {
                player1 = new Player();
                player2 = new Player();
            }
            else
            {
                return;
            }


        }

        public void CompareGestures()
        {
            if (player1 != null && player2 != null)
            {
                string player1Gesture = player1Gesture.ChosenGesture;
                string player2Gesture = player2Gesture.ChosenGesture;
                if (player1Gesture == player2Gesture)
                {
                    Console.WriteLine("Draw!");
                }
                else if (player1Gesture == "Rock" && (player2Gesture == "Scissors" || player2Gesture == "Lizard") || (player1Gesture == "Scissors" && (player2Gesture == "Paper" || player2Gesture == "Lizard")) || (player1Gesture == "Paper" && (player2Gesture == "Rock" || player2Gesture == "Spock")) || (player1Gesture == "Spock" && (player2Gesture == "Rock" || player2Gesture == "Scissors")))
                {
                    Console.WriteLine("Player 1 wins!");
                    player1++; ;
                }
                else
                {
                    Console.WriteLine("Player 2 wins!");
                    player2++;
                }
            }
            else
            {
                Console.WriteLine("Not enough players to compare.");
            }
        }



        public void DisplayGameWinner()

        { 
         if (scorePlayer1 >= 3 && scorePlayer1 > scorePlayer2)
            {
                Console.WriteLine("Player one wins the game!");
            }
            else if (scorePlayer2 >= 3 && scorePlayer2> scorePlayer1)
            {
                 Console.WriteLine("Player Two wins the game!");
            }
            else
            {
                 Console.WriteLine("No winner yet. Keep playing!");
            }
        }
public void RunGame()
        {     
            WelcomeMessage();
            while (scorePlayer1 < 3 && scorePlayer2 < 3)
            {

                int numberOfSides = ChosenGestures();
                int player1Gesture = CreatePlayerObjects(numberOfSides);
                int player2Gesture = CreatePlayerObjects(numberOfSides);
                CompareGestures(player1Gesture, player2Gesture);

                Console.WriteLine($"Player one score:  {player1}");
                Console.WriteLine($"Player two score:  {player2}");
                Console.ReadLine();
            }

        }   
    }
}
