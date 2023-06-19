using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
       
        public Player playerTwo;
        
        //Constructor
        public Game()
        {

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
            
        }

        public int ChooseNumberOfHumanPlayers()
        {
            //Have the user choose between 1 or 2 human players.
            //CW to ask user to choose. 
            //CR to get the input. But I need to convert the user input into a int. 
            //I need a conditional to check if its an int &  if not convert it. 
            //Conditional to make sure int is either 1 or 2. 
            //It not 1 or 2 then tell user that is an invalid input. Have them choose again. 
            {

                Console.WriteLine("Choose number of human players. Choose 1 or 2.");
                if (int.TryParse(Console.ReadLine(), out int Human))
                {
                    if (Human == 1)
                    {
                        return Human;
                    }
                    else if (Human == 1 || Human == 2)
                    {
                        return Human;
                    }
                    else
                    { 
                        Console.WriteLine("Invalid choice, out of range choose 1 or 2. ||");
                        return ChooseNumberOfHumanPlayers();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    return ChooseNumberOfHumanPlayers();
                }

                
            }
            
        }
            
        public void CompareGestures()
        {
            if (playerOne != null && playerTwo != null)
            {
                playerOne.ChooseGesture();
                Console.WriteLine($"{playerOne.name} chose {playerOne.chosenGesture}." ); 
                playerTwo.ChooseGesture();
                Console.WriteLine($"{playerTwo.name} chose {playerTwo.chosenGesture}.");
                if (playerOne.chosenGesture == playerTwo.chosenGesture)
                {
                    Console.WriteLine("Draw!");
                }
                else if (playerOne.chosenGesture == "Rock" && (playerTwo.chosenGesture == "Scissors" || playerTwo.chosenGesture == "Lizard") || (playerOne.chosenGesture == "Scissors" && (playerTwo.chosenGesture == "Paper" || playerTwo.chosenGesture == "Lizard")) || (playerOne.chosenGesture == "Paper" && (playerTwo.chosenGesture == "Rock" || playerTwo.chosenGesture == "Spock")) || (playerOne.chosenGesture == "Spock" && (playerTwo.chosenGesture == "Rock" || playerTwo.chosenGesture == "Scissors")))
                {
                    Console.WriteLine($"{playerOne.name} wins!");
                    playerOne.IncreaseScore();
                }
                else
                {
                    Console.WriteLine($"{playerTwo} wins!");
                    playerTwo.IncreaseScore();
                }
            }

        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            int Human = ChooseNumberOfHumanPlayers();
            {
                if (numberOfHumanPlayers == 1)
                {
                    Console.WriteLine("Enter PlayerOne name: ");
                    string playerOneName = Console.ReadLine();
                    Player playerOne = new Human(playerOneName);

                    Player playerTwo = new AI("Computer");


                }
                else if (numberOfHumanPlayers == 2)
                {
                    Console.WriteLine("Enter PlayerOne name: ");
                    string playerOneName = Console.ReadLine();
                    playerOne = new Human(playerOneName);



                    Console.WriteLine("Enter PlayerTwo name: ");
                    string playerTwoName = Console.ReadLine();
                    playerTwo = new Human(playerTwoName);


                }
            }
        }

        public void DisplayGameWinner()
        {
           

            if (playerOne.score == 3)
            {
                Console.WriteLine($"{playerOne.name} WON!");
            }
            else 
            {
                Console.WriteLine($"{playerTwo.name} Won!");
            }

        }

        public void RunGame()
        {
                //Display Rules and Rounds
                WelcomeMessage();
            //Get number of human players. 

            //Create human class
            //Create computer class


            ChooseNumberOfHumanPlayers();
            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();






            while (playerOne != null && playerTwo != null && playerOne.score < 3 && playerTwo.score < 3)
            {
                

                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                Console.WriteLine($"Player One chose: {playerOne.chosenGesture}");
                Console.WriteLine($"Player Two chose: {playerTwo.chosenGesture}");

                CompareGestures();

                Console.WriteLine($"Player one score:  {playerOne.score}");
                Console.WriteLine($"Player two score:  {playerTwo.score}");
                Console.ReadLine();

                DisplayGameWinner();

                }

            }
    }
}

