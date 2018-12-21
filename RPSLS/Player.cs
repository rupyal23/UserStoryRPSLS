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
        public List<string> gestures = new List<string>() { "rock", "scissors", "paper", "spock", "lizard" };


        //Constructor
        public Player()
        {

        }

        //Member Methods
        //method to create name
        public virtual void setName()
        {
            do
            {
                Console.WriteLine("Please Enter the player name:");
                name = Console.ReadLine();
            }
            while (!checkName(name));

        }

        public static bool checkName(string name)
        {
            foreach(char c in name)
            {
                if (!Char.IsLetter(c))
                {
                    Console.WriteLine("Please enter letters only. Try agin!");
                    return false;
                }
               
            }
            return true;
        }

                       


        //Method for creating random gesture
        public virtual string createGesture()
        {
            Console.WriteLine("Enter the gesture you want to play "+name);
            gesture = Console.ReadLine().ToLower();
            if(!gestures.Contains(gesture))
            {
                Console.WriteLine("Not a valid gesture " + name + ". Please enter again !");
                createGesture();
            }
            return gesture;
        }

    }
}
