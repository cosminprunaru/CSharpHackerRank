using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.walk();
            bird.fly();
            bird.sing();

            Console.ReadKey();
        }
    }
}
