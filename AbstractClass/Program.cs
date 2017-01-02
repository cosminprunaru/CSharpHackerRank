using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            String oldTitle = "Do Androids Dream of Electric Sheep?";
            String newTitle = "I Was Told There'd Be Cake";

            MyBook book = new MyBook();

            book.setTitle(oldTitle);
            Console.WriteLine("Book title: {0}", book.title);
      
            book.setTitle(newTitle);
            Console.WriteLine("Book title: {0}", book.title);

            Console.ReadKey();
        }
    }
}
