using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_I
{
    class Soccer : Sports
    {
        public override string getName()
        {
            return "Soccer class";
        }

        public override void getNumberOfPlayers()
        {
            Console.WriteLine("Each team has 11 players in Soccer Class");
        }
    }
}
