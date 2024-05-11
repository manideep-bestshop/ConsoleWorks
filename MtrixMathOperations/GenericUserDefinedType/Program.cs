using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUserDefinedType
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();

            Customer c1 = new Customer { Id = 1, Name = "Manideep", Address = "Hyderabad" };
            Customer c2 = new Customer { Id = 2, Name = "Sandeep", Address = "USA" };
            Customer c3 = new Customer { Id = 3, Name = "Rajkumar", Address = "KOheda" };
            Customer custc4omer3 = new Customer { Id = 4, Name = "Prashanth", Address = "KNR" };

            customerList.Add(c1);
            customerList.Add(c2);
            customerList.Add(c3);
            // OR
            //  List<Customer> CL= new List<Customer>(){c1,c2,c3 };
            foreach (Customer c in customerList)
            {
                Console.Write("Id :" + c.Id + ", Name :" + c.Name + ", Address :" + c.Address);
                Console.WriteLine();
            }

        }
    }
}
