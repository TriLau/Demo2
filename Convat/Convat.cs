using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convat
{
    public class Convat
    {
        protected string ten;
        public Convat (string ten)
        {
            this.ten = ten;
        }
        public virtual void Tieng()
        {
        }
    }
    public class Conmeo : Convat
    {
        public Conmeo(string ten) : base(ten)
        {
        }
        public override void Tieng()
        {
            Console.WriteLine(ten + " Meo meo");
        }
    }
    public class Concho : Convat
    {
        public Concho(string ten) : base(ten)
        {
        }
        public override void Tieng()
        {
            Console.WriteLine(ten + " Gau gau");
        }
    }
    public class Conheo : Convat
    {
        public Conheo(string ten) : base(ten)
        {
        }
        public override void Tieng()
        {
            Console.WriteLine(ten + " Ec ec");
        }
    }
    public class Conga : Convat
    {
        public Conga(string ten) : base(ten)
        {
        }
        public override void Tieng()
        {
            Console.WriteLine(ten + " O o o");
        }
    }
}
