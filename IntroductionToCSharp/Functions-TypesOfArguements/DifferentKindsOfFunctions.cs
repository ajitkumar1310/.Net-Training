using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class parent
//{
//    public void PrintName()
//    {
//         Console.WriteLine("My name is Abhinav ");
//    }
//}

namespace Functions_TypesOfArguements
{
    class DifferentKindsOfFunctions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functions and Arguements");

            ////PrintName();
            //PrintGenName("Abhinav",20);            
            //VoidMethodWithParams(10, "Ajit");
            //int result = Add(10, 20);
            //VoidMethod();
            //int resultvar;
            //resultvar=Multply(10, 20);
            //resultvar = Multply(10, 20);
            //Console.WriteLine("Multiplication of two numbers is "+resultvar);
            //Console.WriteLine("Addition of two numbers is "+result);
            //int subrest;
            //subrest = Substrct(100, 50);
            //Console.WriteLine(subrest);
            Console.WriteLine("Add method with one param");
            int addonepar = Add(10);
            Console.WriteLine(addonepar);
            Console.WriteLine("Add method with 2 params");
            int twoparam = Add(10, 20);
            Console.WriteLine(twoparam);
            Console.WriteLine("Add method with 2 params in one is float");
            int floatparam = Add(10, 20.5F);
            Console.WriteLine(floatparam);
       


        }

        static int Substrct(int a , int b)
        {
            return a - b;
        }

        static int Multply(int a,int b)
        {
            int result=a* b;
            return result;
        }


        static void PrintName()
        {
            Console.WriteLine("My name is Abhinav ");
        }

        static void PrintGenName(string str,int age)
        {
            Console.WriteLine("My Name is "+str );
            Console.WriteLine("my age is "+age);
        }

        static void VoidMethod()
        {
            Console.WriteLine("Hellow Again");
            Console.WriteLine("Hellow from Void Method");
            Console.WriteLine("Hellow again");
        }
        static void VoidMethodWithParams(int a, string name)
        {
            for(int i=0;i<a;i++)
            {
                Console.WriteLine(name);
            }
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a )
        {
            return (int)(a + 10);
        }
        static int Add(int a, float b)
        {
            return (int)( a + b);
        }

    }
}
