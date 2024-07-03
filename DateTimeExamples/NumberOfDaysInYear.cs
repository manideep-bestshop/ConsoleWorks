using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExamples
{
    internal class NumberOfDaysInYear
    {
        public static void Main()
        {
            DateTime dec31 = new DateTime(2020, 12, 31);

            for (int ctr = 0; ctr <= 20; ctr++)
            {
                DateTime dateToDisplay = dec31.AddYears(ctr);

                Console.WriteLine("{0:d}: day {1} of {2} {3}", dateToDisplay,
                                  dateToDisplay.DayOfYear,
                                  dateToDisplay.Year,
                                  DateTime.IsLeapYear(dateToDisplay.Year) ?
                                                      "(Leap Year)" : "");
            }
        }
    }
}
