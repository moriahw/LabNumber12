using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    class Human:Player
    {
        public override string generateRoshambo()
        {
            Console.WriteLine("Please enter Rock, Paper, or Scissors.");
            string play = Console.ReadLine().ToLower();
            return play;
        }

    }
}
