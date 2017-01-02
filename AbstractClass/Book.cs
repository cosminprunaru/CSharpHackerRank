using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Book
    {
        public String title;
        public abstract void setTitle(String s);
        String getTitle()
        {
            return title;
        }
    }
}
