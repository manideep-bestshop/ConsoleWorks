using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayArrayListDictionaryListExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            intArray[0] = 2;
            intArray[1] = 4;
            intArray[2] = 6;
            intArray[3] = 8;
            intArray[4] = 10;
            intArray[5] = 12; //Run time error  
         //   intArray[6] = "Hello";//Compile time error  
            foreach (int i in intArray)
            {
                Console.WriteLine("From array " + i);
            }
            Console.WriteLine("From array " + intArray[6]); //Run time error
        }
    }
}
