using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var nQuery =
                from VrNum in n1 
                where (VrNum % 2) == 0
                select VrNum;

            Console.Write("\n the remainder 0 after divided by 2 are : \n");
            foreach (int VrNum in nQuery) 
            {
                Console.Write("{0} ", VrNum);
            }
        }
    }
}
