using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2024;

            object obj = year; //Boxing : Value to reference

            year = 2000;

            Console.WriteLine("Value type of year is {0}", year);
            Console.WriteLine("Object type of year is {0}", obj);


            year=(int)obj; //UnBoxing-Ref to value type
            Console.WriteLine("Reference to value:"+year);
        }
    }
}
