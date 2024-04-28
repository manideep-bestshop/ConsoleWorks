using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num, sum = 0, m, initialVal;
            num=int.Parse(Console.ReadLine());
            initialVal = num;

            while(num > 0)
            {
                m = num % 10;
                sum = sum + m;
                num= num / 10;
            }
            Console.WriteLine("Sum of digits "+sum);
        }
    }
}
