using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExamples
{
    internal class Program
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome Friends!");
        }

        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day!");
        }
        public void show()
        {
            Console.WriteLine("From show method..");
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.show();

            welcome();

            HaveAnice();
        }
    }
}
