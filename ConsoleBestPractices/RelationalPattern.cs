using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Basic { get; set; }
        public double Tax { get; set; }
        public double NetSalary { get; set; }
    }

    internal class RelationalPattern
    {

        static void Main()
        {
            Employee employee = new Employee {Id=101,FirstName="Mani",LastName="Deep",Basic=25000 };
            Console.WriteLine(employee.FirstName);

        }
    }
}
