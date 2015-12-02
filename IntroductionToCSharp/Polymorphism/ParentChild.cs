using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Parent
    {
        public void parentmethod()
        {
            Console.WriteLine("Am in parent method");
        }
        public  void CommonMethod()
        {
            Console.WriteLine("Am in parent common method");
        }
    }
    class Child:Parent
    {
        public void childmethod()
        {
            Console.WriteLine("Am in child method");
        }
        public new void CommonMethod()
        {
            Console.WriteLine("Am in child common method");
        }

    }
}
