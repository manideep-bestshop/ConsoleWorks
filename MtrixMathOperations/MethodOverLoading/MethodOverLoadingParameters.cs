using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class methodwithpara
    {
        public void Show(int x)
        {
            Console.WriteLine(x);
        }
        public void Show(int x,int y=17)
        {
            Console.WriteLine(x+" "+y);
        }
    }
    internal class MethodOverLoadingParameters
    {
        static void Main()
        {
            methodwithpara mp = new methodwithpara();
            mp.Show(123);
            mp.Show(23, 36);
        }
    }
}
