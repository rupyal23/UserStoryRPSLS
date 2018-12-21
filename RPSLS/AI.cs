using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        public AI()
        {
                
        }

        public override string createGesture()
        {
            Random randomGesture = new Random();
            int randomPos = randomGesture.Next(gestures.Count);

            string gesturePlayed = gestures[randomPos];
            Console.WriteLine("Computer played: " + gesturePlayed);

            return gesturePlayed;
        }
    }
}
