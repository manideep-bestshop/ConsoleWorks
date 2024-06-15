using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class Sample

    {
        public void Show(params int[] arr)
        {
            foreach(int x in arr)
            {
                Console.WriteLine(x);

            }
            Console.WriteLine();
        }
    }
    internal class ParamsArgument
    {
        static void Main()
        {
           Sample s= new Sample();
            s.Show(12,23,44,55,66);
            s.Show();
            s.Show(12, 34, 55, 66, 77);
            int[] a = {1,2,3,4,4,4};
            s.Show(a);
        }
    }
}
