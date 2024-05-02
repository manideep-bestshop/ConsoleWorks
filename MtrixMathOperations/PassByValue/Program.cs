using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue
{
	internal class Program
	{

		static void Cube(int x)
		{
			x = x * x * x;
			Console.WriteLine("Value Within the Cube method : {0}", x);
		}
		static void Main(string[] args)
		{
			int num = 5;
			Console.WriteLine("Value Before the Method is called : {0}", num);
			Cube(num);
			Console.WriteLine("Value After the Method is called : {0}", num);
			Console.ReadKey();
		}
	}
}
