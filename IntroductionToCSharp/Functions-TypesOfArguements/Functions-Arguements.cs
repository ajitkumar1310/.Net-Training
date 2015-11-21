using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_TypesOfArguements
{
    public class Functions_Arguements
    {
       public  static void Main()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a and b before swap "+a+" "+b);
            Swap(a , b);
            Console.WriteLine("a and b after swap " + a + " " + b);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("a and b before swap " + a + " " + b);
            SwapRef(ref a,ref b);
            Console.WriteLine("a and b after swap " + a + " " + b);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("a and b before swap " + a + " " + b);
            int refvar = 10; int outvar = 10;
            MethOut(ref refvar, out outvar);
            Console.WriteLine(outvar + " " + refvar);
            
            ParamsMethod(1, 2, 3, 4, 5, 6);
            Console.WriteLine("----------------Named and Optional Parameters-------------");
            Console.WriteLine(  OptionalParamMethod(a));
            Console.WriteLine(OptionalParamMethod(20,30));
            NamedParamMethod(b: 20, a: 10);
        }
       
       static void Swap(int a ,int b)
       {
           int temp;
           temp = a;
           a = b;
           b = temp;
       }
       static void SwapRef(ref int a, ref int b)
       {
           int temp;
           temp = a;
           a = b;
           b = temp;
       }
       static void MethOut(ref int refvar, out int outvar)
       {
           outvar = 20;
           refvar = 20;
           
       }
        static void ParamsMethod(params int[]arr)
        {
            foreach(var element in arr)
            {
                Console.WriteLine(element);
            }
        }
        static int OptionalParamMethod(int a, int b=10)
        {
            return a + b;
        }
        static void NamedParamMethod(int a,int b)
        {
            Console.WriteLine(" a is "+a);
            Console.WriteLine("b is " + b);
        }
    }
}
