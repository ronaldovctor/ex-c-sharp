using System.Globalization;
using Interface.Entities;
using Interface.Services;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the contract data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new(number, date, value);
            PaymentService paymentService = new(new PaypalService());
            paymentService.ProcessContract(contract, installments);

            Console.WriteLine("Installments: ");

            foreach (Installment item in contract.Installments)
            {
                Console.WriteLine($"{item.DueDate.ToString("dd/MM/yyyy")} - {item.Amount.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}