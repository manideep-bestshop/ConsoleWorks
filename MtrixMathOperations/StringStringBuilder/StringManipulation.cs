using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStringBuilder
{
    internal class StringManipulation
    {
        static void Main()
        {
            string text = "   C# Programming   ";

            // Trim whitespace
            string trimmedText = text.Trim();
            Console.WriteLine("Trimmed: '" + trimmedText + "'");

            // Convert to uppercase
            string upperText = text.ToUpper();
            Console.WriteLine("Uppercase: " + upperText);

            // Replace substring
            string replacedText = text.Replace("C#", "Java");
            Console.WriteLine("Replaced: " + replacedText);

            // Substring
            string subText = text.Substring(3, 5);
            Console.WriteLine("Substring: " + subText);
        }
    }
}
