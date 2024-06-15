using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    public interface IOrderRepository
    {
        Task AddOrderAsync(Order order);
    }

    public interface INotificationService
    {
        Task NotifyOrderPlacedAsync(Order order);
    }

    public class SqlOrderRepository : IOrderRepository
    {
        public Task AddOrderAsync(Order order)
        {
            // Simulate adding order to database
            Console.WriteLine("Order added to the database.");
            return Task.CompletedTask;
        }
    }

    public class EmailNotificationService : INotificationService
    {
        public Task NotifyOrderPlacedAsync(Order order)
        {
            // Simulate sending email notification
            Console.WriteLine("Email notification sent.");
            return Task.CompletedTask;
        }
    }

    internal class InterfaceAndDI
    {
        static async Task  Main()
        {

            IOrderRepository orderRepository = new SqlOrderRepository();
            INotificationService notificationService = new EmailNotificationService();
            OrderService orderService = new OrderService(orderRepository, notificationService);

            Order order = new Order(DateTime.Now, 150);
            await orderService.PlaceOrderAsync(order);

            Console.WriteLine("Order placed and notification sent.");
        }
    }
}
