using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    class RandomPlayer:Player
    {
        public override string generateRoshambo()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode()); //generates a new sequence each time the method is called
            int Number = rnd.Next(1, 4);

            if (Number == 1)
            {
                return "Rock";
            }
            else if (Number == 2)
            {
                return "Scissors";
            }
            else
            {
                return "Paper";
            }


            

        }
    }
}
