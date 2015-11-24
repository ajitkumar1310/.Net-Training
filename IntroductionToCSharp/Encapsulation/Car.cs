using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        //data or state
        public string brandname;
        public int speed;
        //behavior
        public void DisplaySpeed()
        {
            Console.WriteLine(brandname+" car is going at a speed of "+speed+" MPH");
        }
        public void Accelerate()
        {
            speed = speed + 10;
        }
    }
    public class   ModifiedCar
    {
        //data
        private string brandname;
        private int speed;
        public string color;
        //properties
        public string _BrandName
        {
            get
            {
                return brandname;
            }
            set
            {
                brandname = value;
            }
        }

        public int _Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value > 200)
                    Console.WriteLine("speed cannot be > 200 MPH");
                else
                    speed = value;
            }
        }
       // constructer
        public ModifiedCar()
        {
            brandname = "Maruthi";
            speed = 50;
        }

        public ModifiedCar(string carname):this()
        {
            brandname = carname;
        }

        public ModifiedCar(string carname, int carspeed):this(carname)
        {
           
            speed = carspeed;
        }
        public ModifiedCar(string carname, int carspeed,string carcolor):this(carname,carspeed)
        {
           
            color = carcolor;
        }
        
        //behavior
        public void DisplaySpeed()
        {
            Console.WriteLine(brandname + " car is going at a speed of " + speed + " MPH");
        }
        public void Accelerate()
        {
            speed = speed + 10;
        }
    }
}
