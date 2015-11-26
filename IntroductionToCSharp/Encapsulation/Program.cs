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
            //int a;
           
            //Car c = new Car();
            
            //c.DisplaySpeed();//0
            //c.Accelerate();
            //c.DisplaySpeed();//10
            //c.brandname = "BMW";
            //c.speed = 150;


            //c.DisplaySpeed();//10
            //c.Accelerate();
            //c.DisplaySpeed();//20
            //c.speed = 50;
            //c.DisplaySpeed();//
            //c.Accelerate();
            //c.DisplaySpeed();
            //c.speed = 500;
            //ModifiedCar mc = new ModifiedCar();
            //mc._Speed = 500;
            //mc._Speed = 150;
            //mc._BrandName = "AUDI";
            //mc.DisplaySpeed();
            //mc.Accelerate();
            //mc.DisplaySpeed();
            ////c.speed = 500;
            ////c.DisplaySpeed();
            //ModifiedCar mc2 = new ModifiedCar();
            //Console.WriteLine(mc2._BrandName);
            //Console.WriteLine(mc2._Speed);
            //ModifiedCar mc3 = new ModifiedCar("Audi");
            //Console.WriteLine(mc3._BrandName);
            //Console.WriteLine(mc3._Speed);
            ModifiedCar mc1 = new ModifiedCar();
            Console.WriteLine(mc1._BrandName);
            
            ModifiedCar mc2 = new ModifiedCar("AUDI");
            Console.WriteLine(mc2._BrandName);
            Console.WriteLine(mc2._Speed);

            ModifiedCar mc3 = new ModifiedCar("BMW", 100);
            Console.WriteLine(mc3._BrandName);
            Console.WriteLine(mc3._Speed);
            mc3.Accelerate();
            Console.WriteLine(ModifiedCar.statvar);


            ////Console.WriteLine(mc4._BrandName);
            //Console.WriteLine(mc4._Speed);
            //ModifiedCar mc5 = new ModifiedCar("BMW", 100,"RED");



        }
    }
  
}
