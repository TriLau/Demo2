using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convat
{
    public class Class2
    {
        Class1 y;
        public Class2(Class1 x)
        {
            this.y = x;
        }
        public void X()
        {
            Console.WriteLine(y.A);
            Console.WriteLine(y.B);
        }
    }
}
