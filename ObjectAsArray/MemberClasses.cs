using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAsArray
{
    class Car
    {
        private string CName;
        public void GetData()
        {
            CName = "Swift";
        }
        public void Display()
        {
            Console.WriteLine(CName);
        }
        public class Sterio
        {
            public string SName;
            public void GetInfo()
            {
                SName = "Maruthi";
            }
            public void Show()
            {
                Console.WriteLine(SName);
            }
        }
    }
    
    internal class MemberClasses
    {
        static void Main()
        {
            Car c=new Car();
            Car.Sterio s=new Car.Sterio();
            c.GetData();
            s.GetInfo();
            c.Display();
            s.Show();
        }
    }
}
