using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class AI : Player
    {

        public AI(string name) : base(name)
        {
            this.name = "Jarvis";
            //this.gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            //this.score = 0;
        }


        public override void ChooseGesture()

        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(gestures.Count);
            chosenGesture = gestures[randomIndex];
        }
    
            
        
    }
}
