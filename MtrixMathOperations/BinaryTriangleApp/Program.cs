using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTriangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p, lastInt = 0, input;
            Console.WriteLine("Enter the number of rows");
            input=int.Parse(Console.ReadLine());    
            for(int i=1; i<input; i++)
            {
                for(p=1;p<=1; p++)
                { 
                    if(lastInt==1)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
