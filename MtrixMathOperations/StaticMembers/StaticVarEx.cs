using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    class StaticVar
    {
        public static int num;

        public void count()
        {
            num++;
        }

        public int getNum()
        {
            return num;
        }
    }
    internal class StaticVarEx
    {
        static void Main()
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();

            s1.count();
            s1.count();
            s1.count();

            s2.count();
            s2.count();
            s2.count();

            Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            Console.WriteLine("Variable num for s2: {0}", s2.getNum());
        }
    }
}
