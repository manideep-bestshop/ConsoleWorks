using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public abstract class Vehicle
    {
        public abstract void StartEngine();

        public void Honk()
        {
            Console.WriteLine("Honking...");
        }
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting car engine.");
        }
    }


    public class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting motorcycle engine.");
        }
    }
    internal class AbstractionExample
    {
        static void Main()
        {
            Vehicle vehicle = new Car();
            vehicle.StartEngine();
            vehicle.Honk();

            vehicle = new Motorcycle();
            vehicle.StartEngine();
            vehicle.Honk();
        }
    }
}
