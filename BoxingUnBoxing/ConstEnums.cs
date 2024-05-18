using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBoxing
{
    internal class ConstEnums
    {
        public void ConstMethod()
        {
            const int a = 233;
            Console.WriteLine(a);
            //a = a + 10; CTE
            int b = a;
            Console.WriteLine(b);
        }
        static void Main()
        {
            ConstEnums constEnums = new ConstEnums();
            constEnums.ConstMethod();


        }
    }
}
