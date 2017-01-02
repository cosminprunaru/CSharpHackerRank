using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance_I
{
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("I am flying!");
        }

        public void sing()
        {
            Console.WriteLine("I am singing!");
        }
    }
}
