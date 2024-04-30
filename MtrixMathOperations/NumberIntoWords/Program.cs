using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberIntoWords
{
    internal class Program
    {
        static void PrintWords(int num)
        {
            string[] words = { "zero", "one", "two",
                        "three", "four", "five",
                        "six", "seven", "eight",
                        "nine" };

            int digit = 0;
            int i = 0;
            int j = 0;

            int[] digit_array = new int[10];

            while (num > 0)
            {
                digit = num % 10;

                digit_array[i++] = digit;
                num = num / 10;
            }

            for (j = i - 1; j >= 0; j--)
            {
                Console.Write(words[digit_array[j]] + " ");
            } 
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Number in words: ");
            PrintWords(num);
        }
    }
}
