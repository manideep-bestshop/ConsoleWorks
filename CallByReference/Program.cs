using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReference
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int val;
			val = 4;
			Console.WriteLine("Value Before : {0}", val);
			square(ref val);
			Console.WriteLine("Value After : {0}", val);
			Console.Read();
		}
		static void square(ref int refParam)
		{
			refParam *= refParam;
		}
	}
}
