using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    public class PaymentService
    {
        public void ProcessPayment(Order order, PaymentDetails paymentDetails)
        {
            if (order == null) throw new ArgumentNullException(nameof(order), "Order cannot be null");
            if (paymentDetails == null) throw new ArgumentNullException(nameof(paymentDetails), "Payment details cannot be null");

            try
            {
                // Simulate payment processing
                Console.WriteLine("Payment processed successfully.");
            }
            catch (PaymentException ex)
            {
                // Log the exception
                throw new InvalidOperationException("Payment processing failed", ex);
            }
        }
    }
    internal class ErrorHandling
    {
        static void Main()
        {
            try
            {
                Order order = new Order(DateTime.Now, 150);
                PaymentDetails paymentDetails = new PaymentDetails();

                PaymentService paymentService = new PaymentService();
                paymentService.ProcessPayment(order, paymentDetails);

                Console.WriteLine("Payment processed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
