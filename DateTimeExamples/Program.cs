using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.DateTime moment = new System.DateTime(2024, 7, 3, 1, 43, 32, 11);

            Console.WriteLine("year = " + moment.Year);

            Console.WriteLine("month = " + moment.Month);

            Console.WriteLine("day = " + moment.Day);

            Console.WriteLine("hour = " + moment.Hour);

            Console.WriteLine("minute = " + moment.Minute);

            Console.WriteLine("second = " + moment.Second);

            Console.WriteLine("millisecond = " + moment.Millisecond);
        }
    }
}
