using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
           
            Car c = new Car();
            
            c.DisplaySpeed();//0
            c.Accelerate();
            c.DisplaySpeed();//10
            c.brandname = "BMW";
            c.speed = 150;



            c.DisplaySpeed();//10
            c.Accelerate();
            c.DisplaySpeed();//20
            c.speed = 50;
            c.DisplaySpeed();//
            c.Accelerate();
            c.DisplaySpeed();

            ModifiedCar mc = new ModifiedCar();
            ModifiedCar mc2 = new ModifiedCar("Honda", 60);
            mc.DisplaySpeed();
            mc._Speed = 500;
            mc._Speed = 150;
            mc._BrandName = "AUDI";
            mc.DisplaySpeed();
            mc.Accelerate();
            mc.DisplaySpeed();
            //c.speed = 500;
            //c.DisplaySpeed();


        }
    }
  
}
