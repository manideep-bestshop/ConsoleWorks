using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesInAlphabetical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Ram");
            names.Add("Rose");
            names.Add("Abs");
            names.Add("Edward");
            names.Add("Sita");
            names.Sort();
            foreach (string s in names)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
