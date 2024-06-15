using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndMembers
{

  
    public class Bus
    {
        
        protected static readonly DateTime globalStartTime;
        protected int RouteNumber { get; set; }

        static Bus()
        {
            globalStartTime = DateTime.Now;

            Console.WriteLine("Static constructor sets global start time to {0}",
                globalStartTime.ToLongTimeString());
        }

        public Bus(int routeNum)
        {
            RouteNumber = routeNum;
            Console.WriteLine("Bus {0} is created.", RouteNumber);
        }
        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - globalStartTime;

            Console.WriteLine("{0} is starting its route {1:N2} minutes after global start time {2}.",
                                    this.RouteNumber,
                                    elapsedTime.Milliseconds,
                                    globalStartTime.ToShortTimeString());
        }
    }
    internal class StaticConstructor
    {
        static void Main()
        {
             Bus bus1 = new Bus(71);
             Bus bus2 = new Bus(72);

            bus1.Drive();
            System.Threading.Thread.Sleep(25);
            bus2.Drive();
       }
    }
}
