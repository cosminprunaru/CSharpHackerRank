using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static IEnumerator func(ArrayList mylist)
        {
            IEnumerator it = mylist.GetEnumerator();

            while (it.MoveNext())
            {
                Object element = it.Current;

                if (element is String)
                    break;
            }
            return it;
        }

        static void Main(string[] args)
        {
            ArrayList container = new ArrayList();

            for (int i = 0; i < 10; i++)
                container.Add(i);
            
            container.Add("###");

            for (int i = 10; i > -1; i--)
                container.Add(i);

            IEnumerator enumerator = func(container);

            while (enumerator.MoveNext())
            {
                Console.Write("{0} ", enumerator.Current);
            }

            Console.ReadKey();
        }
    }
}
