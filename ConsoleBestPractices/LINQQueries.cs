using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetCustomersWithHighOrders()
        {
            return customerRepository.GetAllCustomers()
                .Where(c => c.Orders.Sum(o => o.TotalAmount) > 1000)
                .Select(c => new Customer
                {
                    Id = c.Id,
                    Name = c.Name,
                    Orders = c.Orders
                });
        }
    }
    internal class LINQQueries
    {
        static void Main()
        {
            ICustomerRepository customerRepository = new InMemoryCustomerRepository();
            CustomerService customerService = new CustomerService(customerRepository);

            IEnumerable<Customer> highOrderCustomers = customerService.GetCustomersWithHighOrders();

            foreach (var customer in highOrderCustomers)
            {
                Console.WriteLine($"Customer: {customer.Name}, Total Orders: {customer.Orders.Count}");
            }
        }
    }
}
