using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvebNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a number: ");
            i=int.Parse(Console.ReadLine());
            if(i%2==0 )
            {
                Console.WriteLine("Entered number is Even");
            }
            else
            {
                Console.WriteLine("Entered Number is Odd");

            }
        }
    }
}
