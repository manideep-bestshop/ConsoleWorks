using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    class Demo2
    {
        public int i;
        static Demo2()
        {
            Console.WriteLine("From static Constructor");
        }
        public Demo2()
        {
            Console.WriteLine("From parameterless Constructor");
        }
        public void Show()
        {
            Console.WriteLine("From show method");
        }
    }
    internal class WaysOfInstances
    {
        static void Main()
        {
            Type t = typeof(Demo2);

            Demo2 demo = (Demo2)Activator.CreateInstance(t);
            demo.Show();
        }
    }
}
