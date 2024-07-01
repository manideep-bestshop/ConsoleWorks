using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExamples
{
    internal class ParameterizedMethod
    {
        public static int Add(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }
        public static void Main()
        {
            Console.Write("Enter A number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter B number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Add(n1,n2));
        }
    }
}
