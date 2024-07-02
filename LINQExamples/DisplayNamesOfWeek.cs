using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    internal class DisplayNamesOfWeek
    {
        public static void Main()
        {
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

           
            var days = from WeekDay in dayWeek
                       select WeekDay;

            foreach (var WeekDay in days)
            {
                Console.WriteLine(WeekDay);
            }
        }
    }
}
