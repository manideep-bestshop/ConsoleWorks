using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsStaticMembers
{
    class Vehicle
    {

        public static string Color= "Red";
    }
    internal class StaticVariables
    {
        static void Main()
        {
            Console.WriteLine(Vehicle.Color);
        }
    }
}
