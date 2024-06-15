using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndMembers
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            double celsius = Double.Parse(temperatureCelsius);

            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
      
            double fahrenheit = Double.Parse(temperatureFahrenheit);

            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("select tconvertor direction");
            Console.WriteLine("1. Celsius to Fahrenheit.");
            Console.WriteLine("2. Fahrenheit to Celsius.");
            Console.Write(":");

            string selection = Console.ReadLine();
            double F, C = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please  Celsius temperature: ");
                    F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine() ?? "0");
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;

                case "2":
                    Console.Write("Please  Fahrenheit temperature: ");
                    C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine() ?? "0");
                    Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                    break;

                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }

        }
    }
}
