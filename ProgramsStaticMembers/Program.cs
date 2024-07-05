using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsStaticMembers
{
    static class Tutorial
    {
        public static string Topic = "Static class";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tutorial.Topic);
        }
    }
}
