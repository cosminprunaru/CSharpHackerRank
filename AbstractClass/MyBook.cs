using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class MyBook : Book
    {
        public override void setTitle(string s)
        {
            this.title = s;
        }
    }
}
