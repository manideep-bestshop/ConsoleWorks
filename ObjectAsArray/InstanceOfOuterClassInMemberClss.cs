using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAsArray
{
    class Car3
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

            Car3 c = new Car3();
            public void GetInfo()
            {
                c.GetData();
                SName = "Maruthi";
            }
            public void Show()
            {
                c.Display();
                Console.WriteLine(SName);
            }
        }
    }

    internal class InstanceOfOuterClassInMemberClss
    {
        static void Main()
        {
            Car3.Sterio s = new Car3.Sterio();
            s.GetInfo();
            s.Show();
        }
    }
}
