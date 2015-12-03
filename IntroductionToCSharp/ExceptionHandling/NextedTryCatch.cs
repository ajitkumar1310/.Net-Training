using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class NextedTryCatch
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int a = 0;
                    somemethod();
                    Console.WriteLine(10 / a);
                }
                catch (Exception ex)
                {
                    throw ex;
                    //Console.WriteLine("Do you want me to handle here ?Y/N");
                    //string str = Console.ReadLine();
                    //if(str=="Y")
                    //{
                    //    Console.WriteLine("Exception is handled inside catch ");
                    //}
                    //else
                    //{
                       
                       // throw;
                    //}
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Am actually handled outside catch");
                Console.WriteLine(ex.StackTrace);
            }

        }


        
        static void somemethod()
        {
            throw new DivideByZeroException();
        }
    }
}
