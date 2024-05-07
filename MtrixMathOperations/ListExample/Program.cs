using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"Apple", "Banana" ,"Water melon"};

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // Creating a List of integers 
            // Here we are not setting 
            // Capacity explicitly 
            List<int> firstlist = new List<int>();

            // adding elements in firstlist 
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);

            // Printing the Capacity of firstlist 
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist 
            Console.WriteLine("Count Is: " + firstlist.Count);

            // Adding some more 
            // elements in firstlist 
            firstlist.Add(5);
            firstlist.Add(6);

            // Printing the Capacity of firstlist 
            // It will give output 8 as internally 
            // List is resized 
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist 
            Console.WriteLine("Count Is: " + firstlist.Count);
        }
    }
}
