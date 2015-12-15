using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTypes
{
    class NullableTypes
    {
        enum weekdays { sun,mon=10,tue,wed=20,thu};
        enum InterestRates { FixedInterest=10, FloatingInterest=15,mortgageinterest=20};

        public static void Main()
        {
            
            int? num = null;
            if(num.HasValue)
            {
                Console.WriteLine(num);

            }
            else
            {
                Console.WriteLine("number is null");
            }

            int y = num ?? 10;
            Console.WriteLine(y);
            Console.WriteLine((int)weekdays.wed);
            Console.WriteLine((int)weekdays.thu);
            Console.WriteLine((int)InterestRates.FixedInterest);

        }
    }
}
