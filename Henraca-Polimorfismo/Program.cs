using System.Globalization;
using Henraca_Polimorfismo.Entities;

namespace Henraca_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or Company (c/i)? ");
                char c = char.Parse(Console.ReadLine());

                if(c == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Individual individual = new(name, income, health);
                    taxPayers.Add(individual);
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    Company company = new(name, income, employees);
                    taxPayers.Add(company);
                }
            }

            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer item in taxPayers)
            {
                Console.WriteLine(item);
            }
        }
    }
}