using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();
           // e.GiveBonus();
            Employee e1 = new Manager();
            e1.GiveBonus();
            Employee e2 = new CEO();
            e2.GiveBonus(); 
            carvan c=new Maheshbabucarvan();

        }
    }
}
