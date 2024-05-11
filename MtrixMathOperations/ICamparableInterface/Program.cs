using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICamparableInterface
{
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int Bill { get; set; }
        public int CompareTo(Customer other)
        {
            if (this.Id > other.Id)
                return 1;
            else if (this.Id < other.Id)
                return -1;
            else
                return 0;
        }

    }
    public class CustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if (x.Bill > y.Bill)
                return 1;
            else if (x.Bill < y.Bill)
                return -1;
            else
                return 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer { Id = 2, Name = "Manideep", Address = "Hyderabad", Bill = 256 };
            Customer c2 = new Customer { Id = 3, Name = "Sandeep", Address = "USA", Bill = 456 };
            Customer c3 = new Customer { Id = 1, Name = "Rajkumar", Address = "KOheda", Bill = 350 };
            Customer c4 = new Customer { Id = 4, Name = "Prashanth", Address = "KNR", Bill = 123 };


            List<Customer> customerList = new List<Customer>() { c1, c2, c3, c4 };
            CustomerComparer c = new CustomerComparer();
            customerList.Sort(c);

            foreach (Customer obj in customerList)
            {
                Console.Write("Id :" + obj.Id + ", Name :" + obj.Name + ", Address :" + obj.Address + ", Bill :" + obj.Bill);
                Console.WriteLine();
            }

        }
    }
}
