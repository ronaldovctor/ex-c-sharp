using System.Globalization;
using Enum_Composicao.Entities;
using Enum_Composicao.Entities.Enum;

namespace Enum_Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client cl = new(name, email, birthDate);

            Console.WriteLine("Enter order data: ");

            Console.Write("Status:");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Order or = new(DateTime.Now, os, cl);

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Enter {i} item data: ");

                Product p = new();
                Console.Write("Product name: ");
                p.Name = Console.ReadLine();

                Console.Write("Product price: ");
                p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int qt = int.Parse(Console.ReadLine());
                OrderItem oi = new(p, qt);
                or.AddOrder(oi);

                Console.WriteLine("");
            }

            Console.WriteLine("Order Sumary: ");

            Console.WriteLine($"Order moment: {or.Moment}");
            Console.WriteLine($"Order status: {or.Status}");
            Console.WriteLine($"Client: {or.Buyer.Name} - {or.Buyer.BirthDate.ToString("dd/MM/YYYY")} - {or.Buyer.Email}");

            Console.WriteLine("Order items:");
            Console.WriteLine(or);

        }
    }
}