using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create new stopwatch
			Stopwatch stopwatch = new Stopwatch();
			// Begin timing
			stopwatch.Start();
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("HI");
			}
			// Stop timing
			stopwatch.Stop();
			Console.WriteLine("Time Elapsed : {0}",
				stopwatch.Elapsed);
			Console.ReadLine();
		}
	}
}
