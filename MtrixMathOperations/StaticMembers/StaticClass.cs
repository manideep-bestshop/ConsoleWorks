using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    static class Tutorial
    {
        public static string Topic = "Static class";
    }
    internal class StaticClass
    {
        static void Main()
        {
            Console.WriteLine("Topic name is : {0} ", Tutorial.Topic);
        }
    }
}
