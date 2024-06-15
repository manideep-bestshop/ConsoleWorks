using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    public class WeatherService
    {
        public (double Temperature, string Conditions) GetCurrentWeather()
        {
            return (72.5, "Sunny");
        }

        public void PrintWeather()
        {
            var (temperature, conditions) = GetCurrentWeather();
            Console.WriteLine($"The current temperature is {temperature}°F and the conditions are {conditions}.");
        }
    }
    internal class UseCsharpFeature
    {
        static void Main()
        {

            WeatherService weatherService = new WeatherService();
            weatherService.PrintWeather();
        }
    }
}
