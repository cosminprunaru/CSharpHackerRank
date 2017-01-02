using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 13;
            MyCalculator calculator = new MyCalculator();
            Console.WriteLine("I inherited: ");
            ImplementedInterfaces(calculator);

            Console.WriteLine("The sum of number {0}'s divisors is {1}", number, calculator.divisorSum(number));
            Console.ReadKey();
        }

        static void ImplementedInterfaces(Object o)
        {
            Type[] interfaces = o.GetType().GetInterfaces();
            foreach (var name in interfaces)
            {
                Console.WriteLine(name);
            }
        }
    }
}
