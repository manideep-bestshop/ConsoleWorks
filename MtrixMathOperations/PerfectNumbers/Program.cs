using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            Console.WriteLine("Enter the Nth Number");
            int nthNo=int.Parse(Console.ReadLine());
            Console.WriteLine("Perfect numbers from 1 to Nth number");

            for(n=1; n<=nthNo; n++)
            {
                i = 1;
                sum=0;
                while(i<n)
                {
                    if(n%i==0)
                        sum=sum+i;
                    i++;
                }
                if (sum == n)
                {
                    Console.WriteLine("{0}",n);
                }
            }

        }
    }
}
