using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExamples
{
    internal class GetPastFutureDates
    {
        static void Main()
        {
            DateTime baseDate = new DateTime(2024, 7, 3);

            Console.WriteLine("    Base Date:        {0:d}\n", baseDate);

            for (int ctr = -1; ctr >= -15; ctr--)
            {
                Console.WriteLine("{0,2} year(s) ago:        {1:d}", Math.Abs(ctr), baseDate.AddYears(ctr));
            }
            Console.WriteLine(); 

            for (int ctr = 1; ctr <= 15; ctr++)
            {
                Console.WriteLine("{0,2} year(s) from now:   {1:d}", ctr, baseDate.AddYears(ctr));
            }
        }
    }
}
