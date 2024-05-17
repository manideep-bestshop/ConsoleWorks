using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExamples
{
    abstract class figure
    {
        public double Dim;
        public abstract double Area(); // we can not use static and private in abstraction
        public abstract double Peri();
    }
    class Circle : figure
    {
        public override double Area()
        {
            return Math.PI * Dim * Dim;
        }

        public override double Peri()
        {
            return 2*Math.PI * Dim;
        }
    }
    class Square : figure
    {
        public override double Area()
        {
            return Dim * Dim;
        }

        public override double Peri()
        {
            return 4*Dim;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            figure figure = null;
            Console.WriteLine("Enter Math Object Name");
            string s=Console.ReadLine();    
            if(s=="Circle")
                figure =new Circle();
            else
                figure = new Square();
            figure.Dim = 6;
            Console.WriteLine(figure.Area());
            Console.WriteLine(figure.Peri());
        }
    }
}
