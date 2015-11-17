using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp
{
    class DataTypes
    {

        static void Main()
        {
            int a = 10;
            bool b = false;
            float f = 2.33F;
            decimal d=5.78M;
            char c = 'c';
            string s = "ajit";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(s);
            Console.WriteLine("Size of int " + sizeof(bool) + "bytes");
            Console.WriteLine("Size of int " + sizeof(char) + "bytes");
            Console.WriteLine("Size of int " + sizeof(int) + "bytes");
            Console.WriteLine("Size of int " + sizeof(long) + "bytes");
            Console.WriteLine("Size of int " + sizeof(float) + "bytes");
            Console.WriteLine("Size of int " + sizeof(double) + "bytes");
            Console.WriteLine("Size of int " + sizeof(decimal) + "bytes");            
            

        }
    }
}
