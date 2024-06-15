using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Manideep",
                Gender = "Male",
                Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Sandeep",
                Gender = "Male",
                Salary = 300000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Srinivas",
                Gender = "Male",
                Salary = 40000
            };
          
            Employee[] arrayEmployees = new Employee[3];
            arrayEmployees[0] = emp1;
            arrayEmployees[1] = emp2;
            arrayEmployees[2] = emp3;
            
            List<Employee> listEmployees = arrayEmployees.ToList();
            foreach (Employee emp in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();
          
            Employee[] arrayAllEmployeesFromList = listEmployees.ToArray();
            foreach (Employee emp in arrayAllEmployeesFromList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();
            
            Dictionary<int, Employee> dictionaryEmployees = listEmployees.ToDictionary(employee => employee.ID, employee => employee);
            foreach (KeyValuePair<int, Employee> keyValuePairEmployees in dictionaryEmployees)
            {
                Console.WriteLine("Key = {0}", keyValuePairEmployees.Key);
                Employee emp = keyValuePairEmployees.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();

            Dictionary<int, Employee> dictionaryEmployeesFromArray = arrayEmployees.ToDictionary(employee => employee.ID, employee => employee);

            foreach (KeyValuePair<int, Employee> kvp in dictionaryEmployeesFromArray)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Employee emp = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
           
            Employee[] arrayAllEmployeesFromDictionary = dictionaryEmployeesFromArray.Values.ToArray();
            foreach (Employee emp in arrayAllEmployeesFromDictionary)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();
           
            List<Employee> listAllEmployeesFromDictionary = dictionaryEmployeesFromArray.Values.ToList();
            foreach (Employee emp in listAllEmployeesFromDictionary)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}
