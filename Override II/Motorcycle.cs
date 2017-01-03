using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_II
{
    class Motorcycle : Bicycle
    {
        public Motorcycle()
        {
            Console.WriteLine("Hello, I am a motorcycle, I am {0}", define_me());

            String temp = base.define_me();

            Console.WriteLine("My ancestor is a cycle who is {0}", temp);
        }

        public new String define_me()
        {
            return "a cycle with an engine";
        }
    }
}
