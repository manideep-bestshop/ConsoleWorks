using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    abstract class Shape
    {

        public abstract int area();
    }

   
    class Square : Shape
    {

        private int side;
        public Square(int x = 0)
        {
            side = x;
        }
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
    internal class AbstractionExamples
    {
        static void Main()
        {
            Shape sh = new Square(4);

            double result = sh.area();

            Console.WriteLine("{0}", result);
        }
    }
}
