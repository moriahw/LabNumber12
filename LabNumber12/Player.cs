using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    abstract class Player
    {
        private string name;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Player()
        {
            Name = " ";
        }

        public Player(string playername)
        {
            Name = playername;
        }

        public abstract string generateRoshambo();



    }
}
