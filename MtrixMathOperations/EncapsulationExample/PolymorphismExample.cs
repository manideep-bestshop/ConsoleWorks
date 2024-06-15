using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    // Base class
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    // Derived class
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Derived class
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
    internal class PolymorphismExample
    {
        static void Main()
        {
            Shape shape = new Circle();
            shape.Draw(); 

            shape = new Rectangle();
            shape.Draw(); 
        }
    }
}
