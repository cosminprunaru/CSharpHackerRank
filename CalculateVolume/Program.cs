using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateVolume
{
    class Calculate
    {
        public int get_int_val()
        {
            return int.Parse(Console.ReadLine());
        }

        public double get_double_val()
        {
            return double.Parse(Console.ReadLine());
        }

        public double get_volume(int a)
        {
            return a * a * a;
        }

        public double get_volume(int l, int b, int h)
        {
            return l * b * h;
        }

        public double get_volume(double r)
        {
            return (2 * Math.PI * r * r * r) / 3;
        }

        public double get_volume(double r, double h)
        {
            return Math.PI * (r * r) * h;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();

            double volume = 0.0;
            Console.WriteLine("Insert int value:\n1 - cube\n2 - cuboid\n3 - hemisphere\n4 - cylinder");
            int ch = cal.get_int_val();
            if (ch == 1)
            {
                Console.WriteLine("Insert cube length side:");
                int a = cal.get_int_val();
                volume = cal.get_volume(a);
            }
            else if (ch == 2)
            {
                Console.WriteLine("Insert cuboid first length side:");
                int l = cal.get_int_val();

                Console.WriteLine("Insert cuboid second length side:");
                int b = cal.get_int_val();

                Console.WriteLine("Insert cuboid third length side:");
                int h = cal.get_int_val();

                volume = cal.get_volume(l, b, h);

            }
            else if (ch == 3)
            {
                Console.WriteLine("Insert hemisphere radius:");
                double r = cal.get_double_val();
                volume = cal.get_volume(r);

            }
            else if (ch == 4)
            {
                Console.WriteLine("Insert cylinder radius:");
                double r = cal.get_double_val();

                Console.WriteLine("Insert cylinder height:");
                double h = cal.get_double_val();
                volume = cal.get_volume(r, h);

            }
            Console.WriteLine("Volume: {0}", Math.Round(volume, 3));
            Console.ReadKey();
        }
    }
}
