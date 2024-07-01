using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExamples
{
    internal class SwappingNumbers
    {
        public static void interchange(ref int num1, ref int num2)
        {
            int newnum;

            newnum = num1;
            num1 = num2;
            num2 = newnum;
        }
        static void Main()
        {

            int n1, n2;

           
            
            Console.Write("Enter 1st number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

           
            Console.Write("Enter 2nd number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

           
            interchange(ref n1, ref n2);

           
            Console.WriteLine("Now the 1st number is : {0} , and the 2nd number is : {1}", n1, n2);
        }

    }
}
