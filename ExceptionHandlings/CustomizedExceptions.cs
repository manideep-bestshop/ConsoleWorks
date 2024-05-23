using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlings
{
    class InvSalException : Exception
    {
        private int Salary;
        public InvSalException(int pay)
        {
            Salary = pay;
        }
        public void Show()
        {
            Console.WriteLine("Invalid Salary :"+Salary);
        }
    }
    internal class CustomizedExceptions
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter Emp Id");
                int Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Salary");
                int salary = int.Parse(Console.ReadLine());

                if (salary < 0)
                    throw new InvSalException(salary);
                Console.WriteLine("Id"+Id);
                Console.WriteLine("Salary:"+salary);


            }
            catch(InvSalException e)
            {
                Console.WriteLine("Salary cant be less than Zero..");
                e.Show();
            }
        }
    }
}
