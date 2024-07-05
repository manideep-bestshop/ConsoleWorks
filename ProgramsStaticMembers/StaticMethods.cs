using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsStaticMembers
{
    class Numberofbones
    {

        static public int t = 203;

        public static void totalbones()
        {
            Console.WriteLine("Total number of bones in human body {0}", t);
        }
    }
    internal class StaticMethods
    {
        static void Main()
        {
            Numberofbones.totalbones();
        }
    }
}
