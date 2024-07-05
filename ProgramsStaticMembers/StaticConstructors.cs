using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsStaticMembers
{
    internal class StaticConstructors
    {
        static StaticConstructors()
        {

            Console.WriteLine("Example of Static Constructor");
        }

        public StaticConstructors(int j)
        {
            Console.WriteLine("Instance Constructor " + j);
        }

        public string StaticConstructors_detail(string name, string branch)
        {
            return "Name: " + name + " Branch: " + branch;
        }
        static void Main()
        {
            StaticConstructors obj = new StaticConstructors(1);

            Console.WriteLine(obj.StaticConstructors_detail("Manideep", "EEE"));

            StaticConstructors ob = new StaticConstructors(2);

            Console.WriteLine(ob.StaticConstructors_detail("Dinesh", "ECE"));
        }
    }
}
