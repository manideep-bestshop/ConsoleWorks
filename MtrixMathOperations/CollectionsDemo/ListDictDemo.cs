using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class ListDictDemo
    {
        static void MaIN()
        {
            
            ListDictionary myDict = new ListDictionary();

            myDict.Add("I", "first");
            myDict.Add("II", "second");
            myDict.Add("III", "third");
            myDict.Add("IV", "fourth");
            myDict.Add("V", "fifth");

            Console.WriteLine("Total key/value pairs in myDict are : "
                                                      + myDict.Count);


            Console.WriteLine("The key/value pairs in myDict are : ");

            foreach (DictionaryEntry de in myDict)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

            myDict.Clear();

            Console.WriteLine("Total key/value pairs in myDict are : "
                                                      + myDict.Count);


            Console.WriteLine("The key/value pairs in myDict are : ");

            foreach (DictionaryEntry de in myDict)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
        }
    }
    }

