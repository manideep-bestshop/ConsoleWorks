using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialCalssMethods
{
    internal class ReadingArrayOfChar
    {
        static void Main()
        {
            char[] ch = new char[10];
            int n=Console.In.Read(ch, 0, ch.Length);

            for(int i=0;i<ch.Length;i++)
            {
                Console.Out.Write(ch[i]);
            }
        }
    }
}
