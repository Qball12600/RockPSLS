using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Human : Player
    {
       
        public Human(string name) : base(name)
        {
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            score = 0;
        }

        public void EnterName()
        {
            name = Console.ReadLine();
            Console.WriteLine($"{name},  Enter name.");

        }
        public override void ChooseGesture()
        {
            //Give player a choice. 
            //Get users choice and uppercase. 
            Console.WriteLine("choose between rock, paper, scissors, lizard,and spock");
            chosenGesture = Console.ReadLine().ToLower();
        }



        //    if (playerOne != null && playerTwo != null)
        //    {
        //        string playerOneGesture = playerOneGesture.ChosenGesture;
        //        string playerTwoGesture = playerTwoGesture.ChosenGesture;
        //        if (playerOneGesture == playerTwoGesture)
        //        {
        //            Console.WriteLine("Draw!");
        //        }
        //        else if (playerOneGesture == "Rock" && (playerTwoGesture == "Scissors" || playerTwoGesture == "Lizard") || (playerOneGesture == "Scissors" && (playerTwoGesture == "Paper" || playerTwoGesture == "Lizard")) || (playerOneGesture == "Paper" && (playerTwoGesture == "Rock" || playerTwoGesture == "Spock")) || (playerOneGesture == "Spock" && (playerTwoGesture == "Rock" || playerTwoGesture == "Scissors")))
        //        {
        //            Console.WriteLine("Player 1 wins!");
        //            scorePlayerOne++; ;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Player 2 wins!");
        //            scorePlayerTwo++;
        //        }
        //    }
        //}
    }         
}
