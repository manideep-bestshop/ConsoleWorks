using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInterface
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary {  get; set; }
    }
    public class Organization:IEnumerable
    {
        List<Employee> employees = new List<Employee>();
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
        public int Count { get { return employees.Count; } }

        public IEnumerator GetEnumerator()
        {
            return new OrganisationEnumerator(this);
        }
    }
    public class OrganisationEnumerator : IEnumerator
    {
        Organization OrgCall;
        int currentIndex;
        Employee currentEmployee;

        public OrganisationEnumerator(Organization Org)
        {
            OrgCall = Org;
            currentIndex =-1;
        }
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Organization employees = new Organization();
            employees.Add(new Employee() { Id=100,Name="Manideep",Job="Developer",Salary=40000});
            employees.Add(new Employee() { Id = 101, Name = "Sandeep", Job = "CEO", Salary = 200000 });
            employees.Add(new Employee() { Id = 102, Name = "Srinivas", Job = "Sr Developer", Salary = 100000 });
            employees.Add(new Employee() { Id = 103, Name = "Rajkumar", Job = "Developer", Salary = 50000 });

            foreach (Employee employee in employees)
            {
                Console.WriteLine("id:"+employee.Id+",Name:"+employee.Name+", Job:"+employee.Job+", Salary:"+employee.Salary);
            }
        }
    }
}
