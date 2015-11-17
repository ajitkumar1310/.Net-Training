using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    class BoxingandUnboxing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Conversions and Overflow--------------------");

            #region Conversions and Overflow
            byte b;
            short s = 258;
            //b = (byte)s;
            //Console.WriteLine(b);
            short s1;
            int i1 = 65355;
            unchecked
            {
                s1 = (short)i1;
            }
            //s1 = (short)i1;
            Console.WriteLine(s1);
            //here use checked() keyword to throw the exception when overflow or underflow occurs or we can use settings under debug options

            //s1 = checked((short)i1);
            Console.WriteLine(s1);

            #endregion

            Console.WriteLine("----------------Boxing and UnBoxing--------------------");

            #region Boxing and Unboxing
            int i = 10;
            object obj = i;
            int j = checked((int)obj);
            Console.WriteLine(j);            
            Console.WriteLine("After Unboxing the value is "+(int)obj);
            #endregion

            Console.WriteLine("------------------------Loops--------------------------");
            
            #region loops
            for(int loop=0; loop < 10; loop++)
            {
                Console.WriteLine("Am in  for loop "+loop);
            }
            Console.WriteLine("------------------------For Each String Loop---------------------");
            string[] strarray = {"Ajit","Abhinav","Avinash" };
            foreach(string str in strarray)
                Console.WriteLine(str);
            //foreach (var str in strarray)
            //    Console.WriteLine(str);

            Console.WriteLine("------------------------For Each int Loop---------------------");
            int[] intarray = { 1, 2, 3 };
            foreach(int loopint in intarray)
                Console.WriteLine(loopint);
            //foreach (var loopint in intarray)
            //    Console.WriteLine(loopint);
            int wloop = 0;
            while( wloop <0)
            {
               
                Console.WriteLine("Am in  for While loop " + wloop);//This will not execute
                wloop++;
            }

            int dloop = 0;
            do
            {
               
                Console.WriteLine("Am in  for Do-While loop " + dloop);//This will atleast execute once
                dloop++;

            } while (dloop < 0);

            #endregion

            Console.WriteLine("------------------------Decision Statements--------------------------");

            #region Desicion Statements
            int ifvar1 = 5,ifvar2=10;
            if(ifvar1>5)
                Console.WriteLine("var is greater than  5");
            else
                Console.WriteLine("var is less than 5");

            if(ifvar1>4 && ifvar2>=10)//cover <=,!=,== and || and !
                Console.WriteLine("Both conditions are satisfied");

            //swicth case

            #endregion

        }
    }
}
