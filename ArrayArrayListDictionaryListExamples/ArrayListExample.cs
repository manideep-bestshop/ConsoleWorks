using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayArrayListDictionaryListExamples
{
    internal class ArrayListExample
    {
        static void Main()
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(2);
            myArrayList.Add("Array List Here..");
            foreach (object obj in myArrayList)
            {
                Console.WriteLine("From arrayList " + obj.ToString());
            }
            Console.WriteLine("-------");
        }
    }
}
