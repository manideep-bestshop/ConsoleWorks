using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionVsInterface
{
    interface IPolygon
    {
        void calculateArea(int l,int b);
    }
    class Rectangle : IPolygon
    {
        public void calculateArea(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area of Rectangle :"+area);
        }
    }
    internal class CsharpInterface
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.calculateArea(10, 20);
        }
    }
}
