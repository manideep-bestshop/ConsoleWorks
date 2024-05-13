using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSubStrings
{
    internal class Program
    {
        string value, substring;
        int j, i;
        string[] a = new string[5];
        void input()
        {
            Console.WriteLine("Enter the String : (should be less than or equal to 5 letters)");
            value = Console.ReadLine();
            Console.WriteLine("All Possible Substrings of the Given String are :");
            for (i = 1; i <= value.Length; i++)
            {
                for (j = 0; j <= value.Length - i; j++)
                {
                    substring = value.Substring(j, i);
                    a[j] = substring;
                    Console.WriteLine(a[j]);
                }
            }
        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.input();
            Console.ReadLine();
        }
    }
}
