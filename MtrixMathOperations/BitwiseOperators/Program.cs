using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators
{
    internal class Program
    {
        byte b1, b2;
        int x;
        long y;
        Program()
        {
            b1 = 10;
            b2 = 5;
            x = 32;
            y = 20;
        }
        static void Main(string[] args)
        {
            Program bit = new Program();
            byte p = (byte)(bit.b1 & bit.b2);
            byte q = (byte)(bit.b1 | bit.b2);
            byte r = (byte)(bit.b1 ^ bit.b2);
            int z = (int)(bit.x & bit.y);
            Console.WriteLine("b1={0},b2={1},x={2},y={3}", bit.b1, bit.b2, bit.x, bit.y);
            Console.WriteLine("b1 & b2={0} : ", p);
            Console.WriteLine("b1 | b2={0} : ", q);
            Console.WriteLine("b1 ^ b2={0} : ", r);
            Console.WriteLine("x & y = {0} : ", z);
            Console.ReadLine();
        }
    }
}
