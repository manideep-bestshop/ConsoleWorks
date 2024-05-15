using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionVsInterface
{
    interface IArea
    {
        void CalculateArea();
    }
    class RectangleArea : IArea
    {
        public void CalculateArea()
        {
            int l = 30;
            int b = 90;
            int area = l * b;
            Console.WriteLine(area);
        }
    }
    class Square : IArea
    {
        public void CalculateArea()
        {
            int l = 30;
            int area = l * l;
            Console.WriteLine(area);
        }
    }
    internal class InterfaceExample
    {
        static void Main(string[] args)
        {
            RectangleArea rectangleArea = new RectangleArea();
            rectangleArea.CalculateArea();

            Square square = new Square();   
            square.CalculateArea();
        }
    }
}
