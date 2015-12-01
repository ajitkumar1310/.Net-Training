using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticType_Bank
{
    static class StaticClass
    {
        public static  int a;
        static StaticClass()
        {
            a = 10;
        }
        public static int  GetA()
        {
            return a;
        }
        public static void SetA(int b)
        {
            a = b;
        }

    }
}
