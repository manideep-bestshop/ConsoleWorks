using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    class rectangle
    {

        // declaring delegate
        public delegate void rectDelegate(double height,
                                          double width);

        public void area(double height, double width)
        {
            Console.WriteLine("Area is: "+ (width * height));
        }

        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is:  "+2 * (width + height));
        }


        internal class MulticastDelegate
        {
            static void Main()
            {
                rectangle rect = new rectangle();

              
                rectDelegate rectdele = new rectDelegate(rect.area);

              
                rectdele += rect.perimeter;

                
                rectdele(6.3, 4.2);
                Console.WriteLine();


                rectdele(16.3, 10.3);
            }
        }
    }
}