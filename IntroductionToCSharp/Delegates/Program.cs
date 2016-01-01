using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        public delegate void del();
        public delegate int delwithargs(int a, int b);
        static void Main(string[] args)
        {
            del mydel= Method1;
            mydel += Method2;
            mydel();
            mydel += Method3;
            mydel();
            mydel -= Method3;
            mydel();
            delwithargs mydelwithargs = new delwithargs(MethodAddArgs);
            mydelwithargs += MethodSubArgs;
            mydelwithargs += MethodMulArgs;
            int result = mydelwithargs(10, 5);
            Console.WriteLine(result);

        }
        public static void Method1()
        {

            Console.WriteLine("Am in method1");
        }
        public static void Method2()
        {
            Console.WriteLine("Am in method2");
        }
        public static void Method3()
        {
            Console.WriteLine("Am in method3");
        }
        public static int MethodAddArgs(int a, int b)
        {
            return a + b;
        }
        public static int MethodSubArgs(int a, int b)
        {
            return a - b;
        }
        public static int MethodMulArgs(int a, int b)
        {
            return a * b;
        }
    }
}
