using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //Member Variables
        public string name;
        public int winnings;
        public string gesture;
        public List<string> gestures = new List<string>() { "Rock", "Scissors", "Paper", "Spock", "Lizard" };


        //Constructor
        public Player()
        {

        }

        //Member Methods
        //method to create name
        public virtual void setName()
        {
            Console.WriteLine("Please Enter the player name:");
            name = Console.ReadLine();
        }
            


        //Method for creating random gesture
        public virtual string createGesture()
        {
            Console.WriteLine("Enter the gesture you want to play "+name);
            gesture = Console.ReadLine();
            return gesture;
        }

    }
}
