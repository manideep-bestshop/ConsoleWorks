using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayArrayListDictionaryListExamples
{
    internal class ListExample
    {
        static void Main()
        {
            List<int> intList = new List<int>();
            intList.Add(2);
            intList.Add(8);
            intList.Add(4);
            intList.Add(6);
            foreach (int i in intList)
            {
                Console.WriteLine("From List " + i);
            }
        }
    }
}
