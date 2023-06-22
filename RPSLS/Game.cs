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
            //Console.WriteLine();
            //playerOne = null;
            //playerTwo = null;
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
                    if (Human == 1 || Human == 2)
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
                //playerOne.ChooseGesture();
                Console.WriteLine($"{playerOne.name} chose {playerOne.chosenGesture}.");
                //playerTwo.ChooseGesture();
                Console.WriteLine($"{playerTwo.name} chose {playerTwo.chosenGesture}.");


                
                if ((playerOne.chosenGesture ==  "rock" && (playerTwo.chosenGesture == "scissors" || playerTwo.chosenGesture == "lizard")) || (playerOne.chosenGesture == "scissors" && (playerTwo.chosenGesture == "paper" || playerTwo.chosenGesture == "lizard")) || (playerOne.chosenGesture == "paper" && (playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "spock")) || (playerOne.chosenGesture == "spock" && (playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "scissors")))
                {
                   
                    Console.WriteLine($"{playerOne.name} wins!");
                    playerOne.IncreaseScore();
                }
                else if ((playerTwo.chosenGesture == "rock" && (playerOne.chosenGesture == "lizard" || playerOne.chosenGesture == "scissors")) || (playerTwo.chosenGesture == "scissors" && (playerOne.chosenGesture == "paper" || playerOne.chosenGesture == "lizard")) || (playerTwo.chosenGesture == "paper" && (playerOne.chosenGesture == "rock" || playerOne.chosenGesture == "spock"))  || (playerTwo.chosenGesture == "spock" && playerOne.chosenGesture == "scissors" || playerOne.chosenGesture == "rock"))
                {
                   
                    Console.WriteLine($"{playerTwo.name} wins!");
                    playerTwo.IncreaseScore();
                }
                else if (playerOne.chosenGesture == playerTwo.chosenGesture)
                {
                   
                    Console.WriteLine("Draw!");
                }
            }

        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            int Human;
                if (numberOfHumanPlayers == 1)
                {
                    Console.WriteLine("Enter PlayerOne name: ");
                    string playerOneName = Console.ReadLine();
                    playerOne = new Human(playerOneName);

                    playerTwo = new AI("Jarvis");


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

        public void DisplayGameWinner()
        {

            if (playerOne.score >= 3 && playerTwo.score <= 3)
            {
                Console.WriteLine($"{playerOne.name} WON!");
            }
            else if (playerOne.score <=3 && playerTwo.score >= 3)
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


            
            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);
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

