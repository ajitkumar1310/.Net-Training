using System;

namespace ADDCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c;
            c = Add(a, b);
            Console.WriteLine(c);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
