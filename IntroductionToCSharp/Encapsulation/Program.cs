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
            c._BrandName = "BMW";
            c.Speed = 150;
            c.Speed = 500;
           

            //c.DisplaySpeed();//10
            //c.Accelerate();
            //c.DisplaySpeed();//20
            //c.speed = 50;
            //c.DisplaySpeed();//
            //c.Accelerate();
            //c.DisplaySpeed();


            //c.speed = 500;
            //c.DisplaySpeed();

            
        }
    }
  
}
