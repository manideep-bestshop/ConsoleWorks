using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Base1 //parent class
    {
        public void Show()
        {
            Console.WriteLine("From show of parent..");
        }
        public virtual void Display()
        {
            Console.WriteLine("From Display of Parent..");
        }
        public virtual void Retr()
        {
            Console.WriteLine("From Retrb of Parent..");
        }
    }
    class Derived1:Base1
    {
        public new virtual void Show()
        {
            Console.WriteLine("From Show of Child..");
        }
        public override void Display()
        {
            Console.WriteLine("From Display of Child..");
        }
        public new virtual void Retr()
        {
            Console.WriteLine("From Retr of Child..");
        }
    }
    class Derived2:Derived1 // Grand child Class
    {
        public override void Show()
        {
            Console.WriteLine("From Show of Grand Child Class");
        }
        public override void Display()
        {
            Console.WriteLine("From Display of Grand Child Class");
        }
        public override void Retr()
        {
            Console.WriteLine("From Retr of Grand Child Class");
        }
    }
    internal class StaticDynamicBinding
    {
        static void Main()
        {
            Derived1 d= new Derived1();
            Base1 b = d;

            b.Show();
            b.Display();
            b.Retr();

            Derived2 dd= new Derived2();
            Derived1 ddd= dd;
            ddd.Show();
            ddd.Display();
            ddd.Retr(); 
        }
    }
}
