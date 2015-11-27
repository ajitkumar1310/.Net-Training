using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectange r = new Rectange();
            r.length = 10;
            r.width = 20;
            r.CalRectArea();
        }
    }
}
