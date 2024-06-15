using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayArrayListDictionaryListExamples
{
    internal class DictionaryExample
    {
        static void Main()
        {
            Dictionary<string, Employee> Employees = new Dictionary<string, Employee>();
            Employee emp1 = new Employee("E01", "Manideep");
            Employee emp2 = new Employee("E02", "Sandeep");
            Employee emp3 = new Employee("E03", "Rajkumar");
            Employee emp4 = new Employee("E04", "Keerthana");
            Employee emp5 = new Employee("E05", "Srinu");
            Employees.Add(emp1.empID, emp1);
            Employees.Add(emp2.empID, emp2);
            Employees.Add(emp3.empID, emp3);
            Employees.Add(emp4.empID, emp4);
            Employees.Add(emp5.empID, emp5);
           // Console.WriteLine(Employees["Emp05"].getNameAndID());
            foreach (KeyValuePair<string, Employee> emp in Employees)
            {
                Console.WriteLine(emp.Key + "  >>>>>  " + emp.Value.empName);
               // Console.WriteLine(emp.Value.ToString());
            }
        }
        public class Employee
        {
            public string empID;
            public readonly string empName;
            public Employee(string empID, string name)
            {
                this.empID = empID;
                this.empName = name;
            }
        }
    }
}
