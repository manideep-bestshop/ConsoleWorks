using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal class StaticEx
    {
        static StaticEx()
        {

            Console.WriteLine("Example of Static Constructor");
        }

        // Instance constructor.
        public StaticEx(int j)
        {
            Console.WriteLine("Instance Constructor " + j);
        }

        // Instance method.
        public string g1_detail(string name, string branch)
        {
            return "Name: " + name + " Branch: " + branch;
        }
        static void Main()
        {
            StaticEx obj = new StaticEx(1);

            Console.WriteLine(obj.g1_detail("Manideep", "EEE"));

            StaticEx ob = new StaticEx(2);

            Console.WriteLine(ob.g1_detail("Keerthana", "BSc"));
        }
    }
}
