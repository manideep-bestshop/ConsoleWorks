using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBoxing
{
    enum Products
    {
        Pens,Books,Erasers
    }
    internal class EnumProduct
    {
        static void Main()
        {
            int PCode = 2, Qty = 0, price = 0, Amt = 0;
            Products prod=Products.Pens;    

            if(PCode==(int)Products.Pens)
            {
                Qty = 50;
                price = 5;
            }
            else if(PCode==(int)(Products.Books))
            {
                Qty = 20;
                price = 10;
                prod= Products.Books;
            }
            else if(PCode==(int)((Products.Erasers)))
            {
                Qty= 30;
                price = 3;
                prod= Products.Erasers;
            }
            Amt = price * Qty;
            Console.WriteLine("PCode :"+PCode);
            Console.WriteLine("p Name:" + prod);
            Console.WriteLine("Qty :"+Qty);
            Console.WriteLine("Price :"+price);
            Console.WriteLine("Amount :"+Amt);
        }
    }
}
