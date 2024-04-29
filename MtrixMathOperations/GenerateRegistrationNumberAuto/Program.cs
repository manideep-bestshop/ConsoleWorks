using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRegistrationNumberAuto
{
    internal class Program
    {
        int regnumber;
        static int nextnum;
        static Program()
        {
            nextnum = 1000;
        }
        Program()
        {
            regnumber = ++nextnum;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("#1 : {0}", p.regnumber);
            p = new Program();
            Console.WriteLine("#2 : {0}", p.regnumber);
           p = new Program();
            Console.WriteLine("#3 : {0}", p.regnumber);
            Console.ReadLine();
        }
    }
}
