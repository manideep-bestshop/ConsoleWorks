using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class ContructorDemo
    {
        private int i;
        public ContructorDemo()
        {
            Console.WriteLine("enter Value i:");
            i=int.Parse(Console.ReadLine());
        }
        public ContructorDemo(int k)
        {
            i = k;
        }
        public void Show()
        {
            Console.WriteLine("i="+i);
        }
    }
    internal class ConstructorPara
    {
        static void Main()
        {
            ContructorDemo contructorDemo = new ContructorDemo();
            ContructorDemo c = new ContructorDemo(66);
            contructorDemo.Show();
            c.Show();
        }
    }
}
