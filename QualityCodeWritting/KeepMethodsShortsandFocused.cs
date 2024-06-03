using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityCodeWritting
{
    public class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            if (ValidateOrder(order))
            {
                SaveOrder(order);
                NotifyCustomer(order);
            }
        }

        private bool ValidateOrder(Order order)
        {
            // Validate order details
            return order != null && order.Items.Count > 0;
        }

        private void SaveOrder(Order order)
        {
            // Save order to the database
            Console.WriteLine("Order saved to the database.");
        }

        private void NotifyCustomer(Order order)
        {
            // Send notification to the customer
            Console.WriteLine("Customer notified.");
        }
    }
    internal class KeepMethodsShortsandFocused
    {
        static void Main()
        {
            Order order = new Order { Items = new List<string> { "Item1", "Item2" } };
            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.ProcessOrder(order);
        }
    }
}
