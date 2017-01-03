using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_I
{
    class Sports
    {
        public virtual String getName()
        {
            return "Generic sport";
        }

        public virtual void getNumberOfPlayers()
        {
            Console.WriteLine("Each team has n players in {0}", getName());
        }
    }
}
