using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    public class OrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly INotificationService notificationService;

        public OrderService(IOrderRepository orderRepository, INotificationService notificationService)
        {
            this.orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            this.notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
        }

        public async Task PlaceOrderAsync(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            await orderRepository.AddOrderAsync(order);
            await notificationService.NotifyOrderPlacedAsync(order);
        }
    }
    internal class NamingConventions
    {
        static void Main()
        {

            IOrderRepository orderRepository = new SqlOrderRepository();
            INotificationService notificationService = new EmailNotificationService();
            OrderService orderService = new OrderService(orderRepository, notificationService);

            Order order = new Order(DateTime.Now, 150);
            await orderService.PlaceOrderAsync(order);

            Console.WriteLine("Order placed successfully.");
        }
    }
}
