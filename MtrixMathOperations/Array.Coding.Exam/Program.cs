using System;

namespace Array.Coding.Exam
{
    class CurryMaker
    {
        public string ChikenMaker(string ChikenMaer)
        {
            return ChikenMaer;
        }
    }
    internal class Program
    {

    
        static void Main(string[] args)
        {

            CurryMaker curryMaker = new CurryMaker();
            string result = curryMaker.ChikenMaker("Chiken Curry Ready");
            Console.WriteLine(result);

            //int[] number = { 1, 3, 4, 5, 6, 7, };

            //int input = 10;
            //bool isNumberPresent = false;

            //foreach (int i in number)
            //{
            //    if (i == input)

            //        isNumberPresent = true;

            //}
            //if(isNumberPresent)
            //    Console.WriteLine("Number found");
            //else
            //    Console.WriteLine("Number not found");
        }
    }
}
