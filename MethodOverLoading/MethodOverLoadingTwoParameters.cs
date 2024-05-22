using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class MethodOver
    {
        public void Show(int x,byte y)
        {
            Console.WriteLine(x+" "+y);
        }
        public void Show(byte x,int y)
        {
            Console.WriteLine(x+" "+y);
        }
    }
    internal class MethodOverLoadingTwoParameters
    {
        static void Main()
        {
            int i = 12;
            byte j = 33;
            MethodOver m= new MethodOver();
            m.Show(i,j);
            byte b = 98;
            int n = 27;
            MethodOver m2= new MethodOver();
            m2.Show(b, n);
            m2.Show((int)j, b);

        }
    }
}
