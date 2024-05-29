using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsInOneProgram
{
    // Abstract class demonstrating Abstraction
    public abstract class Shape
    {
        // Encapsulation with protected fields and public properties
        protected double width;
        protected double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Abstract method for calculating area (must be implemented by derived classes)
        public abstract double CalculateArea();

        // Virtual method for displaying shape details
        public virtual void Display()
        {
            Console.WriteLine($"Shape with Width: {Width} and Height: {Height}");
        }
    }

    // Derived class demonstrating Inheritance
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // Overriding the abstract method
        public override double CalculateArea()
        {
            return Width * Height;
        }

        // Overriding the virtual method
        public override void Display()
        {
            Console.WriteLine($"Rectangle with Width: {Width}, Height: {Height}, and Area: {CalculateArea()}");
        }
    }

    // Derived class demonstrating Inheritance
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // Overriding the abstract method
        public override double CalculateArea()
        {
            return 0.5 * Width * Height;
        }

        // Overriding the virtual method
        public override void Display()
        {
            Console.WriteLine($"Triangle with Base: {Width}, Height: {Height}, and Area: {CalculateArea()}");
        }
    }

    // Class demonstrating Polymorphism
    public class ShapeManager
    {
        public void DisplayShape(Shape shape)
        {
            shape.Display();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects of derived classes
            Shape rectangle = new Rectangle(10, 5);
            Shape triangle = new Triangle(8, 4);

            // Creating an instance of ShapeManager
            ShapeManager shapeManager = new ShapeManager();

            // Demonstrating Polymorphism
            shapeManager.DisplayShape(rectangle);
            shapeManager.DisplayShape(triangle);

            // Additional encapsulation demonstration
            Console.WriteLine($"Rectangle Width: {rectangle.Width}");
            rectangle.Width = 15;
            Console.WriteLine($"Updated Rectangle Width: {rectangle.Width}");
        }
    }
}
