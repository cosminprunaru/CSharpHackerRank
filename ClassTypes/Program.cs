using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes
{
    class Student { }
    class TimeLord { }
    class Hacker { }

    class Program
    {
        static String count(ArrayList myList)
        {
            int a = 0, b = 0, c = 0;

            foreach (var element in myList)
            {
                if (element is Student)
                    a++;
                if (element is TimeLord)
                    b++;
                if (element is Hacker)
                    c++;
            }

            String ret = String.Format("Students: {0}\nTimeLords: {1}\nHackers: {2}", a, b, c);
            return ret;
        }

        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();

            myList.Add(new TimeLord());

            myList.Add(new Hacker());
            myList.Add(new Hacker());

            myList.Add(new Student());
            myList.Add(new Student());
            myList.Add(new Student());
            myList.Add(new Student());

            Console.WriteLine(count(myList));
            Console.ReadKey();
        }
    }
}
