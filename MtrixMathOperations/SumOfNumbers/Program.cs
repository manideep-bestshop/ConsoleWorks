using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;
            Console.WriteLine("Enter the Nth number");
            n=int.Parse(Console.ReadLine());
            for(i=0;i<=n;i++)
            {
                sum=sum+i;
            }
            Console.WriteLine("Sum of N Numbers : "+sum);
        }
    }
}
