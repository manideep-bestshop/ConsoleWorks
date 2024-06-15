using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBoxing
{
    enum WeekDays:byte
    {
        Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
    }
    internal class EnumsExample
    {
        static void Main()
        {
            Console.WriteLine(WeekDays.Sunday);
            Console.WriteLine(WeekDays.Friday);

            WeekDays wd=WeekDays.Sunday;
            Console.WriteLine(wd);

            WeekDays weekDays=WeekDays.Friday;
            Console.WriteLine((int)weekDays);
        }
    }
}
