using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public  class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;
        // Properties!
        public string _empName
        {
            get { return empName; }
            set
            {
                 empName = value;
            }
        }
        public int _empid
        {
            get { return empID; }
            set { empID = value; }
        }
        public float _currPay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        private int empAge;
        public int _empAge
        {
            get { return empAge; }
            set { empAge = value; }
        }
        private int bonus;
       public int _bonus
        {
           get
            {
                return bonus;
            }
           set
            {
                bonus = value;
            }
        }
      
        public Employee() 
        {
            Console.WriteLine("Am in base/parent class constructer");
        }
       public Employee(string name, int age, int id)
        { }
        public Employee(string name, int age, int id, float pay):this( name,  age,  id)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            //Console.WriteLine("Name:"+empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
        }
       public virtual  void GiveBonus()
        {
            Console.WriteLine("Am in Parent bonus method");
            bonus = (int)(currPay * 0.05F);
            Console.WriteLine("Bonus is "+bonus);
           
        }

    }
    //public class humanbeing
    //{
    //    public string address;
    //    public  float currPay;
    //}
    public class Manager:Employee
    {
        public Manager()
        {
            Console.WriteLine("Am in child/derived Class constructer");
        }
        public Manager(string name, int age, int id, float pay):base(name,age,id,pay)
        {

        }
        public override void GiveBonus()
        {
            Console.WriteLine("Am in child class bonus method");
            _bonus = (int)(_currPay * 0.05F) + 5000;
            Console.WriteLine("Bonus is " + _bonus);

        }
        public  void AddBonus()
        {
            Console.WriteLine("Am in Parent bonus method");
          //  bonus = (int)(currPay * 0.05F);
           // Console.WriteLine("Bonus is " + bonus);

        }
        public void SomeMethod()
        {
            Console.WriteLine(  "am in some method");
        }
       
    }
    public class CEO:Employee
    {
        public CEO(string name, int age, int id, float pay)
            : base(name, age, id, pay)
        {

        }

        public  override void GiveBonus()
        {
            Console.WriteLine("Am in child class bonus method");
            _bonus = (int)(_currPay * 0.05F) + 10000;
            Console.WriteLine("Bonus is " + _bonus);

        }
    }
    public class DerivedCEO : CEO
    {
        public DerivedCEO(string name, int age, int id, float pay)
            : base(name, age, id, pay)
        {

        }
        public  override void GiveBonus()
        {
            Console.WriteLine("Am in child class bonus method");
            _bonus = (int)(_currPay * 0.05F) + 10000;
            Console.WriteLine("Bonus is " + _bonus);

        }
      
    }
   
}
