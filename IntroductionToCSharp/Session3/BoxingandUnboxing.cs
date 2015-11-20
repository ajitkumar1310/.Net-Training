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

           




            #region Conversions and Overflow
            byte b;

            short s = 259;
            unchecked
            {
                b = (byte)s;
            }

            Console.WriteLine(b);
            short s1;
            int i1 = 32768;

            s1 = (short)i1;

            Console.WriteLine(s1);

            s1 = (short)i1;
            Console.WriteLine(s1);
            unchecked
            {
                s1 = (short)i1;
            }
            s1 = (short)i1;
            Console.WriteLine(s1);
           // //here use checked() keyword to throw the exception when overflow or underflow occurs or we can use settings under debug options

            s1 = checked((short)i1);
            Console.WriteLine(s1);

            #endregion

            Console.WriteLine("----------------Boxing and UnBoxing--------------------");

            #region Boxing and Unboxing
            int i = 10;
            object obj = i;//boxing putting my data into big box(object)
            int j = (int)obj;//fetching data from box(unboxing)
            char c = 'a';
            object o2 = c;
            char d = (char)o2;
            Console.WriteLine(j);
            Console.WriteLine("After Unboxing the value is " + (int)obj);
            #endregion

            Console.WriteLine("------------------------Loops--------------------------");

            #region loops
            Console.WriteLine("------------------Loops-----------------------");
            //for, while loop, do-while, foreach

            // int forvar = 10;
            for (int forvar = 2; forvar < 0; forvar--)
            {
                Console.WriteLine("Am in loop " + forvar);


            }


            Console.WriteLine("am out of forloop");

            Console.WriteLine("-----------While Loop---------------");

            int whilevar = 0;
            while (whilevar > 2)
            {

                Console.WriteLine("Am in While Loop " + whilevar);
                whilevar++;

            }

            Console.WriteLine("Am out of while Loop");


            int dowhilevar = 0;
            do
            {
                Console.WriteLine("Am in Do While Loop " + dowhilevar);
                dowhilevar++;
            } while (dowhilevar > 2);

            Console.WriteLine("Am out of Do- while Loop");

            int[] intarray = { 1, 2, 3 };

            foreach (int element in intarray)
            {
                Console.WriteLine(element);
            }

            string[] stringarray = { "Avinash", "Abhinav", "Ajit" };
            //Console.WriteLine(stringarray[1]);

            foreach (var str in stringarray)
            {
                string fullname = "";
                fullname = str + "kumar";
                Console.WriteLine(fullname);

            }



            Console.WriteLine("am out of foreach loop");




            #endregion

            Console.WriteLine("------------------------Decision Statements--------------------------");

            #region Desicion Statements and switch
            int ifvar1 = 5, ifvar2 = 10;
            if (ifvar1 > 5)
                Console.WriteLine("var is greater than  5");
            else
                Console.WriteLine("var is less than 5");

            if (ifvar1 > 4 && ifvar2 >= 10)//cover <=,!=,== and || and !
                Console.WriteLine("Both conditions are satisfied");

            //swicth case
            Console.WriteLine("-------coniditional statements-----------");

            //int conditionstat = 1;
            bool conitionres = 7 > 1;
            bool varia = false;
            int a = 10;
            int e = 10;

            if (true)
            {
                Console.WriteLine("am in if statement ");
            }

            if (7 < 1)
            {
                Console.WriteLine("7 is greater than 1 ");
            }
            else
            {
                Console.WriteLine("7 is not greater than 1 ");
            }

            if (a == e)
            {
                Console.WriteLine("a is greater thn e");
            }
            else if (a == e)
            {
                Console.WriteLine("a is equal  thn e");
            }
            else
            {
                Console.WriteLine("a is equal to e");
            }

            if (!(varia))
            {
                Console.WriteLine("am in if statement ");
            }



            bool isAbhiramthere = false;
            bool isAjitthere = false;

            //nested if
            if (isAbhiramthere == true)
            {
                if (isAjitthere == true)
                {
                    Console.WriteLine("We will have a class ");
                }
                else
                {
                    Console.WriteLine("We will not have a class ");

                }
            }
            else
            {

                Console.WriteLine("We will not have a class ");
            }
            //|| and &&
            if ((isAbhiramthere == true) || (isAjitthere == true))
            {
                Console.WriteLine("ateleast one is true");
            }

            Console.WriteLine("--------------Switch-------------");

            int switchvar = 6;

            switch (switchvar)
            {
                case 1: Console.WriteLine("am in case 1");
                    break;
                case 2: Console.WriteLine("am in case 2");
                    break;
                case 3: Console.WriteLine("am in case 3");
                    break;
                case 4: Console.WriteLine("am in case 4");
                    break;
                case 5: Console.WriteLine("am in case 5");
                    break;
                default: Console.WriteLine("am in default");
                    break;

            }

            

         


            #endregion

        }
    }
}
