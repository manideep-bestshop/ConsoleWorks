using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    internal class UsingThrowKeyWord
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("enter 1st value..");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Value..");
                int b = int.Parse(Console.ReadLine());

                if (b== 0)
                    throw new DivideByZeroException();
                int c = a / b;
                Console.WriteLine("Quot is " + c);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("cant divide the number by zero..");
                throw;
            }
        }
    }
}
