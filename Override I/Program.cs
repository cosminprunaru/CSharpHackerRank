using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Sports c1 = new Sports();
            Soccer c2 = new Soccer();

            Console.WriteLine(c1.getName());
            c1.getNumberOfPlayers();

            Console.WriteLine(c2.getName());
            c2.getNumberOfPlayers();

            Console.ReadKey();
        }
    }
}
