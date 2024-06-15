using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    class Demo
    {
        public int i = 9;
    }
    internal class NullReferenceExceptionEx
    {
        static void Main()
        {
            try
            {
                Demo d = new Demo();
                d = null;
                Console.WriteLine(d.i);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Object is set to null"+ex);
            }
        }
    }
}
