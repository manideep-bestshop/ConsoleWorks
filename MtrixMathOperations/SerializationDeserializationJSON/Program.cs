
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerializationDeserializationJSON
{
    internal class Purchase
    {
        public string ProductName;
        public DateTime DateTime;
        public decimal ProductPrice;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Purchase purchase = new Purchase()
            {
                ProductName = "Laptop",
                DateTime =DateTime.Now,
                ProductPrice=55000

            };
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string jsonString=System.Text.Json.JsonSerializer.Serialize<Purchase>(purchase,options);

            File.WriteAllText("Purchase.Json", jsonString);


        }
    }
}
