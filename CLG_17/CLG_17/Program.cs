using CLG_17.Entities;
using CLG_17.Entities.Enums;
using System;
using System.Globalization;

namespace CLG_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this product: ");
            int items = int.Parse(Console.ReadLine());

            for (int i = 1; i <= items; i++)
            {
                Console.WriteLine($"Enter #{i}item data: ");
                Console.WriteLine("Product name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.WriteLine("Quantity: ");
                int quant = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quant, price, product);

                order.AddItem(orderItem);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}
