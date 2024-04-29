using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfNumbersRecursion
{
    class prog
    {
        public int product(int a, int b)
        {
            if (a < b)
            {
                return product(b, a);
            }
            else if (b != 0)
            {
                return (a + product(a, b - 1));
            }
            else
            {
                return 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, result;
            Console.WriteLine("Enter two numbers to find their product: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            prog pg = new prog();
            result = pg.product(a, b);
            Console.WriteLine("Product of {0} and {1} is {2}", a, b, result);
            Console.ReadLine();

        }
    }
}
