using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first value..");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Value");
                int b = int.Parse(Console.ReadLine());

                int c = a / b;
                Console.WriteLine("Quot is "+c);

                Console.WriteLine("Enter n Value:");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[3];
                Console.WriteLine("N ="+n);

                Console.WriteLine("Length :"+arr.Length);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Wrong I/P..");
            }
            catch(OverflowException e)
            {
                Console.WriteLine("array size can't be negative..");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("can't divide by zero..");
            }
            finally
            {
                Console.WriteLine("from finally block..");
            }
        }
    }
}
