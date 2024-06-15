using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityCodeWritting
{
    public class Calculator
    {
        // This method adds two integers and returns the result
        public int Add(int a, int b)
        {
            return a + b; // Add the numbers
        }
    }
    internal class CommentProperly
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(3, 5);
            Console.WriteLine($"The result is {result}.");
        }
    }
}
