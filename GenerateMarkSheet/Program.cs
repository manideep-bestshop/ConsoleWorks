using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateMarkSheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollNumber, maths, physics, chemistry, total;
            float percentage;
            string name;
            Console.WriteLine("Enter Roll Number :");
            rollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            name = Console.ReadLine();
            Console.WriteLine("Mark of Maths : ");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of Physics : ");
            physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of Chemistry : ");
            chemistry = Convert.ToInt32(Console.ReadLine());
            total = maths + physics + chemistry;
            percentage = total / 3.0f;
            Console.WriteLine("Total : " + total);
            Console.WriteLine("Percentage : " + percentage);
          
            if (percentage >= 35 && percentage < 50)
            {
                Console.WriteLine("Grade is C");
            }
            if (percentage >= 50 && percentage <= 60)
            {
                Console.WriteLine("Grade is B");
            }
            if (percentage > 60 && percentage <= 80)
            {
                Console.WriteLine("Grade is A");
            }
            if (percentage > 80 && percentage <= 100)
            {
                Console.WriteLine("Grade is A+");
            }
            Console.ReadLine();
        
        }
    }
}
