using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAsArray
{
    class Emp
    {
        private int EmpId;
        private string EmpName;
        private double EmpSal;
        
        public void GetInfo()
        {
            Console.WriteLine("Enter Emp Id");
            EmpId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            EmpSal =double.Parse(Console.ReadLine());    

        }
        public void Show()
        {
            Console.WriteLine("Id :"+EmpId);
            Console.WriteLine("Name :"+EmpName);
            Console.WriteLine("Salary :"+EmpSal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp[] e=new Emp[5];
            for(int i=0; i<e.Length; i++)
                e[i]=new Emp();
            for (int i = 0; i < e.Length; i++)
                e[i].GetInfo();
            for(int i= 0; i < e.Length;i++)
                e[i].Show();
        }
    }
}
