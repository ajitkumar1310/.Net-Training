using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            MiscTyp m = new MiscTyp();
            //const var cannnot be assigned and constvar is implicitly static.
            //MiscTyp.consvar = 200;
            //readvar cannot be assigned and readvar is not implicitly static
            //m.readvar = 200;
            Abhinavclass ab = new Abhinavclass();
           


    }
    }
    class MiscTyp
    {
        public const int consvar = 100;//by default static
        public readonly int readvar = 200;//by default not static instead it can be assigne in the constructor but not in other method

        public MiscTyp()
        {
           // consvar = 200;error
            readvar = 300;
        }
    }
}
