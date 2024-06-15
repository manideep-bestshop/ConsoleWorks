using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestPractices
{
    public class ProductService
    {
        public async Task<Product> GetProductAsync(int productId)
        {
            if (productId <= 0) throw new ArgumentException("Product ID must be positive", nameof(productId));

            // Simulate fetching product from database
            await Task.Delay(1000);
            return new Product { Id = productId, Name = "Sample Product", Price = 99.99m };
        }
    }

    internal class AsynchronousExam
    {
        static void Main()
        {
            ProductService productService = new ProductService();
            Product product = await productService.GetProductAsync(1);

            Console.WriteLine($"Product retrieved: {product.Name}, Price: {product.Price:C}");
        }
    }
}
