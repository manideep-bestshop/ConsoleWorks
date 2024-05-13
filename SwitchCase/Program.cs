using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string gender = "Male";

			switch (gender)
			{
				case "Male":
					Console.WriteLine("He is male...");
					break;
				case "Female":
					Console.WriteLine("She is female...");
					break;
				default:
					Console.WriteLine("Default");
					break;
			}

			//hit ENTER to exit
			Console.ReadLine();
		}
	}
	
}
