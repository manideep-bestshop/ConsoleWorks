using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndMembers
{
    public class Mobile
    {
        public static int Price = 12000;

        public static int Qty
        {
            get
            {
                return 5;
            }
        }
        public static void TotalAmount()
        {
            Console.WriteLine("Total Price :" + (Price * Qty));
        }
    }
    internal class StaticMembers
    {
        static void Main()
        {
            Console.WriteLine("Mobile Price :"+Mobile.Price);

            Console.WriteLine("Quantity :"+Mobile.Qty);
            
            Mobile.TotalAmount();   

        }
    }
}
