using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExamples
{
    internal class NumberOfDaysInMonthYear
    {
        static void Main()
        {
            const int Aug = 7;
            const int Feb = 2;

            int daysInJuly = System.DateTime.DaysInMonth(2024, Aug);
            Console.WriteLine(daysInJuly);

            
            int daysInFeb = System.DateTime.DaysInMonth(2021, Feb);
            Console.WriteLine(daysInFeb);

            
            int daysInFebLeap = System.DateTime.DaysInMonth(2004, Feb);
            Console.WriteLine(daysInFebLeap);
        }
    }
}
