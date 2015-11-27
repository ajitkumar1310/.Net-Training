using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        //data
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
        //constructors
        public ModifiedCar()
        {
            brandname = "Maruthi";
            speed = 50;
        }
        public ModifiedCar(int spd)
        {
            speed = spd;
        }
        public ModifiedCar(string brname,int spd):this(spd)
        {
            speed = spd;
            brandname = brname;
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
