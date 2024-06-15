using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExamples
{
    abstract class Mandal
    {

        public Mandal()
        {
            Console.WriteLine("Mandal Constructor");
        }
    }

    class Village : Mandal
    {
        public Village()
        {
            Console.WriteLine("Village Constructor");
        }
    }
    internal class AbstractConstuctor
    {
        static void Main()
        {
            Village village = new Village();    
        }
    }
}
