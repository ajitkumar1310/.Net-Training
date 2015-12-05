using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public interface Interface1
    {
        void method1();
        void method2();
    }
    public interface Interface2
    {
        void method1();
        void method3();
    }

   public class interfaceclass : Interface1, Interface2
    {
      public void method1()
       {
           Console.WriteLine("Am in Interface 1 method");
       }
        void Interface2.method1()
        {
            Console.WriteLine("Am in Interface 2 method");
        }
       public   void method2()
       {
           Console.WriteLine("Am in interfacemethod2");
       }
       public  void method3()
       {
           Console.WriteLine("Am in Interface2Method2");
       }

    }
}
