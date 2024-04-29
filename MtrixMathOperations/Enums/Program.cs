using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine("Today is: " + today);

            int todayInt = (int)today;
            Console.WriteLine("Today's integer value is: " + todayInt);

            // Enum comparison
            if (today == DayOfWeek.Wednesday)
            {
                Console.WriteLine("It's Wednesday!");
            }
        
    }
    }
}
