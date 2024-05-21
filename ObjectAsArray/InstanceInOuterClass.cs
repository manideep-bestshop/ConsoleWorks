using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAsArray
{
    class Car2
    {
        private string CName;
        public void GetData()
        {
            CName = "Swift";
            sterio.GetInfo();
        }
        public void Display()
        {
            Console.WriteLine(CName);
            sterio.Show();
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
        Sterio sterio = new Sterio();
    }

    internal class InstanceInOuterClass
    {
        static void Main()
        {
            Car2 car2 = new Car2();
            car2.GetData();
            car2.Display();

        }
    }
}
