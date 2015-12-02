using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e=new Employee("Abhinav", 29, 101, 1000F);
            //e.GiveBonus();
            //Manager m = new Manager("Ajit", 29, 100, 1000F);
            //m.GiveBonus();

            //CEO c = new CEO("Kumar", 29, 100, 1000F);
            //c.GiveBonus();
            //DerivedCEO dc = new DerivedCEO("Avinash", 29, 100, 1000F);
            //dc.GiveBonus();

         //   Employee e1;
         //   e1 = new Employee();
         //   Manager m1;
         //   m1 = new Manager();
         //   e1 = new Manager();


         ////   m1 = new Employee();

         //   Console.WriteLine("Enter the object to be created Manager or Employee");
         //   string str = Console.ReadLine();
         //   if (str == "manager")
         //   {
         //       e1 = new Manager();
         //   }
         //   else if (str == "employee")
         //   {
         //       e1 = new Employee();
         //   }
         //   m1.SomeMethod();

            Parent p = new Parent();
            Child c = new Child();
           /// Parent p = new Child();
           // p.parentmethod();
           // p.CommonMethod();
           // c.childmethod();
            c.CommonMethod();
            Parent p2 = new Child();
            p2.CommonMethod();
        }
    }
}
