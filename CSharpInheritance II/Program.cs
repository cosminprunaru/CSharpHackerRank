using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Adder adder = new Adder();

            Console.WriteLine("My base is: {0}", adder.GetType().BaseType);
            Console.WriteLine("10 + 3 = {0}", adder.add(10, 3));

            Console.ReadKey();
        }
    }
}
