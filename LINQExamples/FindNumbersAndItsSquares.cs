using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    internal class FindNumbersAndItsSquares
    {
        public static void Main()
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            var sqNo = from int Number in arr1
                       let SqrNo = Number * Number
                       where SqrNo > 20
                       select new { Number, SqrNo };

            foreach (var a in sqNo)
                Console.WriteLine(a);
        }
    }
}
