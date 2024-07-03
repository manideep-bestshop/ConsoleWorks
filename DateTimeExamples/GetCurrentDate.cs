using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExamples
{
    internal class GetCurrentDate
    {
        static void Main()
        {
            DateTime thisDay = DateTime.Today;

            Console.WriteLine("General format " + thisDay.ToString());

            Console.WriteLine("Display the date in a variety of formats: ");
            Console.WriteLine(thisDay.ToString("d")); 
            Console.WriteLine(thisDay.ToString("D")); 
            Console.WriteLine(thisDay.ToString("g")); 
        }
    }
}
