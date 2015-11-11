using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp
{
    class DifferentMains
    {
        #region Different Mains
        //static void Main()
        //{
        //    int a = 10, b = 20;
        //    Console.WriteLine("Hellow!!! Welcome To CSharp World!!!");
        //    Console.WriteLine(a + b);

        //}
        //static int Main()
        //{
        //    int a = 10, b = 20;
        //    Console.WriteLine("Hellow!!! Welcome To CSharp World!!!");
        //    Console.WriteLine(a + b);
        //    return 1;
        //}
        static void Main(string[] args)
        {

            Console.WriteLine("Hellow!!! Welcome To CSharp World!!!");
            Console.WriteLine(args[0] + args[1]);
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            Console.WriteLine(a+b);

        }

        //static int Main(string[] args)
        //{
        //Console.WriteLine("Hellow!!! Welcome To CSharp World!!!");
        //    Console.WriteLine(args[0] + args[1]);
        //    int a = int.Parse(args[0]);
        //int b = int.Parse(args[1]);
        //Console.WriteLine(a+b);
        //return 0l
        //}

        #endregion
    }
}
