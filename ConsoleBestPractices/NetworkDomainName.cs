using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    internal class NetworkDomainName
    {
        static void Main()
        {
            string resultName;
            resultName = Environment.UserDomainName;
            Console.WriteLine("Network domain name: " + resultName);
        }
    }
}
