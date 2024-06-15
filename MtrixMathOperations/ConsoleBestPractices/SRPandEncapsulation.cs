using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    public class Order
    {
        private DateTime orderDate;
        private decimal totalAmount;

        public DateTime OrderDate
        {
            get => orderDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Order date cannot be in the future");
                orderDate = value;
            }
        }

        public decimal TotalAmount
        {
            get => totalAmount;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Total amount cannot be negative");
                totalAmount = value;
            }
        }

        public Order(DateTime orderDate, decimal totalAmount)
        {
            OrderDate = orderDate;
            TotalAmount = totalAmount;
        }

        public void ApplyDiscount(decimal discount)
        {
            if (discount < 0 || discount > 1)
                throw new ArgumentException("Discount must be between 0 and 1");

            TotalAmount *= (1 - discount);
        }
    }

    internal class SRPandEncapsulation
    {
        static void Main()
        {
            Order order = new Order(DateTime.Now, 200);
            order.ApplyDiscount(0.2m);

            Console.WriteLine($"Order Date: {order.OrderDate}, Total Amount after discount: {order.TotalAmount:C}");
        }
    }
}
