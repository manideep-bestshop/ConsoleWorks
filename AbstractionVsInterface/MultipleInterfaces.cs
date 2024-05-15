using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionVsInterface
{
    interface AddNums
    {
        void Add(int a, int b);
    }
    interface SubNums
    {
        void Sub(int a, int b);
    }
    class Calculations : AddNums, SubNums
    {
        public void Add(int a, int b)
        {
            int res = a + b;
            Console.WriteLine("Addition is :"+res);
        }

        public void Sub(int x, int y)
        {
            int res=x - y;
            Console.WriteLine("Substraction is :"+res);
        }
    }
    internal class MultipleInterfaces
    {
        static void Main()
        {
            Calculations calculations = new Calculations();
            calculations.Add(23, 27);
            calculations.Sub(27, 23);
        }
    }
}
