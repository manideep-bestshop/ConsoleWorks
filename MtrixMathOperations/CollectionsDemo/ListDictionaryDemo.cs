using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class ListDictionaryDemo
    {
        static void Main()
        {

            Dictionary<string,string> listCities = new Dictionary<string,string>();

            listCities.Add("Australia", "Canberra");
            listCities.Add("Belgium", "Brussels");
            listCities.Add("Netherlands", "Amsterdam");
            listCities.Add("China", "Beijing");
            listCities.Add("Russia", "Moscow");
            listCities.Add("India", "New Delhi");

            Console.WriteLine("Total key/value pairs in myDict are : " + listCities.Count);

            Console.WriteLine("The key/value pairs in myDict are : ");

            foreach (var de in listCities)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
        }
    }
}
