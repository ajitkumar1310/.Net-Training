using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {   

            interfaceclass Ic = new interfaceclass();

           ((Interface2) Ic).method1();
        }
    }
}
